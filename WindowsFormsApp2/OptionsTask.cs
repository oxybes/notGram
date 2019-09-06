using InstaBot.SettingsTask;
using InstaSharper.API;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Defender_Task;
using WindowsFormsApp2.Task;

namespace WindowsFormsApp2
{
    public partial class OptionsTask : MetroForm
    {
        private IInstaApi api;
        private Dictionary<string, ITask> dictionaryTask;
        private InfoDefenderTask infoDefenderTask;
        public OptionsTask(IInstaApi api, Dictionary<string, ITask> dictionaryTask)
        {
            InitializeComponent();
            this.api = api;
            this.dictionaryTask = dictionaryTask;
        }

        public OptionsTask(IInstaApi api, InfoDefenderTask infoDefenderTask)
        {
                InitializeComponent();
                this.api = api;
                this.infoDefenderTask = infoDefenderTask;
        }


        private void B_OpenFileBaseSubscribe_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            metroTextBoxFileNameBase.Text = filename;
        }

        private async void  MetroButtonApply_Click(object sender, EventArgs e)
        {
            if (metroTextBoxFileNameBase.Text.Length > 5)
            {
                SettingTaskSubscribe setting = new SettingTaskSubscribe();
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

                if (metroTextBoxPauseCount.Text.Length != 0)
                    setting.PauseLimit = Convert.ToInt32(metroTextBoxPauseCount.Text);
                else
                    setting.PauseLimit = 100;
                if (metroTextBoxPauseTime.Text.Length != 0)
                    setting.PauseTime = Convert.ToInt32(metroTextBoxPauseTime.Text);
                else
                    setting.PauseTime = 30;

                setting.LimitSubscribe = Convert.ToInt32(metroTextBoxLimit.Text);
                setting.ChekedSendPrivateUser = metroCheckBoxSendPrivate.Checked;

                if (infoDefenderTask == null)
                {
                    string username = (await api.GetCurrentUserAsync()).Value.UserName;
                    dictionaryTask[username] = new TaskSubscribe(api, setting);
                    dictionaryTask[username].Start();
                }
                else
                {
                    if (infoDefenderTask.OneTask == null)
                        infoDefenderTask.OneTask = new TaskSubscribe(infoDefenderTask.Api, setting);
                }

                Close();
            }
            else
            {
                MessageBox.Show("Введите путь до базы");
            }
        }

