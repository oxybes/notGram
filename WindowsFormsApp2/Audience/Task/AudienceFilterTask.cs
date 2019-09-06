using InstaSharper.API;
using InstaSharper.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using WindowsFormsApp2.Audience.Statistics;

namespace WindowsFormsApp2.Audience.Task
{
    class AudienceFilterTask:IAudienceTask
    {
        private IInstaApi api;
        private SettingAudience setting;
        static public event EventHandler<UpdateGridAudience> EventUpdateGrid;
        private CancellationTokenSource _source;
        private ManualResetEvent ew;
        private InfoStatisticsGrid info;
        List<string> listAcc = new List<string>();
        List<string> listAccBusines = new List<string>();

        public AudienceFilterTask(IInstaApi api, SettingAudience setting)
        {
            ew = new ManualResetEvent(true);
            this.api = api;
            this.setting = setting;
            info = new InfoStatisticsGrid(Info(), "-", setting.DeleteDouble_OriginalFileName, "Выполняется");
        }


        public void Start()
        {

            if (_source == null)
            {
                _source = new CancellationTokenSource();
                ThreadPool.QueueUserWorkItem(new WaitCallback((s) =>
                {
                    Sbor();
                }));
            }
            else
            {
                ew.Set();
            }
        }

        async void Sbor()
        {
            string[] baseId = null;
            try
            {
                baseId = File.ReadAllLines(setting.Filter_FileNameId);
            }
            catch
            {
                info.Status = "Ошибка чтения файла базой";}
            info.File = setting.Filter_SaveFileName;
            int progress = 0;
            if (baseId != null)
                info.Progress = $"{progress}/{baseId.Length}";
            EventUpdateGrid(this, new UpdateGridAudience(info));

            foreach (string id in baseId)
            {
                try
                {
                    if (_source == null || _source.IsCancellationRequested)
                        break;

                    var user = await api.GetUserInfoByUsernameAsync(id);
                    ew.WaitOne();
                    if (user.Succeeded && user != null)
                    {
                        if (setting.Filter_CheckedFollowers)
                        {
                            if (setting.Filter_Followers_Min > user.Value.FollowerCount ||
                                setting.Filter_Followers_Max < user.Value.FollowerCount)
                            {
                                progress++;
                                info.Progress = $"{progress}/{baseId.Length}";
                                EventUpdateGrid(this, new UpdateGridAudience(info));
                                Thread.Sleep(400);
                                continue;
                            }
                        }

                        if (setting.Filter_CheckedSubscriptions)
                        {
                            if (setting.Filter_Subscriptions_Min > user.Value.FollowingCount ||
                                setting.Filter_Subscriptions_Max < user.Value.FollowingCount)
                            {
                                progress++;
                                info.Progress = $"{progress}/{baseId.Length}";
                                EventUpdateGrid(this, new UpdateGridAudience(info));
                                Thread.Sleep(400);
                                continue;
                            }
                        }

                        if (setting.Filter_CheckedPublish)
                        {
                            if (setting.Filter_Publish_Min > user.Value.MediaCount ||
                                setting.Filter_Publish_Max < user.Value.MediaCount)
                            {
                                progress++;
                                info.Progress = $"{progress}/{baseId.Length}";
                                EventUpdateGrid(this, new UpdateGridAudience(info));
                                Thread.Sleep(400);
                                continue;
                            }
                        }

                        if (setting.Filter_CheckedOldDays)
                        {
                            var mediaList =
                                await api.GetUserMediaAsync(user.Value.Username,
                                    PaginationParameters.MaxPagesToLoad(1));
                            if (mediaList.Succeeded && mediaList.Value[0] != null)
                            {
                                if ((DateTime.Now - mediaList.Value[0].Caption.CreatedAt).Days > setting.Filter_OldDays)
                                {
                                    progress++;
                                    info.Progress = $"{progress}/{baseId.Length}";
                                    EventUpdateGrid(this, new UpdateGridAudience(info));
                                    Thread.Sleep(400);
                                    continue;
                                }
                            }
                        }

                        if (setting.Filter_WhatAccPars == WhatAccPars.onlyPublic && user.Value.IsPrivate)
                        {
                            progress++;
                            info.Progress = $"{progress}/{baseId.Length}";
                            EventUpdateGrid(this, new UpdateGridAudience(info));
                            Thread.Sleep(400);
                            continue;
                        }

                        if (setting.Filter_WhatAccPars == WhatAccPars.onlyPrivate && !user.Value.IsPrivate)
                        {
                            progress++;
                            info.Progress = $"{progress}/{baseId.Length}";
                            EventUpdateGrid(this, new UpdateGridAudience(info));
                            Thread.Sleep(400);
                            continue;
                        }

                        if (setting.Filter_CheckedAvatar && user.Value.HasAnonymousProfilePicture)
                        {
                            progress++;
                            info.Progress = $"{progress}/{baseId.Length}";
                            EventUpdateGrid(this, new UpdateGridAudience(info));
                            Thread.Sleep(400);
                            continue;
                        }

                        if (setting.Filter_CheckedBusines && user.Value.IsBusiness)
                        {
                            progress++;
                            info.Progress = $"{progress}/{baseId.Length}";
                            EventUpdateGrid(this, new UpdateGridAudience(info));
                            listAccBusines.Add(user.Value.Username);
                        }

                        listAcc.Add(user.Value.Username);
                        info.Progress = $"{progress}/{baseId.Length}";
                        EventUpdateGrid(this, new UpdateGridAudience(info));
                        Thread.Sleep(400);
                    }
                    else
                        Thread.Sleep(6000);
                }
                catch
                {
                    continue;
                }
            }
            info.Status = "Выполнено";
            info.Progress = $"{progress}/{baseId.Length}";
            EventUpdateGrid(this, new UpdateGridAudience(info));
            Save();
        }

        public void Pause()
        {
            info.Status = "Пауза";
            EventUpdateGrid(this, new UpdateGridAudience(info));
            Save();
            ew.Reset();
        }

        public void Stop()
        {
            Save();
            if (_source != null)
            {
                using (_source)
                {
                    _source.Cancel();
                }
                _source = null;
            }
        }

        public string Info()
        {
            return "Фильтрация баз";
        }

        void Save()
        {
            try
            {
                if (setting.Filter_CheckedBusines)
                {
                    File.WriteAllLines(setting.Filter_SaveFileName, listAccBusines);
                    return;
                }

                File.WriteAllLines(setting.Filter_SaveFileName, listAcc.ToArray());
            }
            catch { }
        }
    }
}
