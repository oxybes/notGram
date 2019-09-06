namespace WindowsFormsApp2
{
    partial class License
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(License));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.tBox_Id = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxKey = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(25, 121);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(466, 24);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Активировать";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // tBox_Id
            // 
            // 
            // 
            // 
            this.tBox_Id.CustomButton.Image = null;
            this.tBox_Id.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.tBox_Id.CustomButton.Name = "";
            this.tBox_Id.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tBox_Id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_Id.CustomButton.TabIndex = 1;
            this.tBox_Id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_Id.CustomButton.UseSelectable = true;
            this.tBox_Id.CustomButton.Visible = false;
            this.tBox_Id.Lines = new string[0];
            this.tBox_Id.Location = new System.Drawing.Point(25, 63);
            this.tBox_Id.MaxLength = 32767;
            this.tBox_Id.Name = "tBox_Id";
            this.tBox_Id.PasswordChar = '\0';
            this.tBox_Id.ReadOnly = true;
            this.tBox_Id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_Id.SelectedText = "";
            this.tBox_Id.SelectionLength = 0;
            this.tBox_Id.SelectionStart = 0;
            this.tBox_Id.ShortcutsEnabled = true;
            this.tBox_Id.Size = new System.Drawing.Size(466, 23);
            this.tBox_Id.Style = MetroFramework.MetroColorStyle.Orange;
            this.tBox_Id.TabIndex = 2;
            this.tBox_Id.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tBox_Id.UseCustomBackColor = true;
            this.tBox_Id.UseSelectable = true;
            this.tBox_Id.UseStyleColors = true;
            this.tBox_Id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_Id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Ваш ID";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxKey
            // 
            // 
            // 
            // 
            this.metroTextBoxKey.CustomButton.Image = null;
            this.metroTextBoxKey.CustomButton.Location = new System.Drawing.Point(444, 1);
            this.metroTextBoxKey.CustomButton.Name = "";
            this.metroTextBoxKey.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxKey.CustomButton.TabIndex = 1;
            this.metroTextBoxKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxKey.CustomButton.UseSelectable = true;
            this.metroTextBoxKey.CustomButton.Visible = false;
            this.metroTextBoxKey.IconRight = true;
            this.metroTextBoxKey.Lines = new string[0];
            this.metroTextBoxKey.Location = new System.Drawing.Point(25, 92);
            this.metroTextBoxKey.MaxLength = 32767;
            this.metroTextBoxKey.Name = "metroTextBoxKey";
            this.metroTextBoxKey.PasswordChar = '\0';
            this.metroTextBoxKey.PromptText = "Введите код активации сюда";
            this.metroTextBoxKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxKey.SelectedText = "";
            this.metroTextBoxKey.SelectionLength = 0;
            this.metroTextBoxKey.SelectionStart = 0;
            this.metroTextBoxKey.ShortcutsEnabled = true;
            this.metroTextBoxKey.Size = new System.Drawing.Size(466, 23);
            this.metroTextBoxKey.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxKey.TabIndex = 0;
            this.metroTextBoxKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxKey.UseCustomBackColor = true;
            this.metroTextBoxKey.UseSelectable = true;
            this.metroTextBoxKey.UseStyleColors = true;
            this.metroTextBoxKey.WaterMark = "Введите код активации сюда";
            this.metroTextBoxKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 174);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tBox_Id);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTextBoxKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "License";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "License";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxKey;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox tBox_Id;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}