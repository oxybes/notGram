namespace WindowsFormsApp2
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTextBoxLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAuth = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroTextBoxLogin
            // 
            this.metroTextBoxLogin.Location = new System.Drawing.Point(23, 63);
            this.metroTextBoxLogin.Name = "metroTextBoxLogin";
            this.metroTextBoxLogin.PromptText = "Login";
            this.metroTextBoxLogin.Size = new System.Drawing.Size(224, 23);
            this.metroTextBoxLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLogin.TabIndex = 0;
            this.metroTextBoxLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLogin.UseStyleColors = true;
            this.metroTextBoxLogin.Click += new System.EventHandler(this.MetroTextBox1_Click);
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.Location = new System.Drawing.Point(23, 92);
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '*';
            this.metroTextBoxPassword.PromptText = "Password";
            this.metroTextBoxPassword.Size = new System.Drawing.Size(224, 23);
            this.metroTextBoxPassword.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPassword.TabIndex = 1;
            this.metroTextBoxPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPassword.UseStyleColors = true;
            this.metroTextBoxPassword.Click += new System.EventHandler(this.MetroTextBoxPassword_Click);
            // 
            // metroButtonAuth
            // 
            this.metroButtonAuth.Location = new System.Drawing.Point(23, 158);
            this.metroButtonAuth.Name = "metroButtonAuth";
            this.metroButtonAuth.Size = new System.Drawing.Size(224, 32);
            this.metroButtonAuth.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonAuth.TabIndex = 2;
            this.metroButtonAuth.Text = "Авторизироваться";
            this.metroButtonAuth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonAuth.Click += new System.EventHandler(this.MetroButtonAuth_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(23, 121);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(84, 15);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBox1.TabIndex = 3;
            this.metroCheckBox1.Text = "Запомнить";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 213);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroButtonAuth);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroTextBoxLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Log In";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxLogin;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroButton metroButtonAuth;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}