        private void MetroButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MetroButtonOpenFileUnSub_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            metroTextBoxFileNameBaseUnSubscribe.Text = filename;
        }

        private void MetroButtonOpenExceptionsFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string[] x = System.IO.File.ReadAllLines(filename);
            foreach (string str in x)
            {
                metroTextBoxeExceptions.Text += str + "\r\n";
            }
        }

        private void MetroButtonClearExceptions_Click(object sender, EventArgs e)
        {
            metroTextBoxeExceptions.Clear();
        }

        private async void MetroButton1_Click(object sender, EventArgs e)
        {
            SettingTaskUnSubscribe setting = new SettingTaskUnSubscribe();
            setting.CheckedPause = metroTogglePauseUnSub.Checked;
            setting.ChekedDeleteBaseAfterUnSubscribe = metroCheckBoxDeleteInBaseUnSub.Checked;
            setting.ChekedUnSubscribeBlock = metroCheckBoxUnSubscribeBlock.Checked;

            setting.FileNameBaseId = metroTextBoxFileNameBaseUnSubscribe.Text;
            setting.DelayMin = Convert.ToInt32(metroTextBoxDelayMinUnSub.Text);
            setting.DelayMax = Convert.ToInt32(metroTextBoxDelayMaxUnSub.Text);

            setting.FileNameDontUnSubscribeId = metroTextBoxeExceptions.Text;

            setting.LimitUnSubscribe = Convert.ToInt32(metroTextBoxLimitUnSub.Text);

            if (metroTextBoxPauseCountUnSub.Text.Length != 0)
                setting.PauseLimit = Convert.ToInt32(metroTextBoxPauseCountUnSub.Text);
            else
                setting.PauseLimit = 100;
            if (metroTextBoxPauseTimeUnSub.Text.Length != 0)
                setting.PauseTime = Convert.ToInt32(metroTextBoxPauseTimeUnSub.Text);
            else
                setting.PauseTime = 30;

            setting.WhatDoing = metroComboBoxWhatDoing.Text;

            //Thread t = new Thread(() => TaskInstaBot.UnSubscribe(api, setting));
            //t.Start();
            if (infoDefenderTask == null)
            {
                string username = (await api.GetCurrentUserAsync()).Value.UserName;
                dictionaryTask[username] = new TaskUnSubscribe(api, setting);
                dictionaryTask[username].Start();
            }
            else
            {
                if (infoDefenderTask.OneTask == null)
                    infoDefenderTask.OneTask = new TaskUnSubscribe(infoDefenderTask.Api, setting);
            }
            Close();
        }

        private void B_openFileLike_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            textBoxFileNameBaseLike.Text = filename;
        }

        private async void B_Apply_Like_Click(object sender, EventArgs e)
        {
            if (textBoxFileNameBaseLike.Text.Length > 5)
            {
                SettingTaskToList setting = new SettingTaskToList();

                setting.ChekedPause = metroTogglePauseLike.Checked;
                setting.ChekedSkipSubscriber = metroCheckBoxSkipSubscribeLike.Checked;
                setting.ChekedDeleteInBaseAfterLike = metroCheckBoxDeleteInBaseLike.Checked;

                setting.FileNameBase = textBoxFileNameBaseLike.Text;
                setting.DelayMin = Convert.ToUInt32(textBoxDelayMinLike.Text);
                setting.DelayMax = Convert.ToUInt32(textBoxDelayMaxLike.Text);

                setting.LikeUnderPublicMin = Convert.ToUInt32(metroTextBoxLikeUnderPublishMin.Text);
                setting.LikeUnderPublicMax = Convert.ToUInt32(metroTextBoxLikeUnderPublishMax.Text);

                setting.LikeAtUserMin = Convert.ToUInt32(metroTextBoxLikeAtUserMin.Text);
                setting.LikeAtUserMax = Convert.ToUInt32(metroTextBoxLikeAtUserMax.Text);

                if (textBoxPauseCountLike.Text.Length != 0)
                    setting.PauseLimit = Convert.ToUInt32(textBoxPauseCountLike.Text);
                else
                    setting.PauseLimit = 100;
                if (textBoxPauseTimeLike.Text.Length != 0)
                    setting.PauseTime = Convert.ToUInt32(textBoxPauseTimeLike.Text);
                else
                    setting.PauseTime = 30;

                if (infoDefenderTask == null)
                {
                    string username = (await api.GetCurrentUserAsync()).Value.UserName;
                    dictionaryTask[username] = new TaskMasslike(api, setting);
                    dictionaryTask[username].Start();
                }
                else
                {
                    if (infoDefenderTask.OneTask == null)
                        infoDefenderTask.OneTask = new TaskMasslike(infoDefenderTask.Api, setting);
                }

                Close();
            }
            else
            {
                MessageBox.Show("Введите путь до базы");
            }
        }

        private async void B_ApplyComment_Click(object sender, EventArgs e)
        {
            if (textBoxFileNameComment.Text.Length > 5)
            {
                SettingTaskComment setting = new SettingTaskComment();

                setting.FileNameBaseId = textBoxFileNameComment.Text;

                setting.DelayMin = Convert.ToInt32(tBox_DelayMin_Comment.Text);
                setting.DelayMax = Convert.ToInt32(tBox_DelayMax_Comment.Text);

                setting.DelayOneUserMin = Convert.ToInt32(metroTextBoxDelayUserMin.Text);
                setting.DelayOneUserMax = Convert.ToInt32(metroTextBoxDelayUserMax.Text);

                setting.CheckedPause = metroTogglePauseComment.Checked;

                if (tBox_PauseCount_Comment.Text.Length != 0)
                    setting.PauseLimit = Convert.ToInt32(tBox_PauseCount_Comment.Text);
                else
                    setting.PauseLimit = 100;
                if (tBox_PauseTime_Comment.Text.Length != 0)
                    setting.PauseTime = Convert.ToInt32(tBox_PauseTime_Comment);
                else
                    setting.PauseTime = 30;

                setting.ChekedDeleteBase = checkBox_DeleteInBase_Comment.Checked;

                setting.CommentCountMax = Convert.ToInt32(tBox_MaxComment_Comment.Text);
                setting.CountPublishComment = Convert.ToInt32(metroTextBoxCountPublish.Text);
                setting.CountCommnetUnderPublish = Convert.ToInt32(metroTextBoxCountCommentUnderPublish.Text);

                var x = metroTextBoxeComments.Text.Split('\n');
                setting.Message = x;

                if (infoDefenderTask == null)
                {
                    string username = (await api.GetCurrentUserAsync()).Value.UserName;
                    dictionaryTask[username] = new TaskMassComment(api, setting);
                    dictionaryTask[username].Start();
                }
                else
                {
                    if (infoDefenderTask.OneTask == null)
                        infoDefenderTask.OneTask = new TaskMassComment(infoDefenderTask.Api, setting);
                }

                Close();
            }
            else
            {
                MessageBox.Show("Укажите путь до базы");
            }
        }

        private async void B_Apply_Direct_Click(object sender, EventArgs e)
        {
            if (tBox_FileName_Direct.Text.Length > 5)
            {
                SettingTaskMassDirect setting = new SettingTaskMassDirect();

                setting.CheckedPause = toggle_Pause_Direct.Checked;
                setting.ChekedDeleteBase = checkBox_DeleteInBase_Direct.Checked;

                setting.DelayMin = Convert.ToInt32(tBox_DelayMin_Direct.Text);
                setting.DelayMax = Convert.ToInt32(tBox_DelayMax_Direct.Text);

                setting.FileNameBaseId = tBox_FileName_Direct.Text;
                if (tBox_PauseCount_Direct.Text.Length != 0)
                    setting.PauseLimit = Convert.ToInt32(tBox_PauseCount_Direct.Text);
                else
                    setting.PauseLimit = 100;
                if (tBox_PauseTime_Direct.Text.Length != 0)
                    setting.PauseTime = Convert.ToInt32(tBox_PauseTime_Direct.Text);
                else
                    setting.PauseTime = 30;

                string message = tBox_Messages_Direct.Text;
                message.Trim(' ');
                var x = message.Split('\n');
                var messageList = x.ToList<string>();
                setting.Messages = messageList;

                if (infoDefenderTask == null)
                {
                    string username = (await api.GetCurrentUserAsync()).Value.UserName;
                    dictionaryTask[username] = new TaskMassDirect(api, setting);
                    dictionaryTask[username].Start();
                }
                else
                {
                    if (infoDefenderTask.OneTask == null)
                        infoDefenderTask.OneTask = new TaskMassDirect(infoDefenderTask.Api, setting);
                }

                Close();
            }
            else
            {
                MessageBox.Show("Укажите путь до базы");
            }
        }

        private async void MetroButton15_Click(object sender, EventArgs e)
        {
            SettingTaskClearBots setting = new SettingTaskClearBots();

            setting.DelayMin = Convert.ToInt32(tBox_DelayMin_ClearBot.Text);
            setting.DelayMax = Convert.ToInt32(tBox_DelayMax_Direct.Text);

            setting.FileNameExceptionId = tBox_FileNameBase_ClearBot.Text;

            setting.ChekedPause = toggle_Pause_ClearBot.Checked;
            if (tBox_PauseCount_ClearBot.Text.Length != 0)
                setting.PauseLimit = Convert.ToInt32(tBox_PauseCount_ClearBot.Text);
            else
                setting.PauseLimit = 100;
            if (tBox_PauseTime_ClearBots.Text.Length != 0)
                setting.PauseTime = Convert.ToInt32(tBox_PauseTime_ClearBots.Text);
            else
                setting.PauseTime = 30;

            setting.LimitBlock = Convert.ToInt32(tBox_LimitCount_ClearBots.Text);

            setting.CheckedNoAvatarUser = metroCheckBoxNoAvatar.Checked;

            setting.CheckedPublicCountLess = metroCheckBoxPublishLess.Checked;
            setting.PublicCountLess = Convert.ToInt32(metroTextBoxPublishLess.Text);

            setting.ChekedFollowsCountLess = metroCheckBoxFollowersLess.Checked;
            setting.FollowsCountLess = Convert.ToInt32(metroTextBoxFollowersLess.Text);

            setting.ChekedSubscriptionsLess = metroCheckBoxSSubscriptionsLess.Checked;
            setting.SubscriptionsLess = Convert.ToInt32(metroTextBoxSubscriptionLess.Text);

            setting.ChekedSubscriptionsMore = metroCheckBoxSubscriptionsMore.Checked;
            setting.SubscriptionMore = Convert.ToInt32(metroTextBoxSubscriptionsMore.Text);

            setting.ChekedUserBlock = metroCheckBoxBlockUser.Checked;
            setting.WhomClear = metroComboBoxWhomClear.Text;


            if (infoDefenderTask == null)
            {
                string username = (await api.GetCurrentUserAsync()).Value.UserName;
                dictionaryTask[username] = new TaskClearBots(api, setting);
                dictionaryTask[username].Start();
            }
            else
            {
                if (infoDefenderTask.OneTask == null)
                    infoDefenderTask.OneTask = new TaskClearBots(infoDefenderTask.Api, setting);
            }
            Close();
        }

        private void B_openFile_Comment_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            textBoxFileNameComment.Text = filename;
        }

        private void MetroButtonOpenCommentsFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            var x = System.IO.File.ReadAllLines(filename);
            foreach (string str in x)
            {
                metroTextBoxeComments.Text += str + "\r\n";
            }
        }

        private void MetroButtonClearCommentsFile_Click(object sender, EventArgs e)
        {
            metroTextBoxeComments.Clear();
        }

        private void B_OpenFileBase_Direct_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            tBox_FileName_Direct.Text = filename;
        }

        private void B_OpenFileMessages_Direct_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            var x = System.IO.File.ReadAllLines(filename);
            foreach (string str in x)
            {
                tBox_Messages_Direct.Text += str + "\r\n";
            }
        }

        private void B_ClearMessages_Direct_Click(object sender, EventArgs e)
        {
            tBox_Messages_Direct.Clear();
        }

        private void B_OpenFileBase_ClearBot_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            tBox_FileNameBase_ClearBot.Text = filename;
        }

        private void TabPageSubscribe_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBoxPauseCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void OptionsTask_Load(object sender, EventArgs e)
        {

        }
    }
}
