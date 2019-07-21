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
    public partial class SettingMassLikeForm : MetroForm
    {
        SettingTaskToList setting;
        public SettingMassLikeForm(SettingTaskToList setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void SettingMassLikeForm_Load(object sender, EventArgs e)
        {

        }

        private void MetroButtonApply_Click(object sender, EventArgs e)
        {
            setting.ChekedPause = metroTogglePause.Checked;
            setting.ChekedSkipSubscriber = metroCheckBoxSkipFollowers.Checked;
            setting.ChekedDeleteInBaseAfterLike = metroCheckBoxDeleteInBase.Checked;

            setting.FileNameBase = metroTextBoxFileNameBase.Text;
            setting.DelayMin = Convert.ToUInt32(metroTextBoxDelayMin.Text);
            setting.DelayMax = Convert.ToUInt32(metroTextBoxDelayMax.Text);

            setting.LikeUnderPublicMin = Convert.ToUInt32(metroTextBoxLikeUnderPublishMin.Text);
            setting.LikeUnderPublicMax = Convert.ToUInt32(metroTextBoxLikeUnderPublishMax.Text);

            setting.LikeAtUserMin = Convert.ToUInt32(metroTextBoxLikeAtUserMin.Text);
            setting.LikeAtUserMax = Convert.ToUInt32(metroTextBoxLikeAtUserMax.Text);

            setting.PauseLimit = Convert.ToUInt32(metroTextBoxPauseCount.Text);
            setting.PauseTime = Convert.ToUInt32(metroTextBoxPauseTime.Text);

            this.Close();

        }

        private void MetroButtonOpenFileBase_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            metroTextBoxFileNameBase.Text = filename;
        }

        private void MetroButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
