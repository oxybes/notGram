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
    public partial class SettingClearBotsForm : MetroForm
    {
        SettingTaskClearBots setting;
        
        public SettingClearBotsForm(SettingTaskClearBots setting)
        {
            InitializeComponent();
            this.setting = setting;
        }

        private void SettingClearBotsForm_Load(object sender, EventArgs e)
        {

        }

        private void MetroButtonApply_Click(object sender, EventArgs e)
        {
            setting.DelayMin = Convert.ToInt32(metroTextBoxDelayMin.Text);
            setting.DelayMax = Convert.ToInt32(metroTextBoxDelayMax.Text);

            setting.FileNameExceptionId = metroTextBoxFileNameBase.Text;

            setting.ChekedPause = metroTogglePause.Checked;
            setting.PauseLimit = Convert.ToInt32(metroTextBoxPauseCount.Text);
            setting.PauseTime = Convert.ToInt32(metroTextBoxPauseTime.Text);

            setting.LimitBlock = Convert.ToInt32(metroTextBoxLimit.Text);

            setting.CheckedNoAvatarUser = metroCheckBoxNoAvatar.Checked;

            setting.CheckedPublicCountLess =  metroCheckBoxPublishLess.Checked;
            setting.PublicCountLess = Convert.ToInt32(metroTextBoxPublishLess.Text);

            setting.ChekedFollowsCountLess = metroCheckBoxFollowersLess.Checked;
            setting.FollowsCountLess = Convert.ToInt32(metroTextBoxFollowersLess.Text);

            setting.ChekedSubscriptionsLess = metroCheckBoxSSubscriptionsLess.Checked;
            setting.SubscriptionsLess = Convert.ToInt32(metroTextBoxSubscriptionLess.Text);

            setting.ChekedSubscriptionsMore = metroCheckBoxSubscriptionsMore.Checked;
            setting.SubscriptionMore = Convert.ToInt32(metroTextBoxSubscriptionsMore.Text);

            setting.ChekedUserBlock = metroCheckBoxBlockUser.Checked;
            setting.WhomClear = metroComboBoxWhomClear.Text;

            Close();
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
