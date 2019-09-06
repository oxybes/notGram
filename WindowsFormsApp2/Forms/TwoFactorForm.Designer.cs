namespace WindowsFormsApp2.Forms
{
    partial class TwoFactorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoFactorForm));
            this.tBox_Code = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // tBox_Code
            // 
            // 
            // 
            // 
            this.tBox_Code.CustomButton.Image = null;
            this.tBox_Code.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.tBox_Code.CustomButton.Name = "";
            this.tBox_Code.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tBox_Code.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_Code.CustomButton.TabIndex = 1;
            this.tBox_Code.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_Code.CustomButton.UseSelectable = true;
            this.tBox_Code.CustomButton.Visible = false;
            this.tBox_Code.Lines = new string[0];
            this.tBox_Code.Location = new System.Drawing.Point(45, 63);
            this.tBox_Code.MaxLength = 32767;
            this.tBox_Code.Name = "tBox_Code";
            this.tBox_Code.PasswordChar = '\0';
            this.tBox_Code.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_Code.SelectedText = "";
            this.tBox_Code.SelectionLength = 0;
            this.tBox_Code.SelectionStart = 0;
            this.tBox_Code.ShortcutsEnabled = true;
            this.tBox_Code.Size = new System.Drawing.Size(160, 23);
            this.tBox_Code.Style = MetroFramework.MetroColorStyle.Orange;
            this.tBox_Code.TabIndex = 0;
            this.tBox_Code.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tBox_Code.UseCustomBackColor = true;
            this.tBox_Code.UseSelectable = true;
            this.tBox_Code.UseStyleColors = true;
            this.tBox_Code.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_Code.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(45, 92);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(160, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "OK";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // TwoFactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 136);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tBox_Code);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TwoFactorForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Введите код 2fa";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.TwoFactorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tBox_Code;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}