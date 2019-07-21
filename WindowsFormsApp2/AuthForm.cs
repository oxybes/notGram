using System;
using WindowsFormsApp2.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Logger;
using MetroFramework;
using MetroFramework.Forms;

namespace WindowsFormsApp2
{
    public partial class AuthForm : MetroForm
    {
        UserSessionData user;
        IInstaApi api;

        public AuthForm()
        {
            InitializeComponent();
            metroTextBoxLogin.Text = "noBag";
            metroTextBoxPassword.Text = "noBag";
            metroTextBoxLogin.Clear();
            metroTextBoxPassword.Clear();
            metroTextBoxLogin.Text = Settings.Default["Login"].ToString();
            metroTextBoxPassword.Text = Settings.Default["Password"].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBoxPassword_Click(object sender, EventArgs e)
        {

        }

        private async void MetroButtonAuth_Click(object sender, EventArgs e)
        {
            try
            {
                metroButtonAuth.Enabled = false;
                user = new UserSessionData();
                user.UserName = metroTextBoxLogin.Text;
                user.Password = metroTextBoxPassword.Text;


                api = InstaApiBuilder.CreateBuilder()
                    .SetUser(user)
                    .UseLogger(new DebugLogger(LogLevel.Exceptions))
                    .SetRequestDelay(RequestDelay.FromSeconds(0, 0))
                    .Build();

                var loginRequest = await api.LoginAsync();


                if (metroCheckBox1.Checked)
                {
                    Settings.Default["Login"] = metroTextBoxLogin.Text;
                    Settings.Default["Password"] = metroTextBoxPassword.Text;
                    Settings.Default.Save();
                }

                if (loginRequest.Succeeded)
                {
                    new MainForm(api).Show();
                    Hide();
                }
                else
                {
                    metroButtonAuth.Enabled = true;
                    metroTextBoxLogin.Text = "";
                    metroTextBoxLogin.PromptText = "Ошибка авторизации";
                    metroTextBoxPassword.Text = "";
                }
            }
            catch (ArgumentException arg)
            {
                metroTextBoxLogin.Text = "";
                metroTextBoxLogin.PromptText = arg.Message;
                metroTextBoxPassword.Text = "";
                metroButtonAuth.Enabled = true;
            }
        }
    }
}
