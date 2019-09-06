using InstaBot;
using InstaSharper.API;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp2.Audience;
using WindowsFormsApp2.Audience.Statistics;
using WindowsFormsApp2.Audience.Task;
using WindowsFormsApp2.Defender_Task;
using WindowsFormsApp2.Deferred_Posting;
using WindowsFormsApp2.Forms;
using WindowsFormsApp2.SettingsTask;
using WindowsFormsApp2.Task;

namespace WindowsFormsApp2
{
    public partial class MainForm : MetroForm
    {
        List<IInstaApi> listApi;
        BindingList<AccountInfo> data = new BindingList<AccountInfo>();
        private string fullLog;
        Dictionary<string, ITask> dictionaryTask;
        Dictionary<int, IPost> dictionaryAutoPost;
        private List<DefenderTask> listDefenderTask = new List<DefenderTask>();
        List<IAudienceTask> listAudienceTasks = new List<IAudienceTask>();

        public MainForm(List<IInstaApi> listApi)
        {
            InitializeComponent();
            this.listApi = listApi;
            fullLog = "";
            dictionaryTask = new Dictionary<string, ITask>();
            dictionaryAutoPost = new Dictionary<int, IPost>();

            DefenderTask.EventUpdateGrid += UpdateGridTaskPlans;

            AutoPostUploadHistory.EventUpdateGrid += UpdateGridAutoPost;
            AutoPostUploadPhoto.EventUpdateGrid += UpdateGridAutoPost;
            AutoPostUploadVideo.EventUpdateGrid += UpdateGridAutoPost;

            metroTabControl.SelectedIndex = 0;

            TaskSubscribe.EventFromMyClass += LogAdd;
            TaskSubscribe.EventUpdateGrid += UpdateGrid;

            TaskUnSubscribe.EventFromMyClass += LogAdd;
            TaskUnSubscribe.EventUpdateGrid += UpdateGrid;

            TaskMasslike.EventFromMyClass += LogAdd;
            TaskMasslike.EventUpdateGrid += UpdateGrid;

            TaskMassComment.EventFromMyClass += LogAdd;
            TaskMassComment.EventUpdateGrid += UpdateGrid;

            TaskMassDirect.EventFromMyClass += LogAdd;
            TaskMassDirect.EventUpdateGrid += UpdateGrid;

            TaskClearBots.EventFromMyClass += LogAdd;
            TaskClearBots.EventUpdateGrid += UpdateGrid;

            tBox_DeleteDubble_Original.ButtonClick += tBox_DeleteDouble_Original_BClick;
            tBox_DeleteDubble_Save.ButtonClick += tBox_DeleteDouble_Save_BClick;
            tBox_Convert_Original.ButtonClick += tBox_Convert_Original_BClick;
            tBox_Convert_Save.ButtonClick += tBox_Convert_Save_BClick;
            tBox_Filter_FileBaseId.ButtonClick += tBox_Filter_FileId_BClick;
            tBox_Filter_SaveFileId.ButtonClick += tBox_Filter_SaveFileId_BClick;
            tBox_HashTag_SaveFile.ButtonClick += tBox_HashTag_SaveFile_BClick;
            tBox_SborAcc_SaveFile.ButtonClick += tBox_SborAcc_SaveFile_BClick;

            AudienceDeleteDuplicatesTask.EventUpdateGrid += UpdateGridAudience;
            AudienceConvert.EventUpdateGrid += UpdateGridAudience;
            AudienceSborLogin.EventUpdateGrid += UpdateGridAudience;
            AudienceHashTagsSbor.EventUpdateGrid += UpdateGridAudience;
            AudienceFilterTask.EventUpdateGrid += UpdateGridAudience;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (listApi != null &&  listApi.Count != 0)
            {
                List<int> badIndex = new List<int>();
                for (int i = 0; i < listApi.Count; i++)
                {
                    try
                    {
                        var userInfo = await listApi[i].GetCurrentUserAsync();
                        var userInfoFull = await listApi[i].GetUserInfoByIdAsync(userInfo.Value.Pk);
                        string login = userInfo.Value.UserName;
                        string task = "-";
                        string progress = "-";
                        string subscriptions = Convert.ToString(userInfoFull.Value.FollowingCount);
                        string subscribers = Convert.ToString(userInfoFull.Value.FollowerCount);
                        string publish = Convert.ToString(userInfoFull.Value.MediaCount);
                        string status;
                        if (listApi[i].IsUserAuthenticated)
                            status = "Good";
                        else
                            status = "Bad";
                        data.Add(new AccountInfo(login, task, progress, subscriptions, subscribers, publish, status));

                        comboBoxAccounts.Items.Add(userInfo.Value.UserName);
                        comboBoxAccounts.SelectedItem = comboBoxAccounts.Items[0];

                        cmBox_Settings_Acc.Items.Add(userInfo.Value.UserName);
                        cmBox_Settings_Acc.SelectedItem = comboBoxAccounts.Items[0];
                    }
                    catch
                    {
                        badIndex.Add(i);
                        continue;
                    }
                }

                foreach (int bad in badIndex)
                {
                    listApi.Remove(listApi[bad]);
                }
            }

            if (comboBoxAccounts.Items.Count > 0)
            {
                comboBoxAccounts.SelectedItem = comboBoxAccounts.Items[0];

            }
            metroGrid.DataSource = data;
            cmBoxSBorAcc_WhatAcc.SelectedIndex = 0;
            cmBoxSborAcc_Format.SelectedIndex = 0;
            cmBox_Convert_OldWhatPars.SelectedIndex = 0;
            cmBox_Convert_NewWhatPars.SelectedIndex = 1;
            cmBox_HastagsFormat.SelectedIndex = 0;
            cmBox_HashTag_TypePublish.SelectedIndex = 0;
            cmBox_Filter_WhatAccPars.SelectedIndex = 0;
        }
            
        

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        #region Задачи
        private void UpdateGrid(object sender, UpdateGridEvent e)
        {
            var x = e.Message.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            string task = x[1];
            string progress = x[2];
            string subscriptions = x[3];
            string subscribers = x[4];
            string publish = x[5];
            string status = x[6];

            int index = -1;
            foreach (var acc in data)
            {
                if (acc.Login == x[0])
                    index = data.IndexOf(acc);
            }

            if (index != -1)
            {
                metroGrid.Invoke((Action)delegate
                {
                    data[index].Task = task;
                    data[index].Progress = progress;
                    data[index].Subscriptions = subscriptions;
                    data[index].Subscribers = subscribers;
                    data[index].Publish = publish;
                    data[index].Status = status;
                    metroGrid.Refresh();
                    UpdateButton();
                });
            }
        }

