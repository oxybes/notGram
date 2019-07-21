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
    public partial class SettingMassComment : MetroForm
    {
        SettingTaskComment setting;
        public SettingMassComment(SettingTaskComment setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void SettingMassComment_Load(object sender, EventArgs e)
        {

        }

        private void MetroButtonApply_Click(object sender, EventArgs e)
        {
            setting.FileNameBaseId = metroTextBoxFileNameBase.Text;

            setting.DelayMin = Convert.ToInt32(metroTextBoxDelayMin.Text);
            setting.DelayMax = Convert.ToInt32(metroTextBoxDelayMax.Text);

            setting.DelayOneUserMin = Convert.ToInt32(metroTextBoxDelayUserMin.Text);
            setting.DelayOneUserMax = Convert.ToInt32(metroTextBoxDelayUserMax.Text);

            setting.CheckedPause = metroTogglePause.Checked;
            setting.PauseLimit = Convert.ToInt32(metroTextBoxPauseCount.Text);
            setting.PauseTime = Convert.ToInt32(metroTextBoxPauseTime.Text);

            setting.ChekedDeleteBase = metroCheckBoxDeleteInBase.Checked;

            setting.CommentCountMax = Convert.ToInt32(metroTextBoxLimit.Text);
            setting.CountPublishComment = Convert.ToInt32(metroTextBoxCountPublish.Text);
            setting.CountCommnetUnderPublish = Convert.ToInt32(metroTextBoxCountCommentUnderPublish.Text);

            var x = metroTextBoxeComments.Text.Split('\n');
            setting.Message = x;
            Close();

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

        private void MetroButtonOpenFileBase_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            metroTextBoxFileNameBase.Text = filename;
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
