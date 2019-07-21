namespace WindowsFormsApp2
{
    partial class SettingMassLikeForm
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
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxDelayMax = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDelayMin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPauseTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPauseCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTogglePause = new MetroFramework.Controls.MetroToggle();
            this.metroButtonOpenFileBase = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFileNameBase = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxLikeUnderPublishMax = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLikeUnderPublishMin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxLikeAtUserMax = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxLikeAtUserMin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxDeleteInBase = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxSkipFollowers = new MetroFramework.Controls.MetroCheckBox();
            this.metroButtonApply = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(137, 204);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(26, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 54;
            this.metroLabel11.Text = "До";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(78, 204);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(25, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 53;
            this.metroLabel9.Text = "От";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxDelayMax
            // 
            this.metroTextBoxDelayMax.Location = new System.Drawing.Point(126, 175);
            this.metroTextBoxDelayMax.Name = "metroTextBoxDelayMax";
            this.metroTextBoxDelayMax.PromptText = "До";
            this.metroTextBoxDelayMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMax.TabIndex = 52;
            this.metroTextBoxDelayMax.Text = "60";
            this.metroTextBoxDelayMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMax.UseStyleColors = true;
            // 
            // metroTextBoxDelayMin
            // 
            this.metroTextBoxDelayMin.Location = new System.Drawing.Point(72, 175);
            this.metroTextBoxDelayMin.Name = "metroTextBoxDelayMin";
            this.metroTextBoxDelayMin.PromptText = "От";
            this.metroTextBoxDelayMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMin.TabIndex = 51;
            this.metroTextBoxDelayMin.Text = "30";
            this.metroTextBoxDelayMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMin.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(46, 153);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 50;
            this.metroLabel5.Text = "Задежка в секундах";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseTime
            // 
            this.metroTextBoxPauseTime.Location = new System.Drawing.Point(94, 297);
            this.metroTextBoxPauseTime.Name = "metroTextBoxPauseTime";
            this.metroTextBoxPauseTime.PromptText = "Минут";
            this.metroTextBoxPauseTime.Size = new System.Drawing.Size(79, 23);
            this.metroTextBoxPauseTime.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseTime.TabIndex = 49;
            this.metroTextBoxPauseTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseTime.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(63, 297);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(25, 19);
            this.metroLabel4.TabIndex = 48;
            this.metroLabel4.Text = "На";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseCount
            // 
            this.metroTextBoxPauseCount.Location = new System.Drawing.Point(94, 268);
            this.metroTextBoxPauseCount.Name = "metroTextBoxPauseCount";
            this.metroTextBoxPauseCount.PromptText = "Подписок";
            this.metroTextBoxPauseCount.Size = new System.Drawing.Size(80, 23);
            this.metroTextBoxPauseCount.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseCount.TabIndex = 47;
            this.metroTextBoxPauseCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseCount.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 268);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 46;
            this.metroLabel3.Text = "После";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(46, 239);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(44, 19);
            this.metroLabel.TabIndex = 45;
            this.metroLabel.Text = "Пауза";
            this.metroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTogglePause
            // 
            this.metroTogglePause.AutoSize = true;
            this.metroTogglePause.Location = new System.Drawing.Point(94, 239);
            this.metroTogglePause.Name = "metroTogglePause";
            this.metroTogglePause.Size = new System.Drawing.Size(80, 17);
            this.metroTogglePause.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTogglePause.TabIndex = 44;
            this.metroTogglePause.Text = "Off";
            this.metroTogglePause.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTogglePause.UseVisualStyleBackColor = true;
            // 
            // metroButtonOpenFileBase
            // 
            this.metroButtonOpenFileBase.Location = new System.Drawing.Point(23, 110);
            this.metroButtonOpenFileBase.Name = "metroButtonOpenFileBase";
            this.metroButtonOpenFileBase.Size = new System.Drawing.Size(150, 23);
            this.metroButtonOpenFileBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonOpenFileBase.TabIndex = 43;
            this.metroButtonOpenFileBase.Text = "Открыть файл";
            this.metroButtonOpenFileBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOpenFileBase.Click += new System.EventHandler(this.MetroButtonOpenFileBase_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Путь до файла с базой";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxFileNameBase
            // 
            this.metroTextBoxFileNameBase.Location = new System.Drawing.Point(23, 81);
            this.metroTextBoxFileNameBase.Name = "metroTextBoxFileNameBase";
            this.metroTextBoxFileNameBase.PromptText = "ID";
            this.metroTextBoxFileNameBase.Size = new System.Drawing.Size(150, 23);
            this.metroTextBoxFileNameBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxFileNameBase.TabIndex = 41;
            this.metroTextBoxFileNameBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxFileNameBase.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(271, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(26, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 59;
            this.metroLabel2.Text = "До";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(212, 110);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(25, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 58;
            this.metroLabel6.Text = "От";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxLikeUnderPublishMax
            // 
            this.metroTextBoxLikeUnderPublishMax.Location = new System.Drawing.Point(260, 81);
            this.metroTextBoxLikeUnderPublishMax.Name = "metroTextBoxLikeUnderPublishMax";
            this.metroTextBoxLikeUnderPublishMax.PromptText = "До";
            this.metroTextBoxLikeUnderPublishMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxLikeUnderPublishMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLikeUnderPublishMax.TabIndex = 57;
            this.metroTextBoxLikeUnderPublishMax.Text = "60";
            this.metroTextBoxLikeUnderPublishMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLikeUnderPublishMax.UseStyleColors = true;
            // 
            // metroTextBoxLikeUnderPublishMin
            // 
            this.metroTextBoxLikeUnderPublishMin.Location = new System.Drawing.Point(206, 81);
            this.metroTextBoxLikeUnderPublishMin.Name = "metroTextBoxLikeUnderPublishMin";
            this.metroTextBoxLikeUnderPublishMin.PromptText = "От";
            this.metroTextBoxLikeUnderPublishMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxLikeUnderPublishMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLikeUnderPublishMin.TabIndex = 56;
            this.metroTextBoxLikeUnderPublishMin.Text = "30";
            this.metroTextBoxLikeUnderPublishMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLikeUnderPublishMin.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(200, 60);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(166, 19);
            this.metroLabel7.TabIndex = 55;
            this.metroLabel7.Text = "Лайков под публикацией";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(271, 204);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(26, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 64;
            this.metroLabel8.Text = "До";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(212, 204);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(25, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel10.TabIndex = 63;
            this.metroLabel10.Text = "От";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxLikeAtUserMax
            // 
            this.metroTextBoxLikeAtUserMax.Location = new System.Drawing.Point(260, 175);
            this.metroTextBoxLikeAtUserMax.Name = "metroTextBoxLikeAtUserMax";
            this.metroTextBoxLikeAtUserMax.PromptText = "До";
            this.metroTextBoxLikeAtUserMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxLikeAtUserMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLikeAtUserMax.TabIndex = 62;
            this.metroTextBoxLikeAtUserMax.Text = "2";
            this.metroTextBoxLikeAtUserMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLikeAtUserMax.UseStyleColors = true;
            // 
            // metroTextBoxLikeAtUserMin
            // 
            this.metroTextBoxLikeAtUserMin.Location = new System.Drawing.Point(206, 175);
            this.metroTextBoxLikeAtUserMin.Name = "metroTextBoxLikeAtUserMin";
            this.metroTextBoxLikeAtUserMin.PromptText = "От";
            this.metroTextBoxLikeAtUserMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxLikeAtUserMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLikeAtUserMin.TabIndex = 61;
            this.metroTextBoxLikeAtUserMin.Text = "1";
            this.metroTextBoxLikeAtUserMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLikeAtUserMin.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(200, 153);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(160, 19);
            this.metroLabel12.TabIndex = 60;
            this.metroLabel12.Text = "Лайков на пользователя";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBoxDeleteInBase
            // 
            this.metroCheckBoxDeleteInBase.AutoSize = true;
            this.metroCheckBoxDeleteInBase.Location = new System.Drawing.Point(202, 260);
            this.metroCheckBoxDeleteInBase.Name = "metroCheckBoxDeleteInBase";
            this.metroCheckBoxDeleteInBase.Size = new System.Drawing.Size(111, 15);
            this.metroCheckBoxDeleteInBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxDeleteInBase.TabIndex = 65;
            this.metroCheckBoxDeleteInBase.Text = "Удалять из базы";
            this.metroCheckBoxDeleteInBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxDeleteInBase.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxSkipFollowers
            // 
            this.metroCheckBoxSkipFollowers.AutoSize = true;
            this.metroCheckBoxSkipFollowers.Location = new System.Drawing.Point(202, 239);
            this.metroCheckBoxSkipFollowers.Name = "metroCheckBoxSkipFollowers";
            this.metroCheckBoxSkipFollowers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroCheckBoxSkipFollowers.Size = new System.Drawing.Size(164, 15);
            this.metroCheckBoxSkipFollowers.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxSkipFollowers.TabIndex = 66;
            this.metroCheckBoxSkipFollowers.Text = "Пропускать подписчиков";
            this.metroCheckBoxSkipFollowers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxSkipFollowers.UseVisualStyleBackColor = true;
            // 
            // metroButtonApply
            // 
            this.metroButtonApply.Location = new System.Drawing.Point(200, 297);
            this.metroButtonApply.Name = "metroButtonApply";
            this.metroButtonApply.Size = new System.Drawing.Size(98, 23);
            this.metroButtonApply.TabIndex = 68;
            this.metroButtonApply.Text = "Применить";
            this.metroButtonApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonApply.Click += new System.EventHandler(this.MetroButtonApply_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Location = new System.Drawing.Point(304, 297);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(62, 23);
            this.metroButtonCancel.TabIndex = 67;
            this.metroButtonCancel.Text = "Отмена";
            this.metroButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonCancel.Click += new System.EventHandler(this.MetroButtonCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingMassLikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 339);
            this.Controls.Add(this.metroButtonApply);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroCheckBoxSkipFollowers);
            this.Controls.Add(this.metroCheckBoxDeleteInBase);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroTextBoxLikeAtUserMax);
            this.Controls.Add(this.metroTextBoxLikeAtUserMin);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroTextBoxLikeUnderPublishMax);
            this.Controls.Add(this.metroTextBoxLikeUnderPublishMin);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroTextBoxDelayMax);
            this.Controls.Add(this.metroTextBoxDelayMin);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroTextBoxPauseTime);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBoxPauseCount);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel);
            this.Controls.Add(this.metroTogglePause);
            this.Controls.Add(this.metroButtonOpenFileBase);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxFileNameBase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingMassLikeForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Настройки лайков";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SettingMassLikeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayMax;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayMin;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPauseTime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPauseCount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroToggle metroTogglePause;
        private MetroFramework.Controls.MetroButton metroButtonOpenFileBase;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFileNameBase;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLikeUnderPublishMax;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLikeUnderPublishMin;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLikeAtUserMax;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLikeAtUserMin;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxDeleteInBase;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSkipFollowers;
        private MetroFramework.Controls.MetroButton metroButtonApply;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}