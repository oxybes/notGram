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
using InstaSharper.API;
using InstaBot.SettingsTask;
using InstaBot.Task;
using InstaBot;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class MainForm : MetroForm
    {
        IInstaApi api;

        SettingTaskToList settingTaskTolist;
        SettingTaskComment settingTaskComment;
        SettingTaskClearBots settingTaskClearBots;
        SettingTaskSubscribe settingTaskSubscribe;
        SettingTaskUnSubscribe settingTaskUnSubscribe;
        SettingTaskMassDirect settingTaskMassDirect;

        Thread MassLike;
        Thread Subscribe;
        Thread UnSubscribe;
        Thread ClearBots;
        Thread MassComment;
        Thread MassDirect;

        TaskMassSubscribe taskSubscribe;
        TaskMassUnSubscribe taskUnSubscribe;
        TaskMassComment taskMassComment;
        TaskMassDirect taskMassDirect;
        TaskClearOfBots taskClearBots;
        TaskLikingToList taskMassLike;

        bool Stop, Pause;


        public MainForm(IInstaApi api)
        {
            InitializeComponent();
            this.api = api;
            settingTaskTolist = new SettingTaskToList();
            settingTaskComment = new SettingTaskComment();
            settingTaskClearBots = new SettingTaskClearBots();
            settingTaskSubscribe = new SettingTaskSubscribe();
            settingTaskUnSubscribe = new SettingTaskUnSubscribe();
            settingTaskMassDirect = new SettingTaskMassDirect();


            Pause = false;
            Stop = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
            
        private void MetroTile1_Click(object sender, EventArgs e)
        {
            SettingSubscribeForm form = new SettingSubscribeForm(settingTaskSubscribe);
            form.Show();
        }

        private void MetroTile2_Click(object sender, EventArgs e)
        {
            SettingUnSubscribeForm form = new SettingUnSubscribeForm(settingTaskUnSubscribe);
            form.Show();
        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {
            SettingMassLikeForm form = new SettingMassLikeForm(settingTaskTolist);
            form.Show();
        }

        private void MetroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MetroTileSettingMassComment_Click(object sender, EventArgs e)
        {
            SettingMassComment form = new SettingMassComment(settingTaskComment);
            form.Show();
        }

        private void MetroTileSettingMassDirect_Click(object sender, EventArgs e)
        {
            SettingMassDirect form = new SettingMassDirect(settingTaskMassDirect);
            form.Show();
        }

        private void MetroTileSettingClearBots_Click(object sender, EventArgs e)
        {
            SettingClearBotsForm form = new SettingClearBotsForm(settingTaskClearBots);
            form.Show();
        }

        #region Start
        void StartTaskingToList()
        {
            taskMassLike = new TaskLikingToList(api, settingTaskTolist);
            taskMassLike.EventFromMyClass += LogAdd;
            taskMassLike.Start();
        }

        void StartTaskingMassSubscribing()
        {
            taskSubscribe = new TaskMassSubscribe(api, settingTaskSubscribe);
            taskSubscribe.EventFromMyClass += LogAdd;
            taskSubscribe.Start();
        }

        void StartTaskingMassUnSubscribe()
        {
            taskUnSubscribe = new TaskMassUnSubscribe(api, settingTaskUnSubscribe);
            taskUnSubscribe.EventFromMyClass += LogAdd;
            taskUnSubscribe.Start();
        }

        void StartClearingOfBots()
        {
            taskClearBots = new TaskClearOfBots(api, settingTaskClearBots);
            taskClearBots.EventFromMyClass += LogAdd;
            taskClearBots.Start();
        }

        void StartMassComment()
        {
            taskMassComment = new TaskMassComment(api, settingTaskComment);
            taskMassComment.EventFromMyClass += LogAdd;
            taskMassComment.Start();
        }

        void StartMassDirect()
            {
                taskMassDirect = new TaskMassDirect(api, settingTaskMassDirect);
                taskMassDirect.EventFromMyClass += LogAdd;
                taskMassDirect.Start();
            }
        #endregion
        private void MetroButtonStop_Click(object sender, EventArgs e)
        {
            Stop = true;
            metroButtonPause.Enabled = false;
            metroButtonStart.Enabled = true;

            if (metroCheckBoxMassLike.Checked && taskMassLike != null)
            {
                metroCheckBoxMassLike.Enabled = true;
                taskMassLike.Stop();
            }
            if (metroCheckBoxSubscribe.Checked && taskSubscribe != null)
            {
                metroCheckBoxSubscribe.Enabled = true;
                taskSubscribe.Stop();
            }
            if (metroCheckBoxUnSubscribe.Checked && taskUnSubscribe != null)
            {
                metroCheckBoxUnSubscribe.Enabled = true;
                taskUnSubscribe.Stop();
            }
            if (metroCheckBoxMassDirect.Checked && taskMassDirect != null)
            {
                metroCheckBoxMassDirect.Enabled = true;
                taskMassDirect.Stop();
            }
            if (metroCheckBoxMassComment.Checked && taskMassComment != null)
            {
                metroCheckBoxMassComment.Enabled = true;
                taskMassComment.Stop();
            }
            if (metroCheckBoxClearBots.Checked && taskClearBots != null)
            {
                metroCheckBoxClearBots.Enabled = true;
                taskClearBots.Stop();
            }
        }

        private void MetroButtonPause_Click(object sender, EventArgs e)
        {
            if (metroCheckBoxMassLike.Checked)
            {
                taskMassLike.Pause();
            }
            if (metroCheckBoxSubscribe.Checked)
            {
                taskSubscribe.Pause();
            }
            if (metroCheckBoxUnSubscribe.Checked)
            {
                taskUnSubscribe.Pause();
            }
            if (metroCheckBoxMassDirect.Checked)
            {
                taskMassDirect.Pause();
            }
            if (metroCheckBoxMassComment.Checked)
            {
                taskMassComment.Pause();
            }
            if (metroCheckBoxClearBots.Checked)
            {
                taskClearBots.Pause();
            }

            Pause = true;
            metroButtonStop.Enabled = false;
            metroButtonStart.Enabled = true;
        }

        public void LogAdd(object sender, MyEventMessage e)
        {
            metroTextBoxLog.Invoke((Action)delegate
            {
                metroTextBoxLog.Text += e.Message + "\n";
            });
        }

        private void MetroButtonStart_Click(object sender, EventArgs e)
        {
            if (Stop)
            {
                metroButtonStop.Enabled = metroButtonPause.Enabled = true;
                metroButtonStart.Enabled = false;
                Stop = false;

                if (metroCheckBoxMassLike.Checked)
                {
                    MassLike = new Thread(StartTaskingToList);
                    metroCheckBoxMassLike.Enabled = false;
                    MassLike.Start();

                }
                if (metroCheckBoxSubscribe.Checked)
                {
                    Subscribe = new Thread(StartTaskingMassSubscribing);
                    metroCheckBoxSubscribe.Enabled = false;
                    Subscribe.Start();

                }
                if (metroCheckBoxUnSubscribe.Checked)
                {
                    UnSubscribe = new Thread(StartTaskingMassUnSubscribe);
                    metroCheckBoxUnSubscribe.Enabled = false;
                    UnSubscribe.Start();

                }
                if (metroCheckBoxMassDirect.Checked)
                {
                    MassDirect = new Thread(StartMassDirect);
                    metroCheckBoxMassDirect.Enabled = false;
                    MassDirect.Start();

                }
                if (metroCheckBoxMassComment.Checked)
                {
                    MassComment = new Thread(StartMassComment);
                    metroCheckBoxMassComment.Enabled = false;
                    MassComment.Start();

                }
                if (metroCheckBoxClearBots.Checked)
                {
                    ClearBots = new Thread(StartClearingOfBots);
                    metroCheckBoxClearBots.Enabled = false;
                    ClearBots.Start();
                }
            }
            else
            {
                if (metroCheckBoxMassLike.Checked)
                {
                    taskMassLike.Resume();
                }
                if (metroCheckBoxSubscribe.Checked)
                {
                    taskSubscribe.Resume();
                }
                if (metroCheckBoxUnSubscribe.Checked)
                {
                    taskUnSubscribe.Resume();
                }
                if (metroCheckBoxMassDirect.Checked)
                {
                    taskMassDirect.Resume();
                }
                if (metroCheckBoxMassComment.Checked)
                {
                    taskMassComment.Resume();
                }
                if (metroCheckBoxClearBots.Checked)
                {
                    taskClearBots.Resume();
                }
                metroButtonStop.Enabled = true;
            }
        }
    }
}
