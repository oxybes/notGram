using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstaSharper.API;
using InstaSharper.Classes;
using InstaSharper.Classes.ResponseWrappers;
using MetroFramework.Forms;

namespace WindowsFormsApp2.Forms
{
    public partial class HandleChallengeForm : MetroForm
    {
        private int CountTimer;
        private IInstaApi api;
        private Timer timerTime;
        private bool reset = false;
        public HandleChallengeForm(IInstaApi api)
        {
            InitializeComponent();
            this.api = api;
            CountTimer = 60;
            timerTime = new Timer();
        }

        private void HandleChallengeForm_Load(object sender, EventArgs e)
        {
            HandleChallenge();
        }

        async void HandleChallenge(bool resend = false)
        {

            try
            {
                IResult<InstaResetChallenge> challenge = null;
                if (!resend)
                    challenge = await api.GetVerifyStep();
                else
                    challenge = await api.ResetChallenge();
                if (challenge.Succeeded)
                {
                    if (challenge.Value.StepData != null)
                    {
                        if (!string.IsNullOrEmpty(challenge.Value.StepData.PhoneNumber))
                        {
                            if (!resend)
                                radioPhone.Checked = false;
                            radioPhone.Text = challenge.Value.StepData.PhoneNumber;
                        }
                        if (!string.IsNullOrEmpty(challenge.Value.StepData.Email))
                        {
                            if (!resend)
                                radioMail.Checked = false;

                            radioMail.Text = challenge.Value.StepData.Email;
                        }
                    }
                }
                else
                    MessageBox.Show(challenge.Info.Message, "ERR");
            }
            catch (Exception ex) {  }
        }

        private  async void B_SendCode_Click(object sender, EventArgs e)
        {
            if (api == null)
                return;
            try
            {
                // Note: every request to this endpoint is limited to 60 seconds
                b_SendCode.Enabled = false;
                timerTime.Interval = 1000;
                timerTime.Tick += timer_Tick;

                if (radioMail.Checked)
                {
                    IResult<InstaResetChallenge> email = null;
                    IResult<InstaResetChallenge> povtor = null;
                    if (reset)
                    {
                        povtor =  await api.ResetChallenge();
                    }
                    else
                    {
                         email = await api.ChooseVerifyMethod(1);
                         reset = true;
                    }

                    timerTime.Start();

                    if (email != null)
                    {
                        if (email.Succeeded)
                        {
                            MessageBox.Show($"We sent verify code to this email:\n{email.Value.StepData.Email}");
                        }
                        else
                            MessageBox.Show(email.Info.Message, "ERR");
                    }
                }
                else
                {
                    IResult<InstaResetChallenge> phoneNumber = null;
                    IResult<InstaResetChallenge> povtor = null;
                    if (reset)
                    {
                        povtor = await api.ResetChallenge();
                    }
                    else
                    {
                        phoneNumber = await api.ChooseVerifyMethod(0);
                    }

                    timerTime.Start();
                    if (phoneNumber != null)
                    {
                        if (phoneNumber.Succeeded)
                        {
                            if(phoneNumber.Value.StepData.PhoneNumber != null)
                            MessageBox.Show(
                                $"We sent verify code to this phone number(it's end with this):\n{phoneNumber.Value.StepData.PhoneNumber}");
                        }
                        else
                            MessageBox.Show(phoneNumber.Info.Message, "ERR");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERR");
                //ex.PrintException("ChallengeSendCodeButtonClick");
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {

            this.b_SendCode.Text = (--CountTimer).ToString();
            if (CountTimer == 0)
            {
                b_SendCode.Enabled = true;
                b_SendCode.Text = "Send code";
                timerTime.Tick -= timer_Tick;
                CountTimer = 60;
            }
        }

        private  async void B_Auth_Click(object sender, EventArgs e)
        {
            if (api == null)
                return;
            try
            {
                tBox_Code.Text = tBox_Code.Text.Trim();
                tBox_Code.Text = tBox_Code.Text.Replace(" ", "");
                var regex = new Regex(@"^-*[0-9,\.]+$");
                if (!regex.IsMatch(tBox_Code.Text))
                {
                    MessageBox.Show("Verification code is numeric!!!", "ERR");
                    return;
                }

                if (tBox_Code.Text.Length != 6)
                {
                    MessageBox.Show("Verification code must be 6 digits!!!", "ERR");
                    return;
                }

                var verify = await api.SendVerifyCode(tBox_Code.Text);
                if (verify.Succeeded)
                {
                    var log = await api.LoginAsync();
                    if (log.Value == InstaLoginResult.TwoFactorRequired)
                    {

                        MessageBox.Show(
                            "Извините, наше приложение не поддерживает 2-х этапную аутенфикацию. Пожалуйста, отключите её для дальнейшего использования notGram");
                        return;
                    }
                    if (log.Succeeded)
                        Close();
                    else
                    {
                        MessageBox.Show($"{log.Info.Message}");
                    }
                }
                else
                {
                    //if (verify.Value == InstaLogin.TwoFactorRequired)
                    //{
                    //    LoginGrid.Visibility = Challenge1Grid.Visibility = Challenge2Grid.Visibility = Visibility.Collapsed;
                    //    ChallengeVerificationCodeText.Text = "";

                    //    TwoFactorVerificationCodeText.Text = "";
                    //    Helper.AppName.ChangeAppTitle();
                    //    TwoFactorGrid.Visibility = Visibility.Visible;
                    //}
                }
                MessageBox.Show(verify.Info.Message, "ERR");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
