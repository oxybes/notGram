namespace WindowsFormsApp2
{
    partial class SettingClearBotsForm
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
            this.metroTextBoxLimit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBoxWhomClear = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBoxFollowersLess = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxPublishLess = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxNoAvatar = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxSubscriptionsMore = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxBlockUser = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxSSubscriptionsLess = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBoxPublishLess = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFollowersLess = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSubscriptionLess = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxSubscriptionsMore = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonApply = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancel = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(189, 204);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(26, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 99;
            this.metroLabel11.Text = "До";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(130, 204);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(25, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel9.TabIndex = 98;
            this.metroLabel9.Text = "От";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxDelayMax
            // 
            this.metroTextBoxDelayMax.Location = new System.Drawing.Point(178, 175);
            this.metroTextBoxDelayMax.Name = "metroTextBoxDelayMax";
            this.metroTextBoxDelayMax.PromptText = "До";
            this.metroTextBoxDelayMax.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMax.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMax.TabIndex = 97;
            this.metroTextBoxDelayMax.Text = "60";
            this.metroTextBoxDelayMax.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMax.UseStyleColors = true;
            // 
            // metroTextBoxDelayMin
            // 
            this.metroTextBoxDelayMin.Location = new System.Drawing.Point(124, 175);
            this.metroTextBoxDelayMin.Name = "metroTextBoxDelayMin";
            this.metroTextBoxDelayMin.PromptText = "От";
            this.metroTextBoxDelayMin.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxDelayMin.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxDelayMin.TabIndex = 96;
            this.metroTextBoxDelayMin.Text = "30";
            this.metroTextBoxDelayMin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxDelayMin.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(98, 153);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(128, 19);
            this.metroLabel5.TabIndex = 95;
            this.metroLabel5.Text = "Задежка в секундах";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseTime
            // 
            this.metroTextBoxPauseTime.Location = new System.Drawing.Point(146, 297);
            this.metroTextBoxPauseTime.Name = "metroTextBoxPauseTime";
            this.metroTextBoxPauseTime.PromptText = "Минут";
            this.metroTextBoxPauseTime.Size = new System.Drawing.Size(79, 23);
            this.metroTextBoxPauseTime.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseTime.TabIndex = 94;
            this.metroTextBoxPauseTime.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseTime.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(115, 297);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(25, 19);
            this.metroLabel4.TabIndex = 93;
            this.metroLabel4.Text = "На";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxPauseCount
            // 
            this.metroTextBoxPauseCount.Location = new System.Drawing.Point(146, 268);
            this.metroTextBoxPauseCount.Name = "metroTextBoxPauseCount";
            this.metroTextBoxPauseCount.PromptText = "Подписок";
            this.metroTextBoxPauseCount.Size = new System.Drawing.Size(80, 23);
            this.metroTextBoxPauseCount.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPauseCount.TabIndex = 92;
            this.metroTextBoxPauseCount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPauseCount.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(95, 268);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 91;
            this.metroLabel3.Text = "После";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel
            // 
            this.metroLabel.AutoSize = true;
            this.metroLabel.Location = new System.Drawing.Point(98, 239);
            this.metroLabel.Name = "metroLabel";
            this.metroLabel.Size = new System.Drawing.Size(44, 19);
            this.metroLabel.TabIndex = 90;
            this.metroLabel.Text = "Пауза";
            this.metroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTogglePause
            // 
            this.metroTogglePause.AutoSize = true;
            this.metroTogglePause.Location = new System.Drawing.Point(146, 239);
            this.metroTogglePause.Name = "metroTogglePause";
            this.metroTogglePause.Size = new System.Drawing.Size(80, 17);
            this.metroTogglePause.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTogglePause.TabIndex = 89;
            this.metroTogglePause.Text = "Off";
            this.metroTogglePause.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTogglePause.UseVisualStyleBackColor = true;
            // 
            // metroButtonOpenFileBase
            // 
            this.metroButtonOpenFileBase.Location = new System.Drawing.Point(75, 110);
            this.metroButtonOpenFileBase.Name = "metroButtonOpenFileBase";
            this.metroButtonOpenFileBase.Size = new System.Drawing.Size(150, 23);
            this.metroButtonOpenFileBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonOpenFileBase.TabIndex = 88;
            this.metroButtonOpenFileBase.Text = "Открыть файл";
            this.metroButtonOpenFileBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonOpenFileBase.Click += new System.EventHandler(this.MetroButtonOpenFileBase_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(202, 19);
            this.metroLabel1.TabIndex = 87;
            this.metroLabel1.Text = "Путь до файла с исключениями";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBoxFileNameBase
            // 
            this.metroTextBoxFileNameBase.Location = new System.Drawing.Point(75, 81);
            this.metroTextBoxFileNameBase.Name = "metroTextBoxFileNameBase";
            this.metroTextBoxFileNameBase.PromptText = "ID";
            this.metroTextBoxFileNameBase.Size = new System.Drawing.Size(150, 23);
            this.metroTextBoxFileNameBase.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxFileNameBase.TabIndex = 86;
            this.metroTextBoxFileNameBase.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxFileNameBase.UseStyleColors = true;
            // 
            // metroTextBoxLimit
            // 
            this.metroTextBoxLimit.Location = new System.Drawing.Point(146, 344);
            this.metroTextBoxLimit.Name = "metroTextBoxLimit";
            this.metroTextBoxLimit.PromptText = "Подписок";
            this.metroTextBoxLimit.Size = new System.Drawing.Size(79, 23);
            this.metroTextBoxLimit.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxLimit.TabIndex = 101;
            this.metroTextBoxLimit.Text = "1000";
            this.metroTextBoxLimit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxLimit.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(14, 344);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(126, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel7.TabIndex = 100;
            this.metroLabel7.Text = "Лимит блокировок";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroComboBoxWhomClear
            // 
            this.metroComboBoxWhomClear.FontSize = MetroFramework.MetroLinkSize.Small;
            this.metroComboBoxWhomClear.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.metroComboBoxWhomClear.FormattingEnabled = true;
            this.metroComboBoxWhomClear.ItemHeight = 19;
            this.metroComboBoxWhomClear.Items.AddRange(new object[] {
            "Подписки",
            "Подписчиков"});
            this.metroComboBoxWhomClear.Location = new System.Drawing.Point(270, 81);
            this.metroComboBoxWhomClear.Name = "metroComboBoxWhomClear";
            this.metroComboBoxWhomClear.Size = new System.Drawing.Size(215, 25);
            this.metroComboBoxWhomClear.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroComboBoxWhomClear.TabIndex = 102;
            this.metroComboBoxWhomClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(399, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 103;
            this.metroLabel2.Text = "Кого чистить";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(321, 153);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(126, 19);
            this.metroLabel6.TabIndex = 104;
            this.metroLabel6.Text = "Отписываться если";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroCheckBoxFollowersLess
            // 
            this.metroCheckBoxFollowersLess.AutoSize = true;
            this.metroCheckBoxFollowersLess.Location = new System.Drawing.Point(270, 242);
            this.metroCheckBoxFollowersLess.Name = "metroCheckBoxFollowersLess";
            this.metroCheckBoxFollowersLess.Size = new System.Drawing.Size(146, 15);
            this.metroCheckBoxFollowersLess.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxFollowersLess.TabIndex = 107;
            this.metroCheckBoxFollowersLess.Text = "Подписчиков меньше";
            this.metroCheckBoxFollowersLess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxFollowersLess.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxPublishLess
            // 
            this.metroCheckBoxPublishLess.AutoSize = true;
            this.metroCheckBoxPublishLess.Location = new System.Drawing.Point(270, 213);
            this.metroCheckBoxPublishLess.Name = "metroCheckBoxPublishLess";
            this.metroCheckBoxPublishLess.Size = new System.Drawing.Size(140, 15);
            this.metroCheckBoxPublishLess.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxPublishLess.TabIndex = 106;
            this.metroCheckBoxPublishLess.Text = "Публикаций меньше";
            this.metroCheckBoxPublishLess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxPublishLess.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxNoAvatar
            // 
            this.metroCheckBoxNoAvatar.AutoSize = true;
            this.metroCheckBoxNoAvatar.Location = new System.Drawing.Point(270, 183);
            this.metroCheckBoxNoAvatar.Name = "metroCheckBoxNoAvatar";
            this.metroCheckBoxNoAvatar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroCheckBoxNoAvatar.Size = new System.Drawing.Size(95, 15);
            this.metroCheckBoxNoAvatar.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxNoAvatar.TabIndex = 105;
            this.metroCheckBoxNoAvatar.Text = "Нет аватарки";
            this.metroCheckBoxNoAvatar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxNoAvatar.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxSubscriptionsMore
            // 
            this.metroCheckBoxSubscriptionsMore.AutoSize = true;
            this.metroCheckBoxSubscriptionsMore.Location = new System.Drawing.Point(270, 300);
            this.metroCheckBoxSubscriptionsMore.Name = "metroCheckBoxSubscriptionsMore";
            this.metroCheckBoxSubscriptionsMore.Size = new System.Drawing.Size(125, 15);
            this.metroCheckBoxSubscriptionsMore.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxSubscriptionsMore.TabIndex = 110;
            this.metroCheckBoxSubscriptionsMore.Text = "Подписок больше";
            this.metroCheckBoxSubscriptionsMore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxSubscriptionsMore.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxBlockUser
            // 
            this.metroCheckBoxBlockUser.AutoSize = true;
            this.metroCheckBoxBlockUser.Location = new System.Drawing.Point(14, 373);
            this.metroCheckBoxBlockUser.Name = "metroCheckBoxBlockUser";
            this.metroCheckBoxBlockUser.Size = new System.Drawing.Size(263, 15);
            this.metroCheckBoxBlockUser.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxBlockUser.TabIndex = 109;
            this.metroCheckBoxBlockUser.Text = "Оставлять пользователя заблокированным";
            this.metroCheckBoxBlockUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxBlockUser.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxSSubscriptionsLess
            // 
            this.metroCheckBoxSSubscriptionsLess.AutoSize = true;
            this.metroCheckBoxSSubscriptionsLess.Location = new System.Drawing.Point(270, 268);
            this.metroCheckBoxSSubscriptionsLess.Name = "metroCheckBoxSSubscriptionsLess";
            this.metroCheckBoxSSubscriptionsLess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroCheckBoxSSubscriptionsLess.Size = new System.Drawing.Size(126, 15);
            this.metroCheckBoxSSubscriptionsLess.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxSSubscriptionsLess.TabIndex = 108;
            this.metroCheckBoxSSubscriptionsLess.Text = "Подписок меньше";
            this.metroCheckBoxSSubscriptionsLess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxSSubscriptionsLess.UseVisualStyleBackColor = true;
            // 
            // metroTextBoxPublishLess
            // 
            this.metroTextBoxPublishLess.Location = new System.Drawing.Point(437, 213);
            this.metroTextBoxPublishLess.Name = "metroTextBoxPublishLess";
            this.metroTextBoxPublishLess.PromptText = "Подписок";
            this.metroTextBoxPublishLess.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxPublishLess.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxPublishLess.TabIndex = 111;
            this.metroTextBoxPublishLess.Text = "1";
            this.metroTextBoxPublishLess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxPublishLess.UseStyleColors = true;
            // 
            // metroTextBoxFollowersLess
            // 
            this.metroTextBoxFollowersLess.Location = new System.Drawing.Point(437, 242);
            this.metroTextBoxFollowersLess.Name = "metroTextBoxFollowersLess";
            this.metroTextBoxFollowersLess.PromptText = "Подписок";
            this.metroTextBoxFollowersLess.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxFollowersLess.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxFollowersLess.TabIndex = 112;
            this.metroTextBoxFollowersLess.Text = "1";
            this.metroTextBoxFollowersLess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxFollowersLess.UseStyleColors = true;
            // 
            // metroTextBoxSubscriptionLess
            // 
            this.metroTextBoxSubscriptionLess.Location = new System.Drawing.Point(437, 271);
            this.metroTextBoxSubscriptionLess.Name = "metroTextBoxSubscriptionLess";
            this.metroTextBoxSubscriptionLess.PromptText = "Подписок";
            this.metroTextBoxSubscriptionLess.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxSubscriptionLess.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxSubscriptionLess.TabIndex = 113;
            this.metroTextBoxSubscriptionLess.Text = "1";
            this.metroTextBoxSubscriptionLess.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxSubscriptionLess.UseStyleColors = true;
            // 
            // metroTextBoxSubscriptionsMore
            // 
            this.metroTextBoxSubscriptionsMore.Location = new System.Drawing.Point(437, 300);
            this.metroTextBoxSubscriptionsMore.Name = "metroTextBoxSubscriptionsMore";
            this.metroTextBoxSubscriptionsMore.PromptText = "Подписок";
            this.metroTextBoxSubscriptionsMore.Size = new System.Drawing.Size(48, 23);
            this.metroTextBoxSubscriptionsMore.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTextBoxSubscriptionsMore.TabIndex = 114;
            this.metroTextBoxSubscriptionsMore.Text = "1";
            this.metroTextBoxSubscriptionsMore.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBoxSubscriptionsMore.UseStyleColors = true;
            // 
            // metroButtonApply
            // 
            this.metroButtonApply.Location = new System.Drawing.Point(319, 365);
            this.metroButtonApply.Name = "metroButtonApply";
            this.metroButtonApply.Size = new System.Drawing.Size(98, 23);
            this.metroButtonApply.TabIndex = 116;
            this.metroButtonApply.Text = "Применить";
            this.metroButtonApply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonApply.Click += new System.EventHandler(this.MetroButtonApply_Click);
            // 
            // metroButtonCancel
            // 
            this.metroButtonCancel.Location = new System.Drawing.Point(423, 365);
            this.metroButtonCancel.Name = "metroButtonCancel";
            this.metroButtonCancel.Size = new System.Drawing.Size(62, 23);
            this.metroButtonCancel.TabIndex = 115;
            this.metroButtonCancel.Text = "Отмена";
            this.metroButtonCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonCancel.Click += new System.EventHandler(this.MetroButtonCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingClearBotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 416);
            this.Controls.Add(this.metroButtonApply);
            this.Controls.Add(this.metroButtonCancel);
            this.Controls.Add(this.metroTextBoxSubscriptionsMore);
            this.Controls.Add(this.metroTextBoxSubscriptionLess);
            this.Controls.Add(this.metroTextBoxFollowersLess);
            this.Controls.Add(this.metroTextBoxPublishLess);
            this.Controls.Add(this.metroCheckBoxSubscriptionsMore);
            this.Controls.Add(this.metroCheckBoxBlockUser);
            this.Controls.Add(this.metroCheckBoxSSubscriptionsLess);
            this.Controls.Add(this.metroCheckBoxFollowersLess);
            this.Controls.Add(this.metroCheckBoxPublishLess);
            this.Controls.Add(this.metroCheckBoxNoAvatar);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroComboBoxWhomClear);
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
            this.Name = "SettingClearBotsForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Настройки чистки от ботов";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SettingClearBotsForm_Load);
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
        private MetroFramework.Controls.MetroTextBox metroTextBoxLimit;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox metroComboBoxWhomClear;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxFollowersLess;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxPublishLess;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxNoAvatar;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSubscriptionsMore;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxBlockUser;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSSubscriptionsLess;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPublishLess;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFollowersLess;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSubscriptionLess;
        private MetroFramework.Controls.MetroTextBox metroTextBoxSubscriptionsMore;
        private MetroFramework.Controls.MetroButton metroButtonApply;
        private MetroFramework.Controls.MetroButton metroButtonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}