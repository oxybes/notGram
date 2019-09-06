namespace WindowsFormsApp2.Forms
{
    partial class AddPostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPostForm));
            this.cmBox_Acc = new MetroFramework.Controls.MetroComboBox();
            this.post_tBox_RoadImage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tBox_Message = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTimePost = new MetroFramework.Controls.MetroDateTime();
            this.post_b_AddPost = new MetroFramework.Controls.MetroButton();
            this.cmBox_WhatPost = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tBox_Preview = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // cmBox_Acc
            // 
            this.cmBox_Acc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cmBox_Acc.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmBox_Acc.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmBox_Acc.FormattingEnabled = true;
            this.cmBox_Acc.ItemHeight = 19;
            this.cmBox_Acc.Location = new System.Drawing.Point(23, 63);
            this.cmBox_Acc.Name = "cmBox_Acc";
            this.cmBox_Acc.PromptText = "Выберите аккаунт";
            this.cmBox_Acc.Size = new System.Drawing.Size(291, 25);
            this.cmBox_Acc.Style = MetroFramework.MetroColorStyle.Orange;
            this.cmBox_Acc.TabIndex = 0;
            this.cmBox_Acc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmBox_Acc.UseCustomBackColor = true;
            this.cmBox_Acc.UseSelectable = true;
            this.cmBox_Acc.UseStyleColors = true;
            // 
            // post_tBox_RoadImage
            // 
            // 
            // 
            // 
            this.post_tBox_RoadImage.CustomButton.Image = global::WindowsFormsApp2.Properties.Resources.plus_icon_91546__1_;
            this.post_tBox_RoadImage.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.post_tBox_RoadImage.CustomButton.Name = "";
            this.post_tBox_RoadImage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.post_tBox_RoadImage.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.post_tBox_RoadImage.CustomButton.TabIndex = 1;
            this.post_tBox_RoadImage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.post_tBox_RoadImage.CustomButton.UseMnemonic = false;
            this.post_tBox_RoadImage.CustomButton.UseSelectable = true;
            this.post_tBox_RoadImage.CustomButton.UseVisualStyleBackColor = false;
            this.post_tBox_RoadImage.Lines = new string[0];
            this.post_tBox_RoadImage.Location = new System.Drawing.Point(23, 144);
            this.post_tBox_RoadImage.MaxLength = 32767;
            this.post_tBox_RoadImage.Name = "post_tBox_RoadImage";
            this.post_tBox_RoadImage.PasswordChar = '\0';
            this.post_tBox_RoadImage.ReadOnly = true;
            this.post_tBox_RoadImage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.post_tBox_RoadImage.SelectedText = "";
            this.post_tBox_RoadImage.SelectionLength = 0;
            this.post_tBox_RoadImage.SelectionStart = 0;
            this.post_tBox_RoadImage.ShortcutsEnabled = true;
            this.post_tBox_RoadImage.ShowButton = true;
            this.post_tBox_RoadImage.Size = new System.Drawing.Size(291, 23);
            this.post_tBox_RoadImage.Style = MetroFramework.MetroColorStyle.Orange;
            this.post_tBox_RoadImage.TabIndex = 1;
            this.post_tBox_RoadImage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.post_tBox_RoadImage.UseCustomBackColor = true;
            this.post_tBox_RoadImage.UseSelectable = true;
            this.post_tBox_RoadImage.UseStyleColors = true;
            this.post_tBox_RoadImage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.post_tBox_RoadImage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(260, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Укажите путь до фото(Можно несколько)";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tBox_Message
            // 
            // 
            // 
            // 
            this.tBox_Message.CustomButton.Image = null;
            this.tBox_Message.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.tBox_Message.CustomButton.Name = "";
            this.tBox_Message.CustomButton.Size = new System.Drawing.Size(153, 153);
            this.tBox_Message.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBox_Message.CustomButton.TabIndex = 1;
            this.tBox_Message.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBox_Message.CustomButton.UseSelectable = true;
            this.tBox_Message.CustomButton.Visible = false;
            this.tBox_Message.Lines = new string[0];
            this.tBox_Message.Location = new System.Drawing.Point(23, 240);
            this.tBox_Message.MaxLength = 32767;
            this.tBox_Message.Multiline = true;
            this.tBox_Message.Name = "tBox_Message";
            this.tBox_Message.PasswordChar = '\0';
            this.tBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_Message.SelectedText = "";
            this.tBox_Message.SelectionLength = 0;
            this.tBox_Message.SelectionStart = 0;
            this.tBox_Message.ShortcutsEnabled = true;
            this.tBox_Message.Size = new System.Drawing.Size(291, 155);
            this.tBox_Message.Style = MetroFramework.MetroColorStyle.Orange;
            this.tBox_Message.TabIndex = 3;
            this.tBox_Message.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tBox_Message.UseSelectable = true;
            this.tBox_Message.UseStyleColors = true;
            this.tBox_Message.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_Message.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 218);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Сообщение";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroDateTimePost
            // 
            this.metroDateTimePost.CustomFormat = "dd.MM.yyyy HH:mm";
            this.metroDateTimePost.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTimePost.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.metroDateTimePost.Location = new System.Drawing.Point(23, 401);
            this.metroDateTimePost.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTimePost.Name = "metroDateTimePost";
            this.metroDateTimePost.Size = new System.Drawing.Size(291, 25);
            this.metroDateTimePost.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroDateTimePost.TabIndex = 5;
            this.metroDateTimePost.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroDateTimePost.UseStyleColors = true;
            // 
            // post_b_AddPost
            // 
            this.post_b_AddPost.Location = new System.Drawing.Point(23, 432);
            this.post_b_AddPost.Name = "post_b_AddPost";
            this.post_b_AddPost.Size = new System.Drawing.Size(291, 29);
            this.post_b_AddPost.Style = MetroFramework.MetroColorStyle.Orange;
            this.post_b_AddPost.TabIndex = 6;
            this.post_b_AddPost.Text = "Добавить пост";
            this.post_b_AddPost.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.post_b_AddPost.UseCustomBackColor = true;
            this.post_b_AddPost.UseSelectable = true;
            this.post_b_AddPost.UseStyleColors = true;
            this.post_b_AddPost.Click += new System.EventHandler(this.Post_b_AddPost_Click);
            // 
            // cmBox_WhatPost
            // 
            this.cmBox_WhatPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.cmBox_WhatPost.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmBox_WhatPost.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmBox_WhatPost.FormattingEnabled = true;
            this.cmBox_WhatPost.ItemHeight = 19;
            this.cmBox_WhatPost.Items.AddRange(new object[] {
            "Фото",
            "Видео",
            "История"});
            this.cmBox_WhatPost.Location = new System.Drawing.Point(23, 94);
            this.cmBox_WhatPost.Name = "cmBox_WhatPost";
            this.cmBox_WhatPost.PromptText = "Что постить?";
            this.cmBox_WhatPost.Size = new System.Drawing.Size(291, 25);
            this.cmBox_WhatPost.Style = MetroFramework.MetroColorStyle.Orange;
            this.cmBox_WhatPost.TabIndex = 7;
            this.cmBox_WhatPost.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmBox_WhatPost.UseCustomBackColor = true;
            this.cmBox_WhatPost.UseSelectable = true;
            this.cmBox_WhatPost.UseStyleColors = true;
            this.cmBox_WhatPost.SelectedIndexChanged += new System.EventHandler(this.CmBox_WhatPost_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(158, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Укажите путь до превью";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tBox_Preview
            // 
            // 
            // 
            // 
            this.tBox_Preview.CustomButton.Image = global::WindowsFormsApp2.Properties.Resources.plus_icon_91546__1_;
            this.tBox_Preview.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.tBox_Preview.CustomButton.Name = "";
            this.tBox_Preview.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tBox_Preview.CustomButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.tBox_Preview.CustomButton.TabIndex = 1;
            this.tBox_Preview.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tBox_Preview.CustomButton.UseMnemonic = false;
            this.tBox_Preview.CustomButton.UseSelectable = true;
            this.tBox_Preview.CustomButton.UseVisualStyleBackColor = false;
            this.tBox_Preview.Lines = new string[0];
            this.tBox_Preview.Location = new System.Drawing.Point(23, 192);
            this.tBox_Preview.MaxLength = 32767;
            this.tBox_Preview.Name = "tBox_Preview";
            this.tBox_Preview.PasswordChar = '\0';
            this.tBox_Preview.ReadOnly = true;
            this.tBox_Preview.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBox_Preview.SelectedText = "";
            this.tBox_Preview.SelectionLength = 0;
            this.tBox_Preview.SelectionStart = 0;
            this.tBox_Preview.ShortcutsEnabled = true;
            this.tBox_Preview.ShowButton = true;
            this.tBox_Preview.Size = new System.Drawing.Size(291, 23);
            this.tBox_Preview.Style = MetroFramework.MetroColorStyle.Orange;
            this.tBox_Preview.TabIndex = 8;
            this.tBox_Preview.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tBox_Preview.UseCustomBackColor = true;
            this.tBox_Preview.UseSelectable = true;
            this.tBox_Preview.UseStyleColors = true;
            this.tBox_Preview.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBox_Preview.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 473);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tBox_Preview);
            this.Controls.Add(this.cmBox_WhatPost);
            this.Controls.Add(this.post_b_AddPost);
            this.Controls.Add(this.metroDateTimePost);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tBox_Message);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.post_tBox_RoadImage);
            this.Controls.Add(this.cmBox_Acc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPostForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Добавление поста";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddPostForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmBox_Acc;
        private MetroFramework.Controls.MetroTextBox post_tBox_RoadImage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tBox_Message;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime metroDateTimePost;
        private MetroFramework.Controls.MetroButton post_b_AddPost;
        private MetroFramework.Controls.MetroComboBox cmBox_WhatPost;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tBox_Preview;
    }
}