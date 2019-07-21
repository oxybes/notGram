namespace WindowsFormsApp2
{
    partial class SettingSubscribeForm
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
            this.components = new System.ComponentModel.Container();
            this.metroTextBoxFileNameBase = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonOpenFileBase = new MetroFramework.Controls.MetroButton();
            this.metroTogglePause = new MetroFramework.Controls.MetroToggle();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPauseCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPauseTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTextBoxDelayMin = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDelayMax = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroToggleLike = new MetroFramework.Controls.MetroToggle();
            this.metroTextBoxCountLikeMax = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCountLikeMin = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDelayLikeMax = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDelayLikeMin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxSkipFollowers = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxSendPrivate = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxDeleteInBase = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBoxLimit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroButtonApply = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTextBoxFileNameBase
            // 
            this.metroTextBoxFileNameBase.Location = new System.Drawing.Point(21, 90);
            this.metroTextBoxFileNameBase.Name = "metroTextBoxFileNameBase";
            this.metroTextBoxFileNameBase.PromptText = "ID";
            this.metroTextBoxFileNameBase.Size = new System.Drawing.Size(150, 23);
            this.metroTextBoxFileNameBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxFileNameBase.TabIndex = 0;
            this.metroTextBoxFileNameBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxFileNameBase.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 68);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Путь до файла с базой";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonOpenFileBase
            // 
            this.metroButtonOpenFileBase.Location = new System.Drawing.Point(21, 119);
            this.metroButtonOpenFileBase.Name = "metroButtonOpenFileBase";
            this.metroButtonOpenFileBase.Size = new System.Drawing.Size(150, 23);
            this.metroButtonOpenFileBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonOpenFileBase.TabIndex = 2;
            this.metroButtonOpenFileBase.Text = "Открыть файл";
            this.metroButtonOpenFileBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOpenFileBase.Click += new System.EventHandler(this.MetroButtonOpenFileBase_Click);
            // 
            // metroTogglePause
            // 
            this.metroTogglePause.AutoSize = true;
            this.metroTogglePause.Location = new System.Drawing.Point(91, 158);
            this.metroTogglePause.Name = "metroTogglePause";
            this.metroTogglePause.Size = new System.Drawing.Size(80, 17);
            this.metroTogglePause.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTogglePause.TabIndex = 3;
            this.metroTogglePause.Text = "Off";
            this.metroTogglePause.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTogglePause.UseVisualStyleBackColor = true;
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(43, 158);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(44, 19);
            this.metroLabel.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel.TabIndex = 4;
            this.metroLabel.Text = "Пауза";
            this.metroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(40, 187);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "После";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseCount
            // 
            this.metroTextBoxPauseCount.Location = new System.Drawing.Point(91, 187);
            this.metroTextBoxPauseCount.Name = "metroTextBoxPauseCount";
            this.metroTextBoxPauseCount.PromptText = "Подписок";
            this.metroTextBoxPauseCount.Size = new System.Drawing.Size(80, 23);
            this.metroTextBoxPauseCount.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseCount.TabIndex = 6;
            this.metroTextBoxPauseCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseCount.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(60, 216);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(25, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "На";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseTime
            // 
            this.metroTextBoxPauseTime.Location = new System.Drawing.Point(91, 216);
            this.metroTextBoxPauseTime.Name = "metroTextBoxPauseTime";
            this.metroTextBoxPauseTime.PromptText = "Минут";
            this.metroTextBoxPauseTime.Size = new System.Drawing.Size(79, 23);
            this.metroTextBoxPauseTime.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseTime.TabIndex = 8;
            this.metroTextBoxPauseTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseTime.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(242, 68);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Задежка в секундах";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroTextBoxDelayMin
            // 
            this.metroTextBoxDelayMin.Location = new System.Drawing.Point(268, 90);
            this.metroTextBoxDelayMin.Name = "metroTextBoxDelayMin";
            this.metroTextBoxDelayMin.PromptText = "От";
            this.metroTextBoxDelayMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMin.TabIndex = 11;
            this.metroTextBoxDelayMin.Text = "30";
            this.metroTextBoxDelayMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMin.UseStyleColors = true;
            // 
            // metroTextBoxDelayMax
            // 
            this.metroTextBoxDelayMax.Location = new System.Drawing.Point(322, 90);
            this.metroTextBoxDelayMax.Name = "metroTextBoxDelayMax";
            this.metroTextBoxDelayMax.PromptText = "До";
            this.metroTextBoxDelayMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMax.TabIndex = 13;
            this.metroTextBoxDelayMax.Text = "60";
            this.metroTextBoxDelayMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMax.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(188, 158);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Ставить лайки";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroToggleLike
            // 
            this.metroToggleLike.AutoSize = true;
            this.metroToggleLike.Location = new System.Drawing.Point(290, 160);
            this.metroToggleLike.Name = "metroToggleLike";
            this.metroToggleLike.Size = new System.Drawing.Size(80, 17);
            this.metroToggleLike.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroToggleLike.TabIndex = 14;
            this.metroToggleLike.Text = "Off";
            this.metroToggleLike.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroToggleLike.UseVisualStyleBackColor = true;
            // 
            // metroTextBoxCountLikeMax
            // 
            this.metroTextBoxCountLikeMax.Location = new System.Drawing.Point(322, 183);
            this.metroTextBoxCountLikeMax.Name = "metroTextBoxCountLikeMax";
            this.metroTextBoxCountLikeMax.PromptText = "До";
            this.metroTextBoxCountLikeMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxCountLikeMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxCountLikeMax.TabIndex = 19;
            this.metroTextBoxCountLikeMax.Text = "2";
            this.metroTextBoxCountLikeMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxCountLikeMax.UseStyleColors = true;
            // 
            // metroTextBoxCountLikeMin
            // 
            this.metroTextBoxCountLikeMin.Location = new System.Drawing.Point(268, 183);
            this.metroTextBoxCountLikeMin.Name = "metroTextBoxCountLikeMin";
            this.metroTextBoxCountLikeMin.PromptText = "От";
            this.metroTextBoxCountLikeMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxCountLikeMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxCountLikeMin.TabIndex = 17;
            this.metroTextBoxCountLikeMin.Text = "1";
            this.metroTextBoxCountLikeMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxCountLikeMin.UseStyleColors = true;
            // 
            // metroTextBoxDelayLikeMax
            // 
            this.metroTextBoxDelayLikeMax.Location = new System.Drawing.Point(123, 278);
            this.metroTextBoxDelayLikeMax.Name = "metroTextBoxDelayLikeMax";
            this.metroTextBoxDelayLikeMax.PromptText = "До";
            this.metroTextBoxDelayLikeMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayLikeMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayLikeMax.TabIndex = 24;
            this.metroTextBoxDelayLikeMax.Text = "60";
            this.metroTextBoxDelayLikeMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayLikeMax.UseStyleColors = true;
            // 
            // metroTextBoxDelayLikeMin
            // 
            this.metroTextBoxDelayLikeMin.Location = new System.Drawing.Point(61, 278);
            this.metroTextBoxDelayLikeMin.Name = "metroTextBoxDelayLikeMin";
            this.metroTextBoxDelayLikeMin.PromptText = "От";
            this.metroTextBoxDelayLikeMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayLikeMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayLikeMin.TabIndex = 22;
            this.metroTextBoxDelayLikeMin.Text = "30";
            this.metroTextBoxDelayLikeMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayLikeMin.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 256);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(158, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Задежка между лайками";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBoxSkipFollowers
            // 
            this.metroCheckBoxSkipFollowers.AutoSize = true;
            this.metroCheckBoxSkipFollowers.Location = new System.Drawing.Point(24, 314);
            this.metroCheckBoxSkipFollowers.Name = "metroCheckBoxSkipFollowers";
            this.metroCheckBoxSkipFollowers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroCheckBoxSkipFollowers.Size = new System.Drawing.Size(164, 15);
            this.metroCheckBoxSkipFollowers.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxSkipFollowers.TabIndex = 25;
            this.metroCheckBoxSkipFollowers.Text = "Пропускать подписчиков";
            this.metroCheckBoxSkipFollowers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxSkipFollowers.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxSendPrivate
            // 
            this.metroCheckBoxSendPrivate.AutoSize = true;
            this.metroCheckBoxSendPrivate.Location = new System.Drawing.Point(24, 335);
            this.metroCheckBoxSendPrivate.Name = "metroCheckBoxSendPrivate";
            this.metroCheckBoxSendPrivate.Size = new System.Drawing.Size(187, 15);
            this.metroCheckBoxSendPrivate.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxSendPrivate.TabIndex = 26;
            this.metroCheckBoxSendPrivate.Text = "Отправляь заявки приватным";
            this.metroCheckBoxSendPrivate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxSendPrivate.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxDeleteInBase
            // 
            this.metroCheckBoxDeleteInBase.AutoSize = true;
            this.metroCheckBoxDeleteInBase.Location = new System.Drawing.Point(24, 356);
            this.metroCheckBoxDeleteInBase.Name = "metroCheckBoxDeleteInBase";
            this.metroCheckBoxDeleteInBase.Size = new System.Drawing.Size(111, 15);
            this.metroCheckBoxDeleteInBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxDeleteInBase.TabIndex = 27;
            this.metroCheckBoxDeleteInBase.Text = "Удалять из базы";
            this.metroCheckBoxDeleteInBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxDeleteInBase.UseVisualStyleBackColor = true;
            // 
            // metroTextBoxLimit
            // 
            this.metroTextBoxLimit.Location = new System.Drawing.Point(305, 278);
            this.metroTextBoxLimit.Name = "metroTextBoxLimit";
            this.metroTextBoxLimit.PromptText = "Подписок";
            this.metroTextBoxLimit.Size = new System.Drawing.Size(65, 23);
            this.metroTextBoxLimit.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLimit.TabIndex = 29;
            this.metroTextBoxLimit.Text = "1000";
            this.metroTextBoxLimit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLimit.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(188, 278);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(111, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 28;
            this.metroLabel7.Text = "Лимит подписок";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Location = new System.Drawing.Point(323, 345);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(62, 23);
            this.metroButtonCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonCancel.TabIndex = 30;
            this.metroButtonCancel.Text = "Отмена";
            this.metroButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonCancel.Click += new System.EventHandler(this.MetroButtonCancel_Click);
            // 
            // metroButtonApply
            // 
            this.metroButtonApply.Location = new System.Drawing.Point(221, 345);
            this.metroButtonApply.Name = "metroButtonApply";
            this.metroButtonApply.Size = new System.Drawing.Size(98, 23);
            this.metroButtonApply.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonApply.TabIndex = 31;
            this.metroButtonApply.Text = "Применить";
            this.metroButtonApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonApply.Click += new System.EventHandler(this.MetroButtonApply_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(274, 209);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(25, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 32;
            this.metroLabel8.Text = "От";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(274, 119);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(25, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 33;
            this.metroLabel9.Text = "От";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(333, 209);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(26, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel10.TabIndex = 34;
            this.metroLabel10.Text = "До";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(333, 119);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(26, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 35;
            this.metroLabel11.Text = "До";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingSubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 382);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroButtonApply);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroTextBoxLimit);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroCheckBoxDeleteInBase);
            this.Controls.Add(this.metroCheckBoxSendPrivate);
            this.Controls.Add(this.metroCheckBoxSkipFollowers);
            this.Controls.Add(this.metroTextBoxDelayLikeMax);
            this.Controls.Add(this.metroTextBoxDelayLikeMin);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroTextBoxCountLikeMax);
            this.Controls.Add(this.metroTextBoxCountLikeMin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroToggleLike);
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
            this.Name = "SettingSubscribeForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Настройки подписки";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SettingSubscribe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxFileNameBase;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButtonOpenFileBase;
        private MetroFramework.Controls.MetroToggle metroTogglePause;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPauseCount;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPauseTime;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayMin;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayMax;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle metroToggleLike;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCountLikeMax;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCountLikeMin;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayLikeMax;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayLikeMin;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSkipFollowers;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSendPrivate;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxDeleteInBase;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLimit;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroButton metroButtonApply;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}