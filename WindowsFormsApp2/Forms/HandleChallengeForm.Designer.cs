namespace WindowsFormsApp2.Forms
{
    partial class HandleChallengeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HandleChallengeForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.radioPhone = new MetroFramework.Controls.MetroRadioButton();
            this.radioMail = new MetroFramework.Controls.MetroRadioButton();
            this.b_SendCode = new MetroFramework.Controls.MetroButton();
            this.tBox_Code = new MetroFramework.Controls.MetroTextBox();
            this.b_Auth = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(289, 57);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "You need to verify that this is your account.\r\nPlease choose an method to verify " +
    "your account\r\n";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // radioPhone
            // 
            this.radioPhone.AutoSize = true;
            this.radioPhone.Location = new System.Drawing.Point(23, 90);
            this.radioPhone.Name = "radioPhone";
            this.radioPhone.Size = new System.Drawing.Size(16, 0);
            this.radioPhone.Style = MetroFramework.MetroColorStyle.Orange;
            this.radioPhone.TabIndex = 1;
            this.radioPhone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioPhone.UseSelectable = true;
            // 
            // radioMail
            // 
            this.radioMail.AutoSize = true;
            this.radioMail.Location = new System.Drawing.Point(23, 112);
            this.radioMail.Name = "radioMail";
            this.radioMail.Size = new System.Drawing.Size(16, 0);
            this.radioMail.Style = MetroFramework.MetroColorStyle.Orange;
            this.radioMail.TabIndex = 2;
            this.radioMail.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioMail.UseSelectable = true;
            // 
            // b_SendCode
            // 
            this.b_SendCode.Location = new System.Drawing.Point(227, 141);
            this.b_SendCode.Name = "b_SendCode";
            this.b_SendCode.Size = new System.Drawing.Size(85, 23);
            this.b_SendCode.Style = MetroFramework.MetroColorStyle.Orange;
            this.b_SendCode.TabIndex = 3;
            this.b_SendCode.Text = "Send code";
            this.b_SendCode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_SendCode.UseCustomBackColor = true;
            this.b_SendCode.UseSelectable = true;
            this.b_SendCode.Click += new System.EventHandler(this.B_SendCode_Click);
            // 
            // tBox_Code
            // 
            // 
            // 
            // 
            this.tBox_Code.CustomButton.Image = null;
            this.tBox_Code.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.tBox_Code.CustomButton.Name = "";
            this.tBox_Code.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tBox_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_Code.CustomButton.TabIndex = 1;
            this.tBox_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_Code.CustomButton.UseSelectable = true;
            this.tBox_Code.CustomButton.Visible = false;
            this.tBox_Code.Lines = new string[0];
            this.tBox_Code.Location = new System.Drawing.Point(23, 185);
            this.tBox_Code.MaxLength = 32767;
            this.tBox_Code.Name = "tBox_Code";
            this.tBox_Code.PasswordChar = '\0';
            this.tBox_Code.PromptText = "Write code";
            this.tBox_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_Code.SelectedText = "";
            this.tBox_Code.SelectionLength = 0;
            this.tBox_Code.SelectionStart = 0;
            this.tBox_Code.ShortcutsEnabled = true;
            this.tBox_Code.Size = new System.Drawing.Size(198, 23);
            this.tBox_Code.Style = MetroFramework.MetroColorStyle.Orange;
            this.tBox_Code.TabIndex = 4;
            this.tBox_Code.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tBox_Code.UseSelectable = true;
            this.tBox_Code.UseStyleColors = true;
            this.tBox_Code.WaterMark = "Write code";
            this.tBox_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // b_Auth
            // 
            this.b_Auth.Location = new System.Drawing.Point(227, 185);
            this.b_Auth.Name = "b_Auth";
            this.b_Auth.Size = new System.Drawing.Size(85, 23);
            this.b_Auth.Style = MetroFramework.MetroColorStyle.Orange;
            this.b_Auth.TabIndex = 5;
            this.b_Auth.Text = "Auth";
            this.b_Auth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_Auth.UseCustomBackColor = true;
            this.b_Auth.UseSelectable = true;
            this.b_Auth.Click += new System.EventHandler(this.B_Auth_Click);
            // 
            // HandleChallengeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 233);
            this.Controls.Add(this.b_Auth);
            this.Controls.Add(this.tBox_Code);
            this.Controls.Add(this.b_SendCode);
            this.Controls.Add(this.radioMail);
            this.Controls.Add(this.radioPhone);
            this.Controls.Add(this.metroLabel1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HandleChallengeForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "HandleChallengeForm";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.HandleChallengeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton radioPhone;
        private MetroFramework.Controls.MetroRadioButton radioMail;
        private MetroFramework.Controls.MetroButton b_SendCode;
        private MetroFramework.Controls.MetroTextBox tBox_Code;
        private MetroFramework.Controls.MetroButton b_Auth;
    }
}