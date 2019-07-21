using MetroFramework.Forms;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstaBot.SettingsTask;

namespace WindowsFormsApp2
{
    public partial class SettingUnSubscribeForm : MetroForm
    {
        SettingTaskUnSubscribe setting;
        public SettingUnSubscribeForm(SettingTaskUnSubscribe setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void SettingUnSubscribeForm_Load(object sender, EventArgs e)
        {

        }

        private void MetroButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MetroButtonApply_Click(object sender, EventArgs e)
        {
            setting.CheckedPause = metroTogglePause.Checked;
            setting.ChekedDeleteBaseAfterUnSubscribe = metroCheckBoxDeleteInBase.Checked;
            setting.ChekedUnSubscribeBlock = metroCheckBoxUnSubscribeBlock.Checked;

            setting.FileNameBaseId = metroTextBoxFileNameBase.Text;
            setting.DelayMin = Convert.ToInt32(metroTextBoxDelayMin.Text);
            setting.DelayMax = Convert.ToInt32(metroTextBoxDelayMax.Text);

            setting.FileNameDontUnSubscribeId = metroTextBoxeExceptions.Text;

            setting.LimitUnSubscribe = Convert.ToInt32(metroTextBoxLimit.Text);
            setting.PauseLimit = Convert.ToInt32(metroTextBoxPauseCount.Text);
            setting.PauseTime = Convert.ToInt32(metroTextBoxPauseTime.Text);

            setting.WhatDoing = metroComboBoxWhatDoing.Text;

            Close();
        }

        private void MetroButtonOpenExceptionsFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string[] x = System.IO.File.ReadAllLines(filename);
            foreach (string str in x)
            {
                metroTextBoxeExceptions.Text += str + "\n";
            }
        }

        private void MetroButtonOpenFileBase_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            metroTextBoxFileNameBase.Text = filename;
        }

        private void MetroButtonClearExceptions_Click(object sender, EventArgs e)
        {
            metroTextBoxeExceptions.Clear();
        }
    }
}
