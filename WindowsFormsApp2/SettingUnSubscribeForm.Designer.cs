namespace WindowsFormsApp2
{
    partial class SettingUnSubscribeForm
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
            this.metroTextBoxPauseTime = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPauseCount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTogglePause = new MetroFramework.Controls.MetroToggle();
            this.metroButtonOpenFileBase = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFileNameBase = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxDelayMax = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDelayMin = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxLimit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxWhatDoing = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBoxeExceptions = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonOpenExceptionsFile = new MetroFramework.Controls.MetroButton();
            this.metroButtonClearExceptions = new MetroFramework.Controls.MetroButton();
            this.metroButtonApply = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.metroCheckBoxDeleteInBase = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxUnSubscribeBlock = new MetroFramework.Controls.MetroCheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // metroTextBoxPauseTime
            // 
            this.metroTextBoxPauseTime.Location = new System.Drawing.Point(94, 295);
            this.metroTextBoxPauseTime.Name = "metroTextBoxPauseTime";
            this.metroTextBoxPauseTime.PromptText = "Минут";
            this.metroTextBoxPauseTime.Size = new System.Drawing.Size(79, 23);
            this.metroTextBoxPauseTime.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseTime.TabIndex = 17;
            this.metroTextBoxPauseTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseTime.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(63, 295);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(25, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "На";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseCount
            // 
            this.metroTextBoxPauseCount.Location = new System.Drawing.Point(94, 266);
            this.metroTextBoxPauseCount.Name = "metroTextBoxPauseCount";
            this.metroTextBoxPauseCount.PromptText = "Подписок";
            this.metroTextBoxPauseCount.Size = new System.Drawing.Size(80, 23);
            this.metroTextBoxPauseCount.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseCount.TabIndex = 15;
            this.metroTextBoxPauseCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseCount.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 266);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "После";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(46, 237);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(44, 19);
            this.metroLabel.TabIndex = 13;
            this.metroLabel.Text = "Пауза";
            this.metroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTogglePause
            // 
            this.metroTogglePause.AutoSize = true;
            this.metroTogglePause.Location = new System.Drawing.Point(94, 237);
            this.metroTogglePause.Name = "metroTogglePause";
            this.metroTogglePause.Size = new System.Drawing.Size(80, 17);
            this.metroTogglePause.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTogglePause.TabIndex = 12;
            this.metroTogglePause.Text = "Off";
            this.metroTogglePause.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTogglePause.UseVisualStyleBackColor = true;
            // 
            // metroButtonOpenFileBase
            // 
            this.metroButtonOpenFileBase.Location = new System.Drawing.Point(23, 108);
            this.metroButtonOpenFileBase.Name = "metroButtonOpenFileBase";
            this.metroButtonOpenFileBase.Size = new System.Drawing.Size(150, 23);
            this.metroButtonOpenFileBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonOpenFileBase.TabIndex = 11;
            this.metroButtonOpenFileBase.Text = "Открыть файл";
            this.metroButtonOpenFileBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOpenFileBase.Click += new System.EventHandler(this.MetroButtonOpenFileBase_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(27, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Путь до файла с базой";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxFileNameBase
            // 
            this.metroTextBoxFileNameBase.Location = new System.Drawing.Point(23, 79);
            this.metroTextBoxFileNameBase.Name = "metroTextBoxFileNameBase";
            this.metroTextBoxFileNameBase.PromptText = "ID";
            this.metroTextBoxFileNameBase.Size = new System.Drawing.Size(150, 23);
            this.metroTextBoxFileNameBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxFileNameBase.TabIndex = 9;
            this.metroTextBoxFileNameBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxFileNameBase.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(137, 202);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(26, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 40;
            this.metroLabel11.Text = "До";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(78, 202);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(25, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 39;
            this.metroLabel9.Text = "От";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxDelayMax
            // 
            this.metroTextBoxDelayMax.Location = new System.Drawing.Point(126, 173);
            this.metroTextBoxDelayMax.Name = "metroTextBoxDelayMax";
            this.metroTextBoxDelayMax.PromptText = "До";
            this.metroTextBoxDelayMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMax.TabIndex = 38;
            this.metroTextBoxDelayMax.Text = "60";
            this.metroTextBoxDelayMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMax.UseStyleColors = true;
            // 
            // metroTextBoxDelayMin
            // 
            this.metroTextBoxDelayMin.Location = new System.Drawing.Point(72, 173);
            this.metroTextBoxDelayMin.Name = "metroTextBoxDelayMin";
            this.metroTextBoxDelayMin.PromptText = "От";
            this.metroTextBoxDelayMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMin.TabIndex = 37;
            this.metroTextBoxDelayMin.Text = "30";
            this.metroTextBoxDelayMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMin.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(46, 151);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 36;
            this.metroLabel5.Text = "Задежка в секундах";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxLimit
            // 
            this.metroTextBoxLimit.Location = new System.Drawing.Point(130, 333);
            this.metroTextBoxLimit.Name = "metroTextBoxLimit";
            this.metroTextBoxLimit.PromptText = "Подписок";
            this.metroTextBoxLimit.Size = new System.Drawing.Size(44, 23);
            this.metroTextBoxLimit.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLimit.TabIndex = 42;
            this.metroTextBoxLimit.Text = "1000";
            this.metroTextBoxLimit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLimit.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(13, 337);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(111, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 41;
            this.metroLabel7.Text = "Лимит подписок";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroComboBoxWhatDoing
            // 
            this.metroComboBoxWhatDoing.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBoxWhatDoing.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroComboBoxWhatDoing.FormattingEnabled = true;
            this.metroComboBoxWhatDoing.ItemHeight = 19;
            this.metroComboBoxWhatDoing.Items.AddRange(new object[] {
            "Отписываться от всех",
            "Отписываться по списку из файла",
            "Отписываться от тех, кто не подписан"});
            this.metroComboBoxWhatDoing.Location = new System.Drawing.Point(213, 77);
            this.metroComboBoxWhatDoing.Name = "metroComboBoxWhatDoing";
            this.metroComboBoxWhatDoing.Size = new System.Drawing.Size(215, 25);
            this.metroComboBoxWhatDoing.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroComboBoxWhatDoing.TabIndex = 43;
            this.metroComboBoxWhatDoing.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxeExceptions
            // 
            this.metroTextBoxeExceptions.Location = new System.Drawing.Point(213, 133);
            this.metroTextBoxeExceptions.Multiline = true;
            this.metroTextBoxeExceptions.Name = "metroTextBoxeExceptions";
            this.metroTextBoxeExceptions.Size = new System.Drawing.Size(215, 181);
            this.metroTextBoxeExceptions.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxeExceptions.TabIndex = 44;
            this.metroTextBoxeExceptions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxeExceptions.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(213, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(174, 19);
            this.metroLabel2.TabIndex = 45;
            this.metroLabel2.Text = "ID от кого не отписываться";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButtonOpenExceptionsFile
            // 
            this.metroButtonOpenExceptionsFile.Location = new System.Drawing.Point(213, 320);
            this.metroButtonOpenExceptionsFile.Name = "metroButtonOpenExceptionsFile";
            this.metroButtonOpenExceptionsFile.Size = new System.Drawing.Size(125, 23);
            this.metroButtonOpenExceptionsFile.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonOpenExceptionsFile.TabIndex = 46;
            this.metroButtonOpenExceptionsFile.Text = "Открыть файл";
            this.metroButtonOpenExceptionsFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOpenExceptionsFile.Click += new System.EventHandler(this.MetroButtonOpenExceptionsFile_Click);
            // 
            // metroButtonClearExceptions
            // 
            this.metroButtonClearExceptions.Location = new System.Drawing.Point(344, 320);
            this.metroButtonClearExceptions.Name = "metroButtonClearExceptions";
            this.metroButtonClearExceptions.Size = new System.Drawing.Size(84, 23);
            this.metroButtonClearExceptions.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonClearExceptions.TabIndex = 47;
            this.metroButtonClearExceptions.Text = "Очистить";
            this.metroButtonClearExceptions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonClearExceptions.Click += new System.EventHandler(this.MetroButtonClearExceptions_Click);
            // 
            // metroButtonApply
            // 
            this.metroButtonApply.Location = new System.Drawing.Point(262, 380);
            this.metroButtonApply.Name = "metroButtonApply";
            this.metroButtonApply.Size = new System.Drawing.Size(98, 23);
            this.metroButtonApply.TabIndex = 49;
            this.metroButtonApply.Text = "Применить";
            this.metroButtonApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonApply.Click += new System.EventHandler(this.MetroButtonApply_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Location = new System.Drawing.Point(366, 380);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(62, 23);
            this.metroButtonCancel.TabIndex = 48;
            this.metroButtonCancel.Text = "Отмена";
            this.metroButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonCancel.Click += new System.EventHandler(this.MetroButtonCancel_Click);
            // 
            // metroCheckBoxDeleteInBase
            // 
            this.metroCheckBoxDeleteInBase.AutoSize = true;
            this.metroCheckBoxDeleteInBase.Location = new System.Drawing.Point(13, 388);
            this.metroCheckBoxDeleteInBase.Name = "metroCheckBoxDeleteInBase";
            this.metroCheckBoxDeleteInBase.Size = new System.Drawing.Size(111, 15);
            this.metroCheckBoxDeleteInBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxDeleteInBase.TabIndex = 51;
            this.metroCheckBoxDeleteInBase.Text = "Удалять из базы";
            this.metroCheckBoxDeleteInBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxDeleteInBase.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxUnSubscribeBlock
            // 
            this.metroCheckBoxUnSubscribeBlock.AutoSize = true;
            this.metroCheckBoxUnSubscribeBlock.Location = new System.Drawing.Point(13, 367);
            this.metroCheckBoxUnSubscribeBlock.Name = "metroCheckBoxUnSubscribeBlock";
            this.metroCheckBoxUnSubscribeBlock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroCheckBoxUnSubscribeBlock.Size = new System.Drawing.Size(204, 15);
            this.metroCheckBoxUnSubscribeBlock.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxUnSubscribeBlock.TabIndex = 50;
            this.metroCheckBoxUnSubscribeBlock.Text = "Отписываться через блокировку";
            this.metroCheckBoxUnSubscribeBlock.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxUnSubscribeBlock.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingUnSubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 414);
            this.Controls.Add(this.metroCheckBoxDeleteInBase);
            this.Controls.Add(this.metroCheckBoxUnSubscribeBlock);
            this.Controls.Add(this.metroButtonApply);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroButtonClearExceptions);
            this.Controls.Add(this.metroButtonOpenExceptionsFile);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxeExceptions);
            this.Controls.Add(this.metroComboBoxWhatDoing);
            this.Controls.Add(this.metroTextBoxLimit);
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
            this.Name = "SettingUnSubscribeForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Настройки отписки";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SettingUnSubscribeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxPauseTime;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPauseCount;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel;
        private MetroFramework.Controls.MetroToggle metroTogglePause;
        private MetroFramework.Controls.MetroButton metroButtonOpenFileBase;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFileNameBase;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayMax;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDelayMin;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLimit;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox metroComboBoxWhatDoing;
        private MetroFramework.Controls.MetroTextBox metroTextBoxeExceptions;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton metroButtonOpenExceptionsFile;
        private MetroFramework.Controls.MetroButton metroButtonClearExceptions;
        private MetroFramework.Controls.MetroButton metroButtonApply;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxDeleteInBase;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxUnSubscribeBlock;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}