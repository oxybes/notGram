using MetroFramework.Forms;
using System;
using MetroFramework;
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
    public partial class SettingMassDirect : MetroForm
    {
        SettingTaskMassDirect setting;
        public SettingMassDirect(SettingTaskMassDirect setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void SettingMassDirect_Load(object sender, EventArgs e)
        {

        }

        private void MetroButtonApply_Click(object sender, EventArgs e)
        {
            setting.CheckedPause = metroTogglePause.Checked;
            setting.ChekedDeleteBase = metroCheckBoxDeleteInBase.Checked;

            setting.DelayMin = Convert.ToInt32(metroTextBoxDelayMin.Text);
            setting.DelayMax = Convert.ToInt32(metroTextBoxDelayMax.Text);
            setting.FileNameBaseId = metroTextBoxFileNameBase.Text;
            setting.PauseLimit = Convert.ToInt32(metroTextBoxPauseCount.Text);
            setting.PauseTime = Convert.ToInt32(metroTextBoxPauseTime.Text);

            string message = metroTextBoxeComments.Text;
            message.Trim(' ');
            var x = message.Split('\n');
            var messageList = x.ToList<string>();
            setting.Messages = messageList;
            Close();
        }

        private void MetroButtonOpenFileBase_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            metroTextBoxFileNameBase.Text = filename;
        }

        private void MetroButtonOpenCommentsFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            var x = System.IO.File.ReadAllLines(filename);
            foreach (string str in x)
            {
                metroTextBoxeComments.Text += str + "\n";
            }
        }

        private void MetroButtonClearCommentsFile_Click(object sender, EventArgs e)
        {
            metroTextBoxeComments.Clear();
        }

        private void MetroButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
