using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApp2.Audience.Statistics;
using InstaSharper.API;
using InstaSharper.Classes;

namespace WindowsFormsApp2.Audience.Task
{
    class AudienceSborLogin:IAudienceTask
    {
        private IInstaApi api;
        private SettingAudience setting;
        static public event EventHandler<UpdateGridAudience> EventUpdateGrid;
        private CancellationTokenSource _source;

        private ManualResetEvent ew;
        private InfoStatisticsGrid info;
        List<string> listAcc = new List<string>();

        public AudienceSborLogin(IInstaApi api, SettingAudience setting)
        {
            ew = new ManualResetEvent(true);
            this.api = api;
            this.setting = setting;
            info = new InfoStatisticsGrid(Info(), "-", setting.DeleteDouble_OriginalFileName, "Готов");
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
            info.File = setting.SborAcc_SaveFileName;
            info.Status = "Выполняется";
            int progress = 0;
            info.Progress = $"{progress}/{setting.SborAcc_CountOneUser * setting.SborAcc_ListUserNames.Count}";
            EventUpdateGrid(this, new UpdateGridAudience(info));

            foreach (string username in setting.SborAcc_ListUserNames)
            {
                if (_source == null || _source.IsCancellationRequested)
                    break;
                int maxPagesToLoad = setting.SborAcc_CountOneUser % 200 == 0
                    ? setting.SborAcc_CountOneUser / 200
                    : (setting.SborAcc_CountOneUser / 200) + 1;
                if (setting.SborAcc_Sbor == Audience.Sbor.Followers)
                {
                    var infoFollowers =
                        await api.GetUserFollowersAsync(username, PaginationParameters.MaxPagesToLoad(maxPagesToLoad));
                    ew.WaitOne();
                    info.Status = "Выполняется";
                    if (infoFollowers.Value.Count != 0 || infoFollowers.Succeeded)
                    {
                        for (int i = 0; i < infoFollowers.Value.Count; i++)
                        {
                            try
                            {
                                if (_source == null || _source.IsCancellationRequested)
                                    break;

                                if (i > setting.SborAcc_CountOneUser)
                                    break;
                                if (WhatAccPars.onlyPrivate == setting.SborAcc_WhatAccPars &&
                                    !infoFollowers.Value[i].IsPrivate)
                                    continue;
                                if (WhatAccPars.onlyPrivate == setting.SborAcc_WhatAccPars &&
                                    infoFollowers.Value[i].IsPrivate)
                                {
                                    if (setting.SborAcc_WhatPars == WhatPars.ID)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].Pk.ToString());
                                    }

                                    if (setting.SborAcc_WhatPars == WhatPars.Login)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].UserName);
                                    }
                                }

                                if (WhatAccPars.onlyPublic == setting.SborAcc_WhatAccPars &&
                                    infoFollowers.Value[i].IsPrivate)
                                    continue;
                                if (WhatAccPars.onlyPublic == setting.SborAcc_WhatAccPars &&
                                    !infoFollowers.Value[i].IsPrivate)
                                {
                                    if (setting.SborAcc_WhatPars == WhatPars.ID)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].Pk.ToString());
                                    }

                                    if (setting.SborAcc_WhatPars == WhatPars.Login)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].UserName);
                                    }
                                }

                                if (WhatAccPars.All == setting.SborAcc_WhatAccPars)
                                {
                                    if (setting.SborAcc_WhatPars == WhatPars.ID)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].Pk.ToString());
                                    }

                                    if (setting.SborAcc_WhatPars == WhatPars.Login)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].UserName);
                                    }
                                }

                                progress++;
                                info.Progress =
                                    $"{progress}/{setting.SborAcc_CountOneUser * setting.SborAcc_ListUserNames.Count}";
                                EventUpdateGrid(this, new UpdateGridAudience(info));
                            }
                            catch
                            {
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    var infoFollowers =
                        await api.GetUserFollowingAsync(username, PaginationParameters.MaxPagesToLoad(maxPagesToLoad));
                    ew.WaitOne();
                    info.Status = "Выполняется";
                    if (infoFollowers.Succeeded || infoFollowers.Value.Count != 0)
                    {
                        for (int i = 0; i < infoFollowers.Value.Count; i++)
                        {
                            try
                            {
                                if (_source == null || _source.IsCancellationRequested)
                                    break;
                                if (i > setting.SborAcc_CountOneUser)
                                    break;
                                if (WhatAccPars.onlyPrivate == setting.SborAcc_WhatAccPars &&
                                    !infoFollowers.Value[i].IsPrivate)
                                    continue;
                                if (WhatAccPars.onlyPrivate == setting.SborAcc_WhatAccPars &&
                                    infoFollowers.Value[i].IsPrivate)
                                {
                                    if (setting.SborAcc_WhatPars == WhatPars.ID)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].Pk.ToString());
                                    }

                                    if (setting.SborAcc_WhatPars == WhatPars.Login)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].UserName);
                                    }
                                }

                                if (WhatAccPars.onlyPublic == setting.SborAcc_WhatAccPars &&
                                    infoFollowers.Value[i].IsPrivate)
                                    continue;
                                if (WhatAccPars.onlyPublic == setting.SborAcc_WhatAccPars &&
                                    !infoFollowers.Value[i].IsPrivate)
                                {
                                    if (setting.SborAcc_WhatPars == WhatPars.ID)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].Pk.ToString());
                                    }

                                    if (setting.SborAcc_WhatPars == WhatPars.Login)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].UserName);
                                    }
                                }

                                if (WhatAccPars.All == setting.SborAcc_WhatAccPars)
                                {
                                    if (setting.SborAcc_WhatPars == WhatPars.ID)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].Pk.ToString());
                                    }

                                    if (setting.SborAcc_WhatPars == WhatPars.Login)
                                    {
                                        listAcc.Add(infoFollowers.Value[i].UserName);
                                    }
                                }

                                progress++;
                                info.Progress =
                                    $"{progress}/{setting.SborAcc_CountOneUser * setting.SborAcc_ListUserNames.Count}";
                                EventUpdateGrid(this, new UpdateGridAudience(info));
                            }
                            catch
                            {
                                continue;
                            }
                        }
                    }
                }
                Thread.Sleep(5000);
            }
            Save();
            info.Status = "Выполнено";
            EventUpdateGrid(this, new UpdateGridAudience(info));
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
            return "Сбор по логинам";
        }

        void Save()
        {
            try
            {
                File.WriteAllLines(setting.SborAcc_SaveFileName, listAcc.ToArray());
            }
            catch { }
        }
        
    }
}
