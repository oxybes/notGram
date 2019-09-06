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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroCheckBoxMemberProxy = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBoxProxyPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxProxyLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxProxy = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBoxProxy = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonAuth = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLogin = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonMultAuth = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxMultAcc = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.ItemSize = new System.Drawing.Size(65, 34);
            this.metroTabControl1.Location = new System.Drawing.Point(-5, 52);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.ShowToolTips = true;
            this.metroTabControl1.Size = new System.Drawing.Size(281, 411);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 17;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabPage1.Controls.Add(this.metroCheckBoxMemberProxy);
            this.tabPage1.Controls.Add(this.metroTextBoxProxyPassword);
            this.tabPage1.Controls.Add(this.metroTextBoxProxyLogin);
            this.tabPage1.Controls.Add(this.metroTextBoxProxy);
            this.tabPage1.Controls.Add(this.metroCheckBoxProxy);
            this.tabPage1.Controls.Add(this.metroLabel2);
            this.tabPage1.Controls.Add(this.metroLabel1);
            this.tabPage1.Controls.Add(this.metroButtonAuth);
            this.tabPage1.Controls.Add(this.metroTextBoxPassword);
            this.tabPage1.Controls.Add(this.metroTextBoxLogin);
            this.tabPage1.Controls.Add(this.metroCheckBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(273, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "         Один          ";
            // 
            // metroCheckBoxMemberProxy
            // 
            this.metroCheckBoxMemberProxy.AutoSize = true;
            this.metroCheckBoxMemberProxy.Location = new System.Drawing.Point(26, 226);
            this.metroCheckBoxMemberProxy.Name = "metroCheckBoxMemberProxy";
            this.metroCheckBoxMemberProxy.Size = new System.Drawing.Size(127, 15);
            this.metroCheckBoxMemberProxy.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxMemberProxy.TabIndex = 25;
            this.metroCheckBoxMemberProxy.Text = "Запомнить прокси";
            this.metroCheckBoxMemberProxy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxMemberProxy.UseSelectable = true;
            // 
            // metroTextBoxProxyPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxProxyPassword.CustomButton.Image = null;
            this.metroTextBoxProxyPassword.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.metroTextBoxProxyPassword.CustomButton.Name = "";
            this.metroTextBoxProxyPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxProxyPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxProxyPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxProxyPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxProxyPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxProxyPassword.CustomButton.Visible = false;
            this.metroTextBoxProxyPassword.DisplayIcon = true;
            this.metroTextBoxProxyPassword.Icon = global::WindowsFormsApp2.Properties.Resources.iconfinder_Unlock_132679;
            this.metroTextBoxProxyPassword.Lines = new string[0];
            this.metroTextBoxProxyPassword.Location = new System.Drawing.Point(26, 197);
            this.metroTextBoxProxyPassword.MaxLength = 32767;
            this.metroTextBoxProxyPassword.Name = "metroTextBoxProxyPassword";
            this.metroTextBoxProxyPassword.PasswordChar = '\0';
            this.metroTextBoxProxyPassword.PromptText = "Password";
            this.metroTextBoxProxyPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxProxyPassword.SelectedText = "";
            this.metroTextBoxProxyPassword.SelectionLength = 0;
            this.metroTextBoxProxyPassword.SelectionStart = 0;
            this.metroTextBoxProxyPassword.ShortcutsEnabled = true;
            this.metroTextBoxProxyPassword.Size = new System.Drawing.Size(222, 23);
            this.metroTextBoxProxyPassword.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxProxyPassword.TabIndex = 24;
            this.metroTextBoxProxyPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxProxyPassword.UseCustomBackColor = true;
            this.metroTextBoxProxyPassword.UseSelectable = true;
            this.metroTextBoxProxyPassword.UseStyleColors = true;
            this.metroTextBoxProxyPassword.WaterMark = "Password";
            this.metroTextBoxProxyPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxProxyPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxProxyLogin
            // 
            // 
            // 
            // 
            this.metroTextBoxProxyLogin.CustomButton.Image = null;
            this.metroTextBoxProxyLogin.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.metroTextBoxProxyLogin.CustomButton.Name = "";
            this.metroTextBoxProxyLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxProxyLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxProxyLogin.CustomButton.TabIndex = 1;
            this.metroTextBoxProxyLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxProxyLogin.CustomButton.UseSelectable = true;
            this.metroTextBoxProxyLogin.CustomButton.Visible = false;
            this.metroTextBoxProxyLogin.DisplayIcon = true;
            this.metroTextBoxProxyLogin.Icon = global::WindowsFormsApp2.Properties.Resources.iconfinder_Person_132730;
            this.metroTextBoxProxyLogin.Lines = new string[0];
            this.metroTextBoxProxyLogin.Location = new System.Drawing.Point(26, 168);
            this.metroTextBoxProxyLogin.MaxLength = 32767;
            this.metroTextBoxProxyLogin.Name = "metroTextBoxProxyLogin";
            this.metroTextBoxProxyLogin.PasswordChar = '\0';
            this.metroTextBoxProxyLogin.PromptText = "Login";
            this.metroTextBoxProxyLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxProxyLogin.SelectedText = "";
            this.metroTextBoxProxyLogin.SelectionLength = 0;
            this.metroTextBoxProxyLogin.SelectionStart = 0;
            this.metroTextBoxProxyLogin.ShortcutsEnabled = true;
            this.metroTextBoxProxyLogin.Size = new System.Drawing.Size(222, 23);
            this.metroTextBoxProxyLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxProxyLogin.TabIndex = 23;
            this.metroTextBoxProxyLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxProxyLogin.UseCustomBackColor = true;
            this.metroTextBoxProxyLogin.UseSelectable = true;
            this.metroTextBoxProxyLogin.UseStyleColors = true;
            this.metroTextBoxProxyLogin.WaterMark = "Login";
            this.metroTextBoxProxyLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxProxyLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxProxy
            // 
            // 
            // 
            // 
            this.metroTextBoxProxy.CustomButton.Image = null;
            this.metroTextBoxProxy.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.metroTextBoxProxy.CustomButton.Name = "";
            this.metroTextBoxProxy.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxProxy.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxProxy.CustomButton.TabIndex = 1;
            this.metroTextBoxProxy.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxProxy.CustomButton.UseSelectable = true;
            this.metroTextBoxProxy.CustomButton.Visible = false;
            this.metroTextBoxProxy.DisplayIcon = true;
            this.metroTextBoxProxy.Icon = global::WindowsFormsApp2.Properties.Resources.connect_icon__1_;
            this.metroTextBoxProxy.Lines = new string[0];
            this.metroTextBoxProxy.Location = new System.Drawing.Point(26, 139);
            this.metroTextBoxProxy.MaxLength = 32767;
            this.metroTextBoxProxy.Name = "metroTextBoxProxy";
            this.metroTextBoxProxy.PasswordChar = '\0';
            this.metroTextBoxProxy.PromptText = "IP:PORT";
            this.metroTextBoxProxy.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxProxy.SelectedText = "";
            this.metroTextBoxProxy.SelectionLength = 0;
            this.metroTextBoxProxy.SelectionStart = 0;
            this.metroTextBoxProxy.ShortcutsEnabled = true;
            this.metroTextBoxProxy.Size = new System.Drawing.Size(222, 23);
            this.metroTextBoxProxy.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxProxy.TabIndex = 22;
            this.metroTextBoxProxy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxProxy.UseCustomBackColor = true;
            this.metroTextBoxProxy.UseSelectable = true;
            this.metroTextBoxProxy.UseStyleColors = true;
            this.metroTextBoxProxy.WaterMark = "IP:PORT";
            this.metroTextBoxProxy.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxProxy.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBoxProxy
            // 
            this.metroCheckBoxProxy.AutoSize = true;
            this.metroCheckBoxProxy.Location = new System.Drawing.Point(26, 100);
            this.metroCheckBoxProxy.Name = "metroCheckBoxProxy";
            this.metroCheckBoxProxy.Size = new System.Drawing.Size(143, 15);
            this.metroCheckBoxProxy.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxProxy.TabIndex = 21;
            this.metroCheckBoxProxy.Text = "Использовать прокси";
            this.metroCheckBoxProxy.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxProxy.UseCustomBackColor = true;
            this.metroCheckBoxProxy.UseSelectable = true;
            this.metroCheckBoxProxy.Click += new System.EventHandler(this.MetroCheckBoxProxy_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 238);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(225, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "____________________________________";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(225, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "____________________________________";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroButtonAuth
            // 
            this.metroButtonAuth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButtonAuth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroButtonAuth.Location = new System.Drawing.Point(24, 286);
            this.metroButtonAuth.Name = "metroButtonAuth";
            this.metroButtonAuth.Size = new System.Drawing.Size(224, 29);
            this.metroButtonAuth.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonAuth.TabIndex = 18;
            this.metroButtonAuth.Text = "Авторизироваться";
            this.metroButtonAuth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonAuth.UseCustomBackColor = true;
            this.metroButtonAuth.UseSelectable = true;
            this.metroButtonAuth.UseStyleColors = true;
            this.metroButtonAuth.Click += new System.EventHandler(this.MetroButtonAuth_Click_1);
            // 
            // metroTextBoxPassword
            // 
            // 
            // 
            // 
            this.metroTextBoxPassword.CustomButton.Image = null;
            this.metroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.metroTextBoxPassword.CustomButton.Name = "";
            this.metroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxPassword.CustomButton.TabIndex = 1;
            this.metroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxPassword.CustomButton.UseSelectable = true;
            this.metroTextBoxPassword.CustomButton.Visible = false;
            this.metroTextBoxPassword.DisplayIcon = true;
            this.metroTextBoxPassword.Icon = global::WindowsFormsApp2.Properties.Resources.iconfinder_Unlock_132679;
            this.metroTextBoxPassword.Lines = new string[0];
            this.metroTextBoxPassword.Location = new System.Drawing.Point(26, 48);
            this.metroTextBoxPassword.MaxLength = 32767;
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '●';
            this.metroTextBoxPassword.PromptText = "Password";
            this.metroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPassword.SelectedText = "";
            this.metroTextBoxPassword.SelectionLength = 0;
            this.metroTextBoxPassword.SelectionStart = 0;
            this.metroTextBoxPassword.ShortcutsEnabled = true;
            this.metroTextBoxPassword.Size = new System.Drawing.Size(222, 23);
            this.metroTextBoxPassword.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPassword.TabIndex = 17;
            this.metroTextBoxPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPassword.UseCustomBackColor = true;
            this.metroTextBoxPassword.UseSelectable = true;
            this.metroTextBoxPassword.UseStyleColors = true;
            this.metroTextBoxPassword.UseSystemPasswordChar = true;
            this.metroTextBoxPassword.WaterMark = "Password";
            this.metroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBoxLogin
            // 
            // 
            // 
            // 
            this.metroTextBoxLogin.CustomButton.Image = null;
            this.metroTextBoxLogin.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.metroTextBoxLogin.CustomButton.Name = "";
            this.metroTextBoxLogin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxLogin.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLogin.CustomButton.TabIndex = 1;
            this.metroTextBoxLogin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLogin.CustomButton.UseSelectable = true;
            this.metroTextBoxLogin.CustomButton.Visible = false;
            this.metroTextBoxLogin.DisplayIcon = true;
            this.metroTextBoxLogin.Icon = global::WindowsFormsApp2.Properties.Resources.iconfinder_Person_132730;
            this.metroTextBoxLogin.Lines = new string[0];
            this.metroTextBoxLogin.Location = new System.Drawing.Point(26, 16);
            this.metroTextBoxLogin.MaxLength = 32767;
            this.metroTextBoxLogin.Name = "metroTextBoxLogin";
            this.metroTextBoxLogin.PasswordChar = '\0';
            this.metroTextBoxLogin.PromptText = "Login";
            this.metroTextBoxLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxLogin.SelectedText = "";
            this.metroTextBoxLogin.SelectionLength = 0;
            this.metroTextBoxLogin.SelectionStart = 0;
            this.metroTextBoxLogin.ShortcutsEnabled = true;
            this.metroTextBoxLogin.Size = new System.Drawing.Size(222, 23);
            this.metroTextBoxLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLogin.TabIndex = 16;
            this.metroTextBoxLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLogin.UseCustomBackColor = true;
            this.metroTextBoxLogin.UseSelectable = true;
            this.metroTextBoxLogin.UseStyleColors = true;
            this.metroTextBoxLogin.WaterMark = "Login";
            this.metroTextBoxLogin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxLogin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(26, 265);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(84, 15);
            this.metroCheckBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBox1.TabIndex = 15;
            this.metroCheckBox1.Text = "Запомнить";
            this.metroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBox1.UseSelectable = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabPage2.Controls.Add(this.buttonMultAuth);
            this.tabPage2.Controls.Add(this.metroButton2);
            this.tabPage2.Controls.Add(this.metroButton1);
            this.tabPage2.Controls.Add(this.metroLabel3);
            this.tabPage2.Controls.Add(this.metroTextBoxMultAcc);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(273, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Несколько аккаунтов";
            // 
            // buttonMultAuth
            // 
            this.buttonMultAuth.Location = new System.Drawing.Point(3, 290);
            this.buttonMultAuth.Name = "buttonMultAuth";
            this.buttonMultAuth.Size = new System.Drawing.Size(254, 28);
            this.buttonMultAuth.Style = MetroFramework.MetroColorStyle.Orange;
            this.buttonMultAuth.TabIndex = 4;
            this.buttonMultAuth.Text = "Авторизироваться";
            this.buttonMultAuth.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonMultAuth.UseCustomBackColor = true;
            this.buttonMultAuth.UseSelectable = true;
            this.buttonMultAuth.UseStyleColors = true;
            this.buttonMultAuth.Click += new System.EventHandler(this.ButtonMultAuth_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(175, 255);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(82, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Очистить";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(3, 255);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(174, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Загрузить";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 7);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(133, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Аккаунты в формате";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxMultAcc
            // 
            // 
            // 
            // 
            this.metroTextBoxMultAcc.CustomButton.Image = null;
            this.metroTextBoxMultAcc.CustomButton.Location = new System.Drawing.Point(40, 1);
            this.metroTextBoxMultAcc.CustomButton.Name = "";
            this.metroTextBoxMultAcc.CustomButton.Size = new System.Drawing.Size(213, 213);
            this.metroTextBoxMultAcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxMultAcc.CustomButton.TabIndex = 1;
            this.metroTextBoxMultAcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxMultAcc.CustomButton.UseSelectable = true;
            this.metroTextBoxMultAcc.CustomButton.Visible = false;
            this.metroTextBoxMultAcc.Lines = new string[0];
            this.metroTextBoxMultAcc.Location = new System.Drawing.Point(3, 35);
            this.metroTextBoxMultAcc.MaxLength = 32767;
            this.metroTextBoxMultAcc.Multiline = true;
            this.metroTextBoxMultAcc.Name = "metroTextBoxMultAcc";
            this.metroTextBoxMultAcc.PasswordChar = '\0';
            this.metroTextBoxMultAcc.PromptText = "login:pass:ip:port:login:pass";
            this.metroTextBoxMultAcc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.metroTextBoxMultAcc.SelectedText = "";
            this.metroTextBoxMultAcc.SelectionLength = 0;
            this.metroTextBoxMultAcc.SelectionStart = 0;
            this.metroTextBoxMultAcc.ShortcutsEnabled = true;
            this.metroTextBoxMultAcc.Size = new System.Drawing.Size(254, 215);
            this.metroTextBoxMultAcc.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxMultAcc.TabIndex = 0;
            this.metroTextBoxMultAcc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxMultAcc.UseSelectable = true;
            this.metroTextBoxMultAcc.UseStyleColors = true;
            this.metroTextBoxMultAcc.WaterMark = "login:pass:ip:port:login:pass";
            this.metroTextBoxMultAcc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxMultAcc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(-3, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(34, 238);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(0, 0);
            this.metroTextBox1.TabIndex = 10;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 447);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Log In";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxMemberProxy;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProxyPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProxyLogin;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProxy;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxProxy;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonAuth;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLogin;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxMultAcc;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton buttonMultAuth;
    }
}

