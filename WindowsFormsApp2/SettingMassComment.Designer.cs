namespace WindowsFormsApp2
{
    partial class SettingMassComment
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
            this.metroTextBoxCountPublish = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCountCommentUnderPublish = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxLimit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxDelayUserMax = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDelayUserMin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonClearCommentsFile = new MetroFramework.Controls.MetroButton();
            this.metroButtonOpenCommentsFile = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxeComments = new MetroFramework.Controls.MetroTextBox();
            this.metroCheckBoxDeleteInBase = new MetroFramework.Controls.MetroCheckBox();
            this.metroButtonApply = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(137, 211);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(26, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 68;
            this.metroLabel11.Text = "До";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(78, 211);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(25, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 67;
            this.metroLabel9.Text = "От";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxDelayMax
            // 
            this.metroTextBoxDelayMax.Location = new System.Drawing.Point(126, 182);
            this.metroTextBoxDelayMax.Name = "metroTextBoxDelayMax";
            this.metroTextBoxDelayMax.PromptText = "До";
            this.metroTextBoxDelayMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMax.TabIndex = 66;
            this.metroTextBoxDelayMax.Text = "60";
            this.metroTextBoxDelayMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMax.UseStyleColors = true;
            // 
            // metroTextBoxDelayMin
            // 
            this.metroTextBoxDelayMin.Location = new System.Drawing.Point(72, 182);
            this.metroTextBoxDelayMin.Name = "metroTextBoxDelayMin";
            this.metroTextBoxDelayMin.PromptText = "От";
            this.metroTextBoxDelayMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMin.TabIndex = 65;
            this.metroTextBoxDelayMin.Text = "30";
            this.metroTextBoxDelayMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMin.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(46, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 64;
            this.metroLabel5.Text = "Задежка в секундах";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseTime
            // 
            this.metroTextBoxPauseTime.Location = new System.Drawing.Point(94, 304);
            this.metroTextBoxPauseTime.Name = "metroTextBoxPauseTime";
            this.metroTextBoxPauseTime.PromptText = "Минут";
            this.metroTextBoxPauseTime.Size = new System.Drawing.Size(79, 23);
            this.metroTextBoxPauseTime.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseTime.TabIndex = 63;
            this.metroTextBoxPauseTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseTime.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(63, 304);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(25, 19);
            this.metroLabel4.TabIndex = 62;
            this.metroLabel4.Text = "На";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseCount
            // 
            this.metroTextBoxPauseCount.Location = new System.Drawing.Point(94, 275);
            this.metroTextBoxPauseCount.Name = "metroTextBoxPauseCount";
            this.metroTextBoxPauseCount.PromptText = "Подписок";
            this.metroTextBoxPauseCount.Size = new System.Drawing.Size(80, 23);
            this.metroTextBoxPauseCount.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseCount.TabIndex = 61;
            this.metroTextBoxPauseCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseCount.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 275);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 60;
            this.metroLabel3.Text = "После";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(46, 246);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(44, 19);
            this.metroLabel.TabIndex = 59;
            this.metroLabel.Text = "Пауза";
            this.metroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTogglePause
            // 
            this.metroTogglePause.AutoSize = true;
            this.metroTogglePause.Location = new System.Drawing.Point(94, 246);
            this.metroTogglePause.Name = "metroTogglePause";
            this.metroTogglePause.Size = new System.Drawing.Size(80, 17);
            this.metroTogglePause.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTogglePause.TabIndex = 58;
            this.metroTogglePause.Text = "Off";
            this.metroTogglePause.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTogglePause.UseVisualStyleBackColor = true;
            // 
            // metroButtonOpenFileBase
            // 
            this.metroButtonOpenFileBase.Location = new System.Drawing.Point(23, 117);
            this.metroButtonOpenFileBase.Name = "metroButtonOpenFileBase";
            this.metroButtonOpenFileBase.Size = new System.Drawing.Size(150, 23);
            this.metroButtonOpenFileBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonOpenFileBase.TabIndex = 57;
            this.metroButtonOpenFileBase.Text = "Открыть файл";
            this.metroButtonOpenFileBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOpenFileBase.Click += new System.EventHandler(this.MetroButtonOpenFileBase_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 66);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 56;
            this.metroLabel1.Text = "Путь до файла с базой";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxFileNameBase
            // 
            this.metroTextBoxFileNameBase.Location = new System.Drawing.Point(23, 88);
            this.metroTextBoxFileNameBase.Name = "metroTextBoxFileNameBase";
            this.metroTextBoxFileNameBase.PromptText = "ID";
            this.metroTextBoxFileNameBase.Size = new System.Drawing.Size(150, 23);
            this.metroTextBoxFileNameBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxFileNameBase.TabIndex = 55;
            this.metroTextBoxFileNameBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxFileNameBase.UseStyleColors = true;
            // 
            // metroTextBoxCountPublish
            // 
            this.metroTextBoxCountPublish.Location = new System.Drawing.Point(136, 358);
            this.metroTextBoxCountPublish.Name = "metroTextBoxCountPublish";
            this.metroTextBoxCountPublish.PromptText = "Подписок";
            this.metroTextBoxCountPublish.Size = new System.Drawing.Size(37, 23);
            this.metroTextBoxCountPublish.TabIndex = 70;
            this.metroTextBoxCountPublish.Text = "1";
            this.metroTextBoxCountPublish.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(32, 340);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(142, 15);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 69;
            this.metroLabel7.Text = "Комментировать записей";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxCountCommentUnderPublish
            // 
            this.metroTextBoxCountCommentUnderPublish.Location = new System.Drawing.Point(136, 412);
            this.metroTextBoxCountCommentUnderPublish.Name = "metroTextBoxCountCommentUnderPublish";
            this.metroTextBoxCountCommentUnderPublish.PromptText = "Подписок";
            this.metroTextBoxCountCommentUnderPublish.Size = new System.Drawing.Size(37, 23);
            this.metroTextBoxCountCommentUnderPublish.TabIndex = 72;
            this.metroTextBoxCountCommentUnderPublish.Text = "1";
            this.metroTextBoxCountCommentUnderPublish.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(17, 394);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(156, 15);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 71;
            this.metroLabel2.Text = "Комментариев под записью";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxLimit
            // 
            this.metroTextBoxLimit.Location = new System.Drawing.Point(375, 70);
            this.metroTextBoxLimit.Name = "metroTextBoxLimit";
            this.metroTextBoxLimit.PromptText = "Подписок";
            this.metroTextBoxLimit.Size = new System.Drawing.Size(65, 23);
            this.metroTextBoxLimit.TabIndex = 74;
            this.metroTextBoxLimit.Text = "500";
            this.metroTextBoxLimit.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(198, 70);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(165, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel6.TabIndex = 73;
            this.metroLabel6.Text = "Максимум комментариев";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(269, 146);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(26, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel8.TabIndex = 79;
            this.metroLabel8.Text = "До";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(210, 146);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(25, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel10.TabIndex = 78;
            this.metroLabel10.Text = "От";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxDelayUserMax
            // 
            this.metroTextBoxDelayUserMax.Location = new System.Drawing.Point(258, 117);
            this.metroTextBoxDelayUserMax.Name = "metroTextBoxDelayUserMax";
            this.metroTextBoxDelayUserMax.PromptText = "До";
            this.metroTextBoxDelayUserMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayUserMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayUserMax.TabIndex = 77;
            this.metroTextBoxDelayUserMax.Text = "60";
            this.metroTextBoxDelayUserMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayUserMax.UseStyleColors = true;
            // 
            // metroTextBoxDelayUserMin
            // 
            this.metroTextBoxDelayUserMin.Location = new System.Drawing.Point(204, 117);
            this.metroTextBoxDelayUserMin.Name = "metroTextBoxDelayUserMin";
            this.metroTextBoxDelayUserMin.PromptText = "От";
            this.metroTextBoxDelayUserMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayUserMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayUserMin.TabIndex = 76;
            this.metroTextBoxDelayUserMin.Text = "30";
            this.metroTextBoxDelayUserMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayUserMin.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(198, 95);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(166, 19);
            this.metroLabel12.TabIndex = 75;
            this.metroLabel12.Text = "Задежка на пользователя";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonClearCommentsFile
            // 
            this.metroButtonClearCommentsFile.Location = new System.Drawing.Point(364, 369);
            this.metroButtonClearCommentsFile.Name = "metroButtonClearCommentsFile";
            this.metroButtonClearCommentsFile.Size = new System.Drawing.Size(91, 23);
            this.metroButtonClearCommentsFile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonClearCommentsFile.TabIndex = 83;
            this.metroButtonClearCommentsFile.Text = "Очистить";
            this.metroButtonClearCommentsFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonClearCommentsFile.Click += new System.EventHandler(this.MetroButtonClearCommentsFile_Click);
            // 
            // metroButtonOpenCommentsFile
            // 
            this.metroButtonOpenCommentsFile.Location = new System.Drawing.Point(198, 369);
            this.metroButtonOpenCommentsFile.Name = "metroButtonOpenCommentsFile";
            this.metroButtonOpenCommentsFile.Size = new System.Drawing.Size(167, 23);
            this.metroButtonOpenCommentsFile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonOpenCommentsFile.TabIndex = 82;
            this.metroButtonOpenCommentsFile.Text = "Открыть файл";
            this.metroButtonOpenCommentsFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOpenCommentsFile.Click += new System.EventHandler(this.MetroButtonOpenCommentsFile_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(198, 186);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(147, 19);
            this.metroLabel13.TabIndex = 81;
            this.metroLabel13.Text = "Список комментариев";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxeComments
            // 
            this.metroTextBoxeComments.Location = new System.Drawing.Point(198, 211);
            this.metroTextBoxeComments.Multiline = true;
            this.metroTextBoxeComments.Name = "metroTextBoxeComments";
            this.metroTextBoxeComments.Size = new System.Drawing.Size(257, 152);
            this.metroTextBoxeComments.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxeComments.TabIndex = 80;
            this.metroTextBoxeComments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxeComments.UseStyleColors = true;
            // 
            // metroCheckBoxDeleteInBase
            // 
            this.metroCheckBoxDeleteInBase.AutoSize = true;
            this.metroCheckBoxDeleteInBase.Location = new System.Drawing.Point(329, 125);
            this.metroCheckBoxDeleteInBase.Name = "metroCheckBoxDeleteInBase";
            this.metroCheckBoxDeleteInBase.Size = new System.Drawing.Size(111, 15);
            this.metroCheckBoxDeleteInBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxDeleteInBase.TabIndex = 84;
            this.metroCheckBoxDeleteInBase.Text = "Удалять из базы";
            this.metroCheckBoxDeleteInBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxDeleteInBase.UseVisualStyleBackColor = true;
            // 
            // metroButtonApply
            // 
            this.metroButtonApply.Location = new System.Drawing.Point(282, 412);
            this.metroButtonApply.Name = "metroButtonApply";
            this.metroButtonApply.Size = new System.Drawing.Size(107, 23);
            this.metroButtonApply.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonApply.TabIndex = 86;
            this.metroButtonApply.Text = "Применить";
            this.metroButtonApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonApply.Click += new System.EventHandler(this.MetroButtonApply_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Location = new System.Drawing.Point(386, 412);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(69, 23);
            this.metroButtonCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonCancel.TabIndex = 85;
            this.metroButtonCancel.Text = "Отмена";
            this.metroButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonCancel.Click += new System.EventHandler(this.MetroButtonCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingMassComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 444);
            this.Controls.Add(this.metroButtonApply);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroCheckBoxDeleteInBase);
            this.Controls.Add(this.metroButtonClearCommentsFile);
            this.Controls.Add(this.metroButtonOpenCommentsFile);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroTextBoxeComments);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroTextBoxDelayUserMax);
            this.Controls.Add(this.metroTextBoxDelayUserMin);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroTextBoxLimit);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroTextBoxCountCommentUnderPublish);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxCountPublish);
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
            this.Name = "SettingMassComment";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Настройка комментариев";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SettingMassComment_Load);
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
        private MetroFramework.Controls.MetroTextBox metroTextBoxCountPublish;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCountCommentUnderPublish;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLimit;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayUserMax;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayUserMin;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton metroButtonClearCommentsFile;
        private MetroFramework.Controls.MetroButton metroButtonOpenCommentsFile;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox metroTextBoxeComments;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxDeleteInBase;
        private MetroFramework.Controls.MetroButton metroButtonApply;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}