        private async void B_AddTask_Click(object sender, EventArgs e)
        {
            try
            {
                var x = (await listApi[metroGrid.CurrentRow.Index].GetCurrentUserAsync()).Value.UserName;
                new OptionsTask(listApi[metroGrid.CurrentRow.Index], dictionaryTask).ShowDialog();
            }
            catch
            {

            }
        }

        private async void B_Pause_Click(object sender, EventArgs e)
        {
            try
            {
                var x = (await listApi[metroGrid.CurrentRow.Index].GetCurrentUserAsync()).Value.UserName; // null
                dictionaryTask[x].Pause();
            }
            catch
            {

            }
        }

        private async void B_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                var x = (await listApi[metroGrid.CurrentRow.Index].GetCurrentUserAsync()).Value.UserName;
                dictionaryTask[x].Stop();
            }
            catch
            {

            }
        }

        private async void B_Start_Click(object sender, EventArgs e)
        {
            try
            {
                var x = (await listApi[metroGrid.CurrentRow.Index].GetCurrentUserAsync()).Value.UserName;
                dictionaryTask[x].Start();
            }
            catch
            {

            }
        }

        private void MetroGrid_SelectionChanged(object sender, EventArgs e)
        {
            UpdateButton();
        }

        void UpdateButton()
        {
            if (data[metroGrid.CurrentRow.Index].Status.Equals("Пауза"))
            {
                b_Pause.Enabled = false;
                b_Stop.Enabled = false;
                b_Start.Enabled = true;
            }

            if (data[metroGrid.CurrentRow.Index].Status.Equals("Выполняется"))
            {
                b_Pause.Enabled = true;
                b_Stop.Enabled = true;
                b_Start.Enabled = false;
            }

            if (data[metroGrid.CurrentRow.Index].Status.Equals("Завершено"))
            {
                b_Pause.Enabled = false;
                b_Stop.Enabled = false;
                b_Start.Enabled = true;
            }
        }
        #endregion

        #region Логи
        public void LogAdd(object sender, MyEventMessage e)
        {
            TextBoxLog.Invoke((Action)delegate
            {
                fullLog += e.Message + "\r\n";
                UpdateLog();
            });
        }

        private void ComboBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateLog();
        }

        public void UpdateLog()
        {
            TextBoxLog.Clear();
            var x = fullLog.Split(new []{'\r','\n'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (string str in x)
            {
                string pattern = comboBoxAccounts.SelectedItem.ToString();
                if (Regex.IsMatch(str,pattern)) 
                {
                    TextBoxLog.Text += str + "\r\n";
                }
            }
        }

        private void B_SaveLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename,TextBoxLog.Text);
            }
        }

        private void B_ClearLog_Click(object sender, EventArgs e)
        {
            TextBoxLog.Clear();
        }
        #endregion

        #region Автопостинг

        private void B_AddPost_Click(object sender, EventArgs e)
        {
            new AddPostForm(listApi, dictionaryAutoPost).ShowDialog();
        }

        private void UpdateGridAutoPost(object sender, UpdateGridAutopost e)
        {
            gridAutopost.Invoke((Action)delegate
            {
                var z = infoGridAutopostBindingSource.List;
                if (z.IndexOf(e.info) == -1)
                {
                    infoGridAutopostBindingSource.Add(e.info);
                }
                else
                {
                    int index = z.IndexOf(e.info);
                    z[index] = e.info;
                }
            });
        }

        private void B_DeletePost_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridAutopost.CurrentRow.Index;
                var z = infoGridAutopostBindingSource.List;
                int number = (z[index] as InfoGridAutopost).Number;
                dictionaryAutoPost[number].Delete();
            }
            catch { }
        }

        private void B_PublishPost_Click(object sender, EventArgs e)
        {
            try
            {
                int index = gridAutopost.CurrentRow.Index;
                var z = infoGridAutopostBindingSource.List;
                int number = (z[index] as InfoGridAutopost).Number;
                dictionaryAutoPost[number].ForcedStart();
            }
            catch { }
        }
        #endregion

        #region Планировщик

        private void UpdateGridTaskPlans(object sender, UpdateGridTaskPlans e)
        {
            GridTaskPlans.Invoke((Action)delegate
            {
                var z = infoGridTaskPlansBindingSource.List;
                if (z.IndexOf(e.info) == -1)
                {
                    infoGridTaskPlansBindingSource.Add(e.info);
                }
                else
                {
                    int index = z.IndexOf(e.info);
                    z[index] = e.info;
                }

            });
        }



        private void B_AddTaskPlans_Click(object sender, EventArgs e)
        {
            new AddPlansForm(listApi,dictionaryTask,infoGridTaskPlansBindingSource.Count, listDefenderTask).ShowDialog();
        }


        private void B_DeleteTaskPlans_Click(object sender, EventArgs e)
        {
            try
            {
                int index = GridTaskPlans.CurrentRow.Index;
                var z = infoGridTaskPlansBindingSource.List;
                int number = (z[index] as InfoGridTaskPlans).Number;
                listDefenderTask[number].Delete();
            }
            catch { }
        }

        private void B_StartTaskPlans_Click(object sender, EventArgs e)
        {
            try
            {
                int index = GridTaskPlans.CurrentRow.Index;
                var z = infoGridTaskPlansBindingSource.List;
                int number = (z[index] as InfoGridTaskPlans).Number;
                listDefenderTask[number].ForcedStart();
            }
            catch { }
        }

        #endregion

        #region Аудитория
        private async void B_AudienceStart_Click(object sender, EventArgs e)
        {
            SettingAudience setting = new SettingAudience();

            switch (TabControlAudience.SelectedIndex)
            {
                case 1:
                    setting.SborAcc_WhatAccPars = (WhatAccPars) cmBoxSBorAcc_WhatAcc.SelectedIndex;
                    setting.SborAcc_WhatPars = (WhatPars) cmBoxSborAcc_Format.SelectedIndex;
                    try
                    {
                        setting.SborAcc_CountOneUser = Convert.ToInt32(tBoxSborAcc_Count.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Пожалуйста введите корректные данные \"Собрать с каждого тега\"");
                        return;
                    }

                    if (tBox_SborAcc_SaveFile.Text.Length < 1)
                    {
                        MessageBox.Show("Пожалуйста укажите путь до сохранения базы");
                        return;
                    }
                    setting.SborAcc_SaveFileName = tBox_SborAcc_SaveFile.Text;
                    if (metroRadioButtonSborFollow.Checked)
                        setting.SborAcc_Sbor = Sbor.Followers;
                    else
                        setting.SborAcc_Sbor = Sbor.Subscriptions;
                    List<string> listAccSbor = new List<string>();
                    var z = tBox_SborAcc.Text.Split(new []{'\n'},StringSplitOptions.RemoveEmptyEntries);
                    foreach (string str in z)
                    {
                        string i = str.TrimEnd('\r');
                        listAccSbor.Add(i);
                    }

                    setting.SborAcc_ListUserNames = listAccSbor;
                    var a = new AudienceSborLogin(listApi[cmBox_Settings_Acc.SelectedIndex], setting);
                    a.Start();
                    listAudienceTasks.Add(a);
                    TabControlAudience.SelectedIndex = 0;
                    break;
                case 2:
                    setting.SborHashTags_WhatPars = (WhatPars) cmBox_HastagsFormat.SelectedIndex;
                    setting.SborHashTags_CheckedLikeUnderPublish = chBox_HashTags_LikeUnderPublish.Checked;
                    setting.SborHashTags_CheckedCommentUnderPublish = chBox_HashTags_CommentUnderPublish.Checked;
                    if (chBox_HashTags_LikeUnderPublish.Checked)
                    {
                        try
                        {
                            setting.SborHashTags_CountLikeUnderPublish_Min = Convert.ToInt32(tBox_HashTag_LikeMin.Text);
                            setting.SborHashTags_CountLikeUnderPublish_Max = Convert.ToInt32(tBox_HashTag_LikeMax.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Пожалуйста введите корректные данные для настройки лайков");
                            return;
                        }
                    }

                    if (chBox_HashTags_CommentUnderPublish.Checked)
                    {
                        try
                        {
                            setting.SborHashTags_CountCommentUnderPublish_Min =
                                Convert.ToInt32(tBox_HashTag_CommentMin.Text);
                            setting.SborHashTags_CountCommentUnderPublish_Max =
                                Convert.ToInt32(tBox_HashTag_CommentMax.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Пожалуйста введите корректные данные для настройки комментариев");
                            return;
                        }
                    }

                    try
                    {
                        setting.SborHashTags_CountUneUser = Convert.ToInt32(tBox_HashTags_CountSbor.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Пожалуйста введите корректные данные для кол-во сбора с хэштега");
                        return;
                    }
                    setting.SborHashTags_TypePublish = (TypePublish) cmBox_HashTag_TypePublish.SelectedIndex;
                    if (tBox_HashTag_SaveFile.Text.Length < 1)
                    {
                        MessageBox.Show("Пожалуйста укажите корректный путь до файла сохранения базы");
                        return;
                    }
                    setting.SborHashTags_SaveFileName = tBox_HashTag_SaveFile.Text;

                    List<string> listHashTags = new List<string>();
                    var q = tBox_HashTags.Text.Split(new[] {'\n'}, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var str in q)
                    {
                        string p = str.TrimEnd('\r');
                        listHashTags.Add(p);
                    }

                    setting.SborHashTags_ListHashTags = listHashTags;
                    var b = new AudienceHashTagsSbor(listApi[cmBox_Settings_Acc.SelectedIndex], setting);
                    b.Start();
                    listAudienceTasks.Add(b);
                    TabControlAudience.SelectedIndex = 0;
                    break;
                case 3:
                    if (tBox_Filter_FileBaseId.Text.Length < 1)
                    {
                        MessageBox.Show("Пожалуйста укажите корректный путь до файла базы");
                        return;
                    }

                    if (tBox_Filter_SaveFileId.Text.Length < 1)
                    {
                        MessageBox.Show("Пожалуйста укажите корректный путь до файла базы");
                        return;
                    }
                    setting.Filter_FileNameId = tBox_Filter_FileBaseId.Text;
                    setting.Filter_SaveFileName = tBox_Filter_SaveFileId.Text;
                    setting.Filter_CheckedFollowers = chBox_Filter_Follow.Checked;
                    if (chBox_Filter_Follow.Checked)
                    {
                        try
                        {
                            setting.Filter_Followers_Min = Convert.ToInt32(tBox_Filter_Follower_Min.Text);
                            setting.Filter_Followers_Max = Convert.ToInt32(tBox_Filter_Follower_Max.Text);
                            if (setting.Filter_Followers_Max < setting.Filter_Followers_Min)
                            {
                                MessageBox.Show("Максимальное значение не может быть меньше минимального");
                                return;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Пожалуйста укажите корректные данные настройки подписчиков");
                            return;
                        }
                    }

                    setting.Filter_CheckedSubscriptions = chBox_Filter_Subsriprions.Checked;
                    if (chBox_Filter_Subsriprions.Checked)
                    {
                        try
                        {
                            setting.Filter_Subscriptions_Min = Convert.ToInt32(tBox_Filter_Subscriptions_Min.Text);
                            setting.Filter_Subscriptions_Max = Convert.ToInt32(tBox_Filter_Subscriptions_Max.Text);
                            if (setting.Filter_Subscriptions_Max < setting.Filter_Subscriptions_Min)
                            {
                                MessageBox.Show("Максимальное значение не может быть меньше минимального");
                                return;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Пожалуйста укажите корректные данные настройки подписок");
                            return;
                        }
                    }

                    setting.Filter_CheckedPublish = chBox_Filter_Publish.Checked;
                    if (chBox_Filter_Publish.Checked)
                    {
                        try
                        {
                            setting.Filter_Publish_Min = Convert.ToInt32(tBox_Filter_Publish_Min.Text);
                            setting.Filter_Publish_Max = Convert.ToInt32(tBox_Filter_Publish_Max.Text);
                            if (setting.Filter_Publish_Max < setting.Filter_Publish_Min)
                            {
                                MessageBox.Show("Максимальное значение не может быть меньше минимального");
                                return;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Пожалуйста укажите корректные данные настройки публикаций");
                            return;
                        }
                    }

                    setting.Filter_CheckedOldDays = chBox_Filter_OldDays.Checked;
                    if (chBox_Filter_OldDays.Checked)
                    {
                        try
                        {
                            setting.Filter_OldDays = Convert.ToInt32(tBox_Filter_OldDays.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Пожалуйста укажите корректные данные настройки последней публикации");
                            return;
                        }
                    }

                    setting.Filter_WhatAccPars = (WhatAccPars) cmBox_Filter_WhatAccPars.SelectedIndex;
                    setting.Filter_CheckedAvatar = chBox_Filter_Avatar.Checked;
                    setting.Filter_CheckedBusines = chBox_Filter_Busines.Checked;
                    var c = new AudienceFilterTask(listApi[cmBox_Settings_Acc.SelectedIndex], setting);
                    c.Start();
                    listAudienceTasks.Add(c);
                    TabControlAudience.SelectedIndex = 0;
                    break;
                case 4:
                    if (tBox_DeleteDubble_Original.Text.Length < 1 || tBox_DeleteDubble_Save.Text.Length < 1)
                    {
                        MessageBox.Show("Пожалуйста укажите путь до файла");
                        return;
                    }
                    setting.DeleteDouble_OriginalFileName = tBox_DeleteDubble_Original.Text;
                    setting.DeleteDouble_SaveFileName = tBox_DeleteDubble_Save.Text;
                    var qwr = new AudienceDeleteDuplicatesTask(setting);
                    qwr.Start();
                    listAudienceTasks.Add(qwr);
                    TabControlAudience.SelectedIndex = 0;
                    break;
                case 5:
                    setting.Convert_OriginalPars = (WhatPars) cmBox_Convert_OldWhatPars.SelectedIndex;
                    setting.Convert_NewPars = (WhatPars) cmBox_Convert_NewWhatPars.SelectedIndex;
                    if (tBox_Convert_Original.Text.Length < 1 || tBox_Convert_Save.Text.Length < 1)
                    {
                        MessageBox.Show("Пожалуйста укажите путь до файла");
                        return;
                    }
                    setting.Convert_OriginalFileName = tBox_Convert_Original.Text;
                    setting.Convert_SaveFileName = tBox_Convert_Save.Text;
                    var gds = new AudienceConvert(listApi[cmBox_Settings_Acc.SelectedIndex], setting);
                    gds.Start();
                    listAudienceTasks.Add(gds);
                    TabControlAudience.SelectedIndex = 0;
                    break;
            }
        }

        private void UpdateGridAudience(object sender, UpdateGridAudience e)
        {
            gridAutopost.Invoke((Action)delegate
            {
                var z = infoStatisticsGridBindingSource.List;
                if (z.IndexOf(e.Info) == -1)
                {
                    infoStatisticsGridBindingSource.Add(e.Info);
                }
                else
                {
                    int index = z.IndexOf(e.Info);
                    z[index] = e.Info;
                }
            });
        }

        #region Удаление дубликатов

        private void tBox_DeleteDouble_Original_BClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Файл с базой (*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            tBox_DeleteDubble_Original.Text = open.FileName;
        }

        private void tBox_DeleteDouble_Save_BClick(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Куда сохранить (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.Cancel)
                return;
            tBox_DeleteDubble_Save.Text = save.FileName;
        }
        #endregion

        #region Конвертация
        private void tBox_Convert_Original_BClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Файл с базой (*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            tBox_Convert_Original.Text = open.FileName;
        }

        private void tBox_Convert_Save_BClick(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Куда сохранить (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.Cancel)
                return;
            tBox_Convert_Save.Text = save.FileName;
        }


        #endregion

        #region Фильтрация
        private void tBox_Filter_FileId_BClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Файл с базой (*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            tBox_Filter_FileBaseId.Text = open.FileName;
        }

        private void tBox_Filter_SaveFileId_BClick(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Куда сохранить (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.Cancel)
                return;
            tBox_Filter_SaveFileId.Text = save.FileName;
        }

        #endregion

        #region Сбор по хэштегам

        private void tBox_HashTag_SaveFile_BClick(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Куда сохранить (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.Cancel)
                return;
            tBox_HashTag_SaveFile.Text = save.FileName;
        }

        #endregion

        #region Сбор по аккаунтам

        private void tBox_SborAcc_SaveFile_BClick(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Куда сохранить (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.Cancel)
                return;
            tBox_SborAcc_SaveFile.Text = save.FileName;
        }



        #endregion

        #endregion

        private void B_LoadFileAcc_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "База с логинами (*.txt)|*.txt";
            if(open.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (string login in File.ReadAllLines(open.FileName))
            {
                tBox_SborAcc.Text += login + "\r\n";
            }
        }

        private void B_CleatSborAcc_Click(object sender, EventArgs e)
        {
            tBox_SborAcc.Clear();
        }

        private void B_LoadHashTags_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "База с логинами (*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            foreach (string login in File.ReadAllLines(open.FileName))
            {
                tBox_HashTags.Text += login + "\r\n";
            }
        }

        private void B_ClearHashTags_Click(object sender, EventArgs e)
        {
            tBox_HashTags.Clear();
        }

        private void TBoxSborAcc_Count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private async void B_Audience_Start_Click(object sender, EventArgs e)
        {
            try
            {
                var x = metroGridStatistic.CurrentRow.Index;
                listAudienceTasks[x].Start();
            }
            catch { }
        }

        private void B_Audience_Pause_Click(object sender, EventArgs e)
        {
            try
            {
                var x = metroGridStatistic.CurrentRow.Index;
                listAudienceTasks[x].Pause();
            }
            catch { }
        }

        private void B_Audience_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                var x = metroGridStatistic.CurrentRow.Index;
                listAudienceTasks[x].Stop();
            }
            catch { }
        }


        private void TabControlAudience_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlAudience.SelectedIndex == 0)
            {
                b_AudienceStart.Visible = false;
                b_Audience_Start.Visible = true;
                b_Audience_Pause.Visible = true;
                b_Audience_Stop.Visible = true;
            }
            else
            {
                b_AudienceStart.Visible = true;
                b_Audience_Start.Visible = false;
                b_Audience_Pause.Visible = false;
                b_Audience_Stop.Visible = false;
            }
        }

        private void B_AddAcc_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm(listApi);
            authForm.ShowDialog();
            UpdateNewAcc();
        }

        async void UpdateNewAcc()
        {
            if (listApi != null && listApi.Count != 0)
            {
                List<int> badIndex = new List<int>();
                for (int i = data.Count; i < listApi.Count; i++)
                {
                    try
                    {
                        var userInfo = await listApi[i].GetCurrentUserAsync();
                        if (userInfo.Succeeded == false || userInfo == null)
                        {
                            Thread.Sleep(200);
                            continue;
                        }

                        //if (data[i] != null)
                        //    if (data[i].Login == userInfo.Value.UserName)
                        //        continue;

                        var userInfoFull = await listApi[i].GetUserInfoByIdAsync(userInfo.Value.Pk);
                        string login = userInfo.Value.UserName;
                        string task = "-";
                        string progress = "-";
                        string subscriptions = Convert.ToString(userInfoFull.Value.FollowingCount);
                        string subscribers = Convert.ToString(userInfoFull.Value.FollowerCount);
                        string publish = Convert.ToString(userInfoFull.Value.MediaCount);
                        string status;
                        if (listApi[i].IsUserAuthenticated)
                            status = "Good";
                        else
                            status = "Bad";
                        data.Add(new AccountInfo(login, task, progress, subscriptions, subscribers, publish, status));

                        comboBoxAccounts.Items.Add(userInfo.Value.UserName);
                        comboBoxAccounts.SelectedItem = comboBoxAccounts.Items[0];

                        cmBox_Settings_Acc.Items.Add(userInfo.Value.UserName);
                        cmBox_Settings_Acc.SelectedItem = comboBoxAccounts.Items[0];
                        Thread.Sleep(200);
                    }
                    catch
                    {
                        badIndex.Add(i);
                        continue;
                    }
                }

                foreach (int bad in badIndex)
                {
                    listApi.Remove(listApi[bad]);
                }
            }
        }
    }

}
