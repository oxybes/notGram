namespace WindowsFormsApp2
{
    partial class MainForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroCheckBoxClearBots = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxMassDirect = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxMassComment = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxMassLike = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxUnSubscribe = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxSubscribe = new MetroFramework.Controls.MetroCheckBox();
            this.metroTileSettingClearBots = new MetroFramework.Controls.MetroTile();
            this.metroTileSettingMassDirect = new MetroFramework.Controls.MetroTile();
            this.metroTileSettingMassComment = new MetroFramework.Controls.MetroTile();
            this.metroTileSettingMassLike = new MetroFramework.Controls.MetroTile();
            this.metroTileSettingUnSubscribe = new MetroFramework.Controls.MetroTile();
            this.metroTileSettingSubscribe = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTileClearLog = new MetroFramework.Controls.MetroTile();
            this.metroTileSaveLog = new MetroFramework.Controls.MetroTile();
            this.metroButtonStart = new MetroFramework.Controls.MetroButton();
            this.metroButtonPause = new MetroFramework.Controls.MetroButton();
            this.metroButtonStop = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxLog = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.metroTileSettingClearBots);
            this.metroPanel1.Controls.Add(this.metroTileSettingMassDirect);
            this.metroPanel1.Controls.Add(this.metroTileSettingMassComment);
            this.metroPanel1.Controls.Add(this.metroTileSettingMassLike);
            this.metroPanel1.Controls.Add(this.metroTileSettingUnSubscribe);
            this.metroPanel1.Controls.Add(this.metroTileSettingSubscribe);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 30);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(201, 486);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.metroCheckBoxClearBots);
            this.groupBox1.Controls.Add(this.metroCheckBoxMassDirect);
            this.groupBox1.Controls.Add(this.metroCheckBoxMassComment);
            this.groupBox1.Controls.Add(this.metroCheckBoxMassLike);
            this.groupBox1.Controls.Add(this.metroCheckBoxUnSubscribe);
            this.groupBox1.Controls.Add(this.metroCheckBoxSubscribe);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(26, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 156);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что делать";
            // 
            // metroCheckBoxClearBots
            // 
            this.metroCheckBoxClearBots.AutoSize = true;
            this.metroCheckBoxClearBots.Location = new System.Drawing.Point(6, 124);
            this.metroCheckBoxClearBots.Name = "metroCheckBoxClearBots";
            this.metroCheckBoxClearBots.Size = new System.Drawing.Size(111, 15);
            this.metroCheckBoxClearBots.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxClearBots.TabIndex = 5;
            this.metroCheckBoxClearBots.Text = "Чистка от ботов";
            this.metroCheckBoxClearBots.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxClearBots.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxMassDirect
            // 
            this.metroCheckBoxMassDirect.AutoSize = true;
            this.metroCheckBoxMassDirect.Location = new System.Drawing.Point(6, 103);
            this.metroCheckBoxMassDirect.Name = "metroCheckBoxMassDirect";
            this.metroCheckBoxMassDirect.Size = new System.Drawing.Size(91, 15);
            this.metroCheckBoxMassDirect.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxMassDirect.TabIndex = 4;
            this.metroCheckBoxMassDirect.Text = "МассДирект";
            this.metroCheckBoxMassDirect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxMassDirect.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxMassComment
            // 
            this.metroCheckBoxMassComment.AutoSize = true;
            this.metroCheckBoxMassComment.Location = new System.Drawing.Point(6, 82);
            this.metroCheckBoxMassComment.Name = "metroCheckBoxMassComment";
            this.metroCheckBoxMassComment.Size = new System.Drawing.Size(102, 15);
            this.metroCheckBoxMassComment.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxMassComment.TabIndex = 3;
            this.metroCheckBoxMassComment.Text = "МассКоммент";
            this.metroCheckBoxMassComment.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxMassComment.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxMassLike
            // 
            this.metroCheckBoxMassLike.AutoSize = true;
            this.metroCheckBoxMassLike.Location = new System.Drawing.Point(6, 61);
            this.metroCheckBoxMassLike.Name = "metroCheckBoxMassLike";
            this.metroCheckBoxMassLike.Size = new System.Drawing.Size(78, 15);
            this.metroCheckBoxMassLike.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxMassLike.TabIndex = 2;
            this.metroCheckBoxMassLike.Text = "Масслайк";
            this.metroCheckBoxMassLike.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxMassLike.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxUnSubscribe
            // 
            this.metroCheckBoxUnSubscribe.AutoSize = true;
            this.metroCheckBoxUnSubscribe.Location = new System.Drawing.Point(6, 40);
            this.metroCheckBoxUnSubscribe.Name = "metroCheckBoxUnSubscribe";
            this.metroCheckBoxUnSubscribe.Size = new System.Drawing.Size(69, 15);
            this.metroCheckBoxUnSubscribe.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxUnSubscribe.TabIndex = 1;
            this.metroCheckBoxUnSubscribe.Text = "Отписка";
            this.metroCheckBoxUnSubscribe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxUnSubscribe.UseVisualStyleBackColor = true;
            // 
            // metroCheckBoxSubscribe
            // 
            this.metroCheckBoxSubscribe.AutoSize = true;
            this.metroCheckBoxSubscribe.Location = new System.Drawing.Point(6, 19);
            this.metroCheckBoxSubscribe.Name = "metroCheckBoxSubscribe";
            this.metroCheckBoxSubscribe.Size = new System.Drawing.Size(77, 15);
            this.metroCheckBoxSubscribe.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroCheckBoxSubscribe.TabIndex = 0;
            this.metroCheckBoxSubscribe.Text = "Подписка";
            this.metroCheckBoxSubscribe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroCheckBoxSubscribe.UseVisualStyleBackColor = true;
            // 
            // metroTileSettingClearBots
            // 
            this.metroTileSettingClearBots.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileSettingClearBots.CustomForeColor = true;
            this.metroTileSettingClearBots.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileSettingClearBots.Location = new System.Drawing.Point(26, 177);
            this.metroTileSettingClearBots.Name = "metroTileSettingClearBots";
            this.metroTileSettingClearBots.Size = new System.Drawing.Size(148, 26);
            this.metroTileSettingClearBots.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileSettingClearBots.TabIndex = 6;
            this.metroTileSettingClearBots.Text = "Чистка от ботов";
            this.metroTileSettingClearBots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSettingClearBots.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileSettingClearBots.Click += new System.EventHandler(this.MetroTileSettingClearBots_Click);
            // 
            // metroTileSettingMassDirect
            // 
            this.metroTileSettingMassDirect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileSettingMassDirect.CustomForeColor = true;
            this.metroTileSettingMassDirect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileSettingMassDirect.Location = new System.Drawing.Point(26, 145);
            this.metroTileSettingMassDirect.Name = "metroTileSettingMassDirect";
            this.metroTileSettingMassDirect.Size = new System.Drawing.Size(148, 26);
            this.metroTileSettingMassDirect.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileSettingMassDirect.TabIndex = 5;
            this.metroTileSettingMassDirect.Text = "МассДирект";
            this.metroTileSettingMassDirect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSettingMassDirect.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileSettingMassDirect.Click += new System.EventHandler(this.MetroTileSettingMassDirect_Click);
            // 
            // metroTileSettingMassComment
            // 
            this.metroTileSettingMassComment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileSettingMassComment.CustomForeColor = true;
            this.metroTileSettingMassComment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileSettingMassComment.Location = new System.Drawing.Point(26, 113);
            this.metroTileSettingMassComment.Name = "metroTileSettingMassComment";
            this.metroTileSettingMassComment.Size = new System.Drawing.Size(148, 26);
            this.metroTileSettingMassComment.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileSettingMassComment.TabIndex = 4;
            this.metroTileSettingMassComment.Text = "МассКоммент";
            this.metroTileSettingMassComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSettingMassComment.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileSettingMassComment.Click += new System.EventHandler(this.MetroTileSettingMassComment_Click);
            // 
            // metroTileSettingMassLike
            // 
            this.metroTileSettingMassLike.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileSettingMassLike.CustomForeColor = true;
            this.metroTileSettingMassLike.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileSettingMassLike.Location = new System.Drawing.Point(26, 81);
            this.metroTileSettingMassLike.Name = "metroTileSettingMassLike";
            this.metroTileSettingMassLike.Size = new System.Drawing.Size(148, 26);
            this.metroTileSettingMassLike.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileSettingMassLike.TabIndex = 3;
            this.metroTileSettingMassLike.Text = "МассЛайк";
            this.metroTileSettingMassLike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSettingMassLike.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileSettingMassLike.Click += new System.EventHandler(this.MetroTile3_Click);
            // 
            // metroTileSettingUnSubscribe
            // 
            this.metroTileSettingUnSubscribe.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileSettingUnSubscribe.CustomForeColor = true;
            this.metroTileSettingUnSubscribe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileSettingUnSubscribe.Location = new System.Drawing.Point(26, 49);
            this.metroTileSettingUnSubscribe.Name = "metroTileSettingUnSubscribe";
            this.metroTileSettingUnSubscribe.Size = new System.Drawing.Size(148, 26);
            this.metroTileSettingUnSubscribe.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileSettingUnSubscribe.TabIndex = 2;
            this.metroTileSettingUnSubscribe.Text = "Отписка";
            this.metroTileSettingUnSubscribe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSettingUnSubscribe.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileSettingUnSubscribe.Click += new System.EventHandler(this.MetroTile2_Click);
            // 
            // metroTileSettingSubscribe
            // 
            this.metroTileSettingSubscribe.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileSettingSubscribe.CustomForeColor = true;
            this.metroTileSettingSubscribe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileSettingSubscribe.Location = new System.Drawing.Point(26, 17);
            this.metroTileSettingSubscribe.Name = "metroTileSettingSubscribe";
            this.metroTileSettingSubscribe.Size = new System.Drawing.Size(148, 26);
            this.metroTileSettingSubscribe.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileSettingSubscribe.TabIndex = 1;
            this.metroTileSettingSubscribe.Text = "Подписка";
            this.metroTileSettingSubscribe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSettingSubscribe.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTileSettingSubscribe.Click += new System.EventHandler(this.MetroTile1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(227, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(31, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Лог";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTileClearLog
            // 
            this.metroTileClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTileClearLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileClearLog.CustomForeColor = true;
            this.metroTileClearLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileClearLog.Location = new System.Drawing.Point(792, 487);
            this.metroTileClearLog.Name = "metroTileClearLog";
            this.metroTileClearLog.Size = new System.Drawing.Size(148, 26);
            this.metroTileClearLog.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileClearLog.TabIndex = 3;
            this.metroTileClearLog.Text = "Очистить";
            this.metroTileClearLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileClearLog.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // metroTileSaveLog
            // 
            this.metroTileSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTileSaveLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.metroTileSaveLog.CustomForeColor = true;
            this.metroTileSaveLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroTileSaveLog.Location = new System.Drawing.Point(638, 487);
            this.metroTileSaveLog.Name = "metroTileSaveLog";
            this.metroTileSaveLog.Size = new System.Drawing.Size(148, 26);
            this.metroTileSaveLog.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTileSaveLog.TabIndex = 4;
            this.metroTileSaveLog.Text = "Сохранить лог";
            this.metroTileSaveLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileSaveLog.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // metroButtonStart
            // 
            this.metroButtonStart.Location = new System.Drawing.Point(738, 44);
            this.metroButtonStart.Name = "metroButtonStart";
            this.metroButtonStart.Size = new System.Drawing.Size(69, 23);
            this.metroButtonStart.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonStart.TabIndex = 2;
            this.metroButtonStart.Text = "Старт";
            this.metroButtonStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonStart.Click += new System.EventHandler(this.MetroButtonStart_Click);
            // 
            // metroButtonPause
            // 
            this.metroButtonPause.Enabled = false;
            this.metroButtonPause.Location = new System.Drawing.Point(803, 44);
            this.metroButtonPause.Name = "metroButtonPause";
            this.metroButtonPause.Size = new System.Drawing.Size(69, 23);
            this.metroButtonPause.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonPause.TabIndex = 3;
            this.metroButtonPause.Text = "Пауза";
            this.metroButtonPause.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonPause.Click += new System.EventHandler(this.MetroButtonPause_Click);
            // 
            // metroButtonStop
            // 
            this.metroButtonStop.Location = new System.Drawing.Point(868, 44);
            this.metroButtonStop.Name = "metroButtonStop";
            this.metroButtonStop.Size = new System.Drawing.Size(69, 23);
            this.metroButtonStop.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButtonStop.TabIndex = 4;
            this.metroButtonStop.Text = "Стоп";
            this.metroButtonStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButtonStop.Click += new System.EventHandler(this.MetroButtonStop_Click);
            // 
            // metroTextBoxLog
            // 
            this.metroTextBoxLog.Location = new System.Drawing.Point(227, 73);
            this.metroTextBoxLog.Multiline = true;
            this.metroTextBoxLog.Name = "metroTextBoxLog";
            this.metroTextBoxLog.Size = new System.Drawing.Size(710, 408);
            this.metroTextBoxLog.TabIndex = 5;
            this.metroTextBoxLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 536);
            this.Controls.Add(this.metroTextBoxLog);
            this.Controls.Add(this.metroTileSaveLog);
            this.Controls.Add(this.metroButtonStop);
            this.Controls.Add(this.metroTileClearLog);
            this.Controls.Add(this.metroButtonPause);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButtonStart);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "MainForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile metroTileSettingSubscribe;
        private MetroFramework.Controls.MetroTile metroTileSettingClearBots;
        private MetroFramework.Controls.MetroTile metroTileSettingMassDirect;
        private MetroFramework.Controls.MetroTile metroTileSettingMassComment;
        private MetroFramework.Controls.MetroTile metroTileSettingMassLike;
        private MetroFramework.Controls.MetroTile metroTileSettingUnSubscribe;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTileClearLog;
        private MetroFramework.Controls.MetroTile metroTileSaveLog;
        private MetroFramework.Controls.MetroButton metroButtonStart;
        private MetroFramework.Controls.MetroButton metroButtonPause;
        private MetroFramework.Controls.MetroButton metroButtonStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxClearBots;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxMassDirect;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxMassComment;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxMassLike;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxUnSubscribe;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSubscribe;
        private MetroFramework.Controls.MetroTextBox metroTextBoxLog;
    }
}