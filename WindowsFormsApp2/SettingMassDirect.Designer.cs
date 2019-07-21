namespace WindowsFormsApp2
{
    partial class SettingMassDirect
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
            this.metroCheckBoxDeleteInBase = new MetroFramework.Controls.MetroCheckBox();
            this.metroButtonClearCommentsFile = new MetroFramework.Controls.MetroButton();
            this.metroButtonOpenCommentsFile = new MetroFramework.Controls.MetroButton();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxeComments = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonApply = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(137, 201);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(26, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 82;
            this.metroLabel11.Text = "До";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(78, 201);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(25, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 81;
            this.metroLabel9.Text = "От";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxDelayMax
            // 
            this.metroTextBoxDelayMax.Location = new System.Drawing.Point(126, 172);
            this.metroTextBoxDelayMax.Name = "metroTextBoxDelayMax";
            this.metroTextBoxDelayMax.PromptText = "До";
            this.metroTextBoxDelayMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMax.TabIndex = 80;
            this.metroTextBoxDelayMax.Text = "60";
            this.metroTextBoxDelayMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMax.UseStyleColors = true;
            // 
            // metroTextBoxDelayMin
            // 
            this.metroTextBoxDelayMin.Location = new System.Drawing.Point(72, 172);
            this.metroTextBoxDelayMin.Name = "metroTextBoxDelayMin";
            this.metroTextBoxDelayMin.PromptText = "От";
            this.metroTextBoxDelayMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMin.TabIndex = 79;
            this.metroTextBoxDelayMin.Text = "30";
            this.metroTextBoxDelayMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMin.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(46, 150);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 78;
            this.metroLabel5.Text = "Задежка в секундах";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseTime
            // 
            this.metroTextBoxPauseTime.Location = new System.Drawing.Point(94, 294);
            this.metroTextBoxPauseTime.Name = "metroTextBoxPauseTime";
            this.metroTextBoxPauseTime.PromptText = "Минут";
            this.metroTextBoxPauseTime.Size = new System.Drawing.Size(79, 23);
            this.metroTextBoxPauseTime.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseTime.TabIndex = 77;
            this.metroTextBoxPauseTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseTime.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(63, 294);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(25, 19);
            this.metroLabel4.TabIndex = 76;
            this.metroLabel4.Text = "На";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseCount
            // 
            this.metroTextBoxPauseCount.Location = new System.Drawing.Point(94, 265);
            this.metroTextBoxPauseCount.Name = "metroTextBoxPauseCount";
            this.metroTextBoxPauseCount.PromptText = "Подписок";
            this.metroTextBoxPauseCount.Size = new System.Drawing.Size(80, 23);
            this.metroTextBoxPauseCount.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseCount.TabIndex = 75;
            this.metroTextBoxPauseCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseCount.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 265);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 74;
            this.metroLabel3.Text = "После";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(46, 236);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(44, 19);
            this.metroLabel.TabIndex = 73;
            this.metroLabel.Text = "Пауза";
            this.metroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTogglePause
            // 
            this.metroTogglePause.AutoSize = true;
            this.metroTogglePause.Location = new System.Drawing.Point(94, 236);
            this.metroTogglePause.Name = "metroTogglePause";
            this.metroTogglePause.Size = new System.Drawing.Size(80, 17);
            this.metroTogglePause.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTogglePause.TabIndex = 72;
            this.metroTogglePause.Text = "Off";
            this.metroTogglePause.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTogglePause.UseVisualStyleBackColor = true;
            // 
            // metroButtonOpenFileBase
            // 
            this.metroButtonOpenFileBase.Location = new System.Drawing.Point(23, 107);
            this.metroButtonOpenFileBase.Name = "metroButtonOpenFileBase";
            this.metroButtonOpenFileBase.Size = new System.Drawing.Size(150, 23);
            this.metroButtonOpenFileBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonOpenFileBase.TabIndex = 71;
            this.metroButtonOpenFileBase.Text = "Открыть файл";
            this.metroButtonOpenFileBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOpenFileBase.Click += new System.EventHandler(this.MetroButtonOpenFileBase_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 70;
            this.metroLabel1.Text = "Путь до файла с базой";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxFileNameBase
            // 
            this.metroTextBoxFileNameBase.Location = new System.Drawing.Point(23, 78);
            this.metroTextBoxFileNameBase.Name = "metroTextBoxFileNameBase";
            this.metroTextBoxFileNameBase.PromptText = "ID";
            this.metroTextBoxFileNameBase.Size = new System.Drawing.Size(150, 23);
            this.metroTextBoxFileNameBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxFileNameBase.TabIndex = 69;
            this.metroTextBoxFileNameBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxFileNameBase.UseStyleColors = true;
            // 
            // metroCheckBoxDeleteInBase
            // 
            this.metroCheckBoxDeleteInBase.AutoSize = true;
            this.metroCheckBoxDeleteInBase.Location = new System.Drawing.Point(63, 336);
            this.metroCheckBoxDeleteInBase.Name = "metroCheckBoxDeleteInBase";
            this.metroCheckBoxDeleteInBase.Size = new System.Drawing.Size(111, 15);
            this.metroCheckBoxDeleteInBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxDeleteInBase.TabIndex = 85;
            this.metroCheckBoxDeleteInBase.Text = "Удалять из базы";
            this.metroCheckBoxDeleteInBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxDeleteInBase.UseVisualStyleBackColor = true;
            // 
            // metroButtonClearCommentsFile
            // 
            this.metroButtonClearCommentsFile.Location = new System.Drawing.Point(369, 294);
            this.metroButtonClearCommentsFile.Name = "metroButtonClearCommentsFile";
            this.metroButtonClearCommentsFile.Size = new System.Drawing.Size(91, 23);
            this.metroButtonClearCommentsFile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonClearCommentsFile.TabIndex = 89;
            this.metroButtonClearCommentsFile.Text = "Очистить";
            this.metroButtonClearCommentsFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonClearCommentsFile.Click += new System.EventHandler(this.MetroButtonClearCommentsFile_Click);
            // 
            // metroButtonOpenCommentsFile
            // 
            this.metroButtonOpenCommentsFile.Location = new System.Drawing.Point(203, 294);
            this.metroButtonOpenCommentsFile.Name = "metroButtonOpenCommentsFile";
            this.metroButtonOpenCommentsFile.Size = new System.Drawing.Size(167, 23);
            this.metroButtonOpenCommentsFile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonOpenCommentsFile.TabIndex = 88;
            this.metroButtonOpenCommentsFile.Text = "Открыть файл";
            this.metroButtonOpenCommentsFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOpenCommentsFile.Click += new System.EventHandler(this.MetroButtonOpenCommentsFile_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(203, 56);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(130, 19);
            this.metroLabel13.TabIndex = 87;
            this.metroLabel13.Text = "Список сообщений";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxeComments
            // 
            this.metroTextBoxeComments.Location = new System.Drawing.Point(203, 78);
            this.metroTextBoxeComments.Multiline = true;
            this.metroTextBoxeComments.Name = "metroTextBoxeComments";
            this.metroTextBoxeComments.PromptText = "1 строка - 1 сообщение";
            this.metroTextBoxeComments.Size = new System.Drawing.Size(257, 210);
            this.metroTextBoxeComments.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxeComments.TabIndex = 86;
            this.metroTextBoxeComments.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxeComments.UseStyleColors = true;
            // 
            // metroButtonApply
            // 
            this.metroButtonApply.Location = new System.Drawing.Point(287, 336);
            this.metroButtonApply.Name = "metroButtonApply";
            this.metroButtonApply.Size = new System.Drawing.Size(107, 23);
            this.metroButtonApply.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonApply.TabIndex = 91;
            this.metroButtonApply.Text = "Применить";
            this.metroButtonApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonApply.Click += new System.EventHandler(this.MetroButtonApply_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Location = new System.Drawing.Point(391, 336);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(69, 23);
            this.metroButtonCancel.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonCancel.TabIndex = 90;
            this.metroButtonCancel.Text = "Отмена";
            this.metroButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonCancel.Click += new System.EventHandler(this.MetroButtonCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingMassDirect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 375);
            this.Controls.Add(this.metroButtonApply);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroButtonClearCommentsFile);
            this.Controls.Add(this.metroButtonOpenCommentsFile);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroTextBoxeComments);
            this.Controls.Add(this.metroCheckBoxDeleteInBase);
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
            this.Name = "SettingMassDirect";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Настройки сообщений";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SettingMassDirect_Load);
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
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxDeleteInBase;
        private MetroFramework.Controls.MetroButton metroButtonClearCommentsFile;
        private MetroFramework.Controls.MetroButton metroButtonOpenCommentsFile;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox metroTextBoxeComments;
        private MetroFramework.Controls.MetroButton metroButtonApply;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}