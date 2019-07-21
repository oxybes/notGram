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
    public partial class SettingSubscribeForm : MetroForm
    {
        SettingTaskSubscribe setting;
        public SettingSubscribeForm(SettingTaskSubscribe setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void SettingSubscribe_Load(object sender, EventArgs e)
        {

        }

        private void ModalNumericUpDown1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MetroButtonOpenFileBase_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            metroTextBoxFileNameBase.Text = filename;
        }

        private void MetroButtonApply_Click(object sender, EventArgs e)
        {
            setting.ChekedPause = metroTogglePause.Checked;
            setting.ChekedSkipSubscriber = metroCheckBoxSkipFollowers.Checked;
            setting.ChekedDeleteAdfter = metroCheckBoxDeleteInBase.Checked;

            setting.FileNameBaseId = metroTextBoxFileNameBase.Text;
            setting.DelayMin = Convert.ToInt32(metroTextBoxDelayMin.Text);
            setting.DelayMax = Convert.ToInt32(metroTextBoxDelayMax.Text);

            setting.DelayLikeMin = Convert.ToInt32(metroTextBoxDelayLikeMin.Text);
            setting.DelayLikeMax = Convert.ToInt32(metroTextBoxDelayLikeMax.Text);

            setting.ChekedLikingBySubscribe = metroToggleLike.Checked;
            setting.LikingMin = Convert.ToInt32(metroTextBoxCountLikeMin.Text);
            setting.LikingMax = Convert.ToInt32(metroTextBoxCountLikeMax.Text);

            setting.PauseLimit = Convert.ToInt32(metroTextBoxPauseCount.Text);
            setting.PauseTime = Convert.ToInt32(metroTextBoxPauseTime.Text);

            setting.LimitSubscribe = Convert.ToInt32(metroTextBoxLimit.Text);
            setting.ChekedSendPrivateUser = metroCheckBoxSendPrivate.Checked;

            this.Close();
        }
    }
}
