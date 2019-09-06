using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstaSharper.API;
using MetroFramework.Forms;

namespace WindowsFormsApp2.Forms
{
    public partial class TwoFactorForm : MetroForm
    {
        private IInstaApi api;
        public TwoFactorForm(IInstaApi api)
        {
            InitializeComponent();
            this.api = api;
        }

        private void TwoFactorForm_Load(object sender, EventArgs e)
        {

        }

        private async void MetroButton1_Click(object sender, EventArgs e)
        {
            if (api == null)
                return;
            if (string.IsNullOrEmpty(tBox_Code.Text))
            {
                MessageBox.Show("Please type your two factor code and then press Auth button.", "ERR");
                return;
            }
            //try
            //{
            // send two factor code
            var twoFactorLogin = await api.TwoFactorLoginAsync(tBox_Code.Text);
            if (twoFactorLogin.Succeeded)
            {
                var result = await api.LoginAsync();
                if(result.Succeeded)
                {
                    Close();
                }
            }
            else
            {
                MessageBox.Show(twoFactorLogin.Info.Message, "ERR");
            }
            //}
            //catch (Exception ex) { MessageBox.Show("TwoFactorVerifyCodeButton_Click " + ex.Message); }
            //Close();
        }

    }
}
