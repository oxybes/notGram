namespace WindowsFormsApp2.Forms
{
    partial class AddPlansForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlansForm));
            this.cmBox_Acc = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.b_TaskOne = new MetroFramework.Controls.MetroButton();
            this.b_CancelTaskOne = new MetroFramework.Controls.MetroButton();
            this.dateTimePlans = new MetroFramework.Controls.MetroDateTime();
            this.b_Apply = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
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
            this.cmBox_Acc.Size = new System.Drawing.Size(292, 25);
            this.cmBox_Acc.Style = MetroFramework.MetroColorStyle.Orange;
            this.cmBox_Acc.TabIndex = 1;
            this.cmBox_Acc.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmBox_Acc.UseCustomBackColor = true;
            this.cmBox_Acc.UseSelectable = true;
            this.cmBox_Acc.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Задание";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // b_TaskOne
            // 
            this.b_TaskOne.Location = new System.Drawing.Point(23, 113);
            this.b_TaskOne.Name = "b_TaskOne";
            this.b_TaskOne.Size = new System.Drawing.Size(185, 23);
            this.b_TaskOne.Style = MetroFramework.MetroColorStyle.Orange;
            this.b_TaskOne.TabIndex = 3;
            this.b_TaskOne.Text = "Выбрать задание";
            this.b_TaskOne.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_TaskOne.UseCustomBackColor = true;
            this.b_TaskOne.UseSelectable = true;
            this.b_TaskOne.Click += new System.EventHandler(this.B_TaskOne_Click);
            // 
            // b_CancelTaskOne
            // 
            this.b_CancelTaskOne.Location = new System.Drawing.Point(214, 113);
            this.b_CancelTaskOne.Name = "b_CancelTaskOne";
            this.b_CancelTaskOne.Size = new System.Drawing.Size(101, 23);
            this.b_CancelTaskOne.Style = MetroFramework.MetroColorStyle.Orange;
            this.b_CancelTaskOne.TabIndex = 4;
            this.b_CancelTaskOne.Text = "Отмена";
            this.b_CancelTaskOne.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_CancelTaskOne.UseCustomBackColor = true;
            this.b_CancelTaskOne.UseSelectable = true;
            this.b_CancelTaskOne.Click += new System.EventHandler(this.B_CancelTaskOne_Click);
            // 
            // dateTimePlans
            // 
            this.dateTimePlans.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePlans.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dateTimePlans.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePlans.Location = new System.Drawing.Point(23, 161);
            this.dateTimePlans.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTimePlans.Name = "dateTimePlans";
            this.dateTimePlans.Size = new System.Drawing.Size(289, 25);
            this.dateTimePlans.Style = MetroFramework.MetroColorStyle.Orange;
            this.dateTimePlans.TabIndex = 10;
            this.dateTimePlans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dateTimePlans.UseStyleColors = true;
            // 
            // b_Apply
            // 
            this.b_Apply.Location = new System.Drawing.Point(23, 192);
            this.b_Apply.Name = "b_Apply";
            this.b_Apply.Size = new System.Drawing.Size(288, 23);
            this.b_Apply.Style = MetroFramework.MetroColorStyle.Orange;
            this.b_Apply.TabIndex = 11;
            this.b_Apply.Text = "Запланировать";
            this.b_Apply.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.b_Apply.UseCustomBackColor = true;
            this.b_Apply.UseSelectable = true;
            this.b_Apply.Click += new System.EventHandler(this.B_Apply_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(21, 139);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Дата";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(210, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(0, 0);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AddPlansForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 232);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.b_Apply);
            this.Controls.Add(this.dateTimePlans);
            this.Controls.Add(this.b_CancelTaskOne);
            this.Controls.Add(this.b_TaskOne);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmBox_Acc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPlansForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Планировка заданий";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddPlansForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmBox_Acc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton b_TaskOne;
        private MetroFramework.Controls.MetroButton b_CancelTaskOne;
        private MetroFramework.Controls.MetroDateTime dateTimePlans;
        private MetroFramework.Controls.MetroButton b_Apply;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}