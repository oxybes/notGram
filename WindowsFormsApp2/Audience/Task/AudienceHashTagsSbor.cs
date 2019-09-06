using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApp2.Audience.Statistics;
using InstaSharper.API;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;

namespace WindowsFormsApp2.Audience.Task
{
    class AudienceHashTagsSbor:IAudienceTask
    {
        private IInstaApi api;
        private SettingAudience setting;
        static public event EventHandler<UpdateGridAudience> EventUpdateGrid;
        private ManualResetEvent ew;
        private InfoStatisticsGrid info;
        List<string> listAcc = new List<string>();
        private CancellationTokenSource _source;

        public AudienceHashTagsSbor(IInstaApi api, SettingAudience setting)
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
            info.Progress = $"{progress}/{setting.SborHashTags_CountUneUser * setting.SborHashTags_ListHashTags.Count}";
            EventUpdateGrid(this, new UpdateGridAudience(info));
            foreach (string hashTag in setting.SborHashTags_ListHashTags)
            {
                if (_source == null || _source.IsCancellationRequested)
                    break;

                var tag = await api.GetTagFeedAsync(hashTag, PaginationParameters.MaxPagesToLoad(45));
                ew.WaitOne();
                if (tag.Succeeded)
                {
                    int count = 0;
                    for (int i = 0; i < tag.Value.MediaItemsCount; i++)
                    {
                        for (int x = 0; x < tag.Value.Medias[i].Likers.Count; x++)
                        {
                            try
                            {
                                if (_source == null || _source.IsCancellationRequested)
                                    break;

                                var media = tag.Value.Medias[i];
                                if (setting.SborHashTags_CheckedLikeUnderPublish)
                                {
                                    if (media.LikesCount > setting.SborHashTags_CountLikeUnderPublish_Max ||
                                        media.LikesCount < setting.SborHashTags_CountLikeUnderPublish_Min)
                                        continue;
                                }

                                if (setting.SborHashTags_CheckedCommentUnderPublish)
                                {
                                    if (Convert.ToInt32(media.CommentsCount) >
                                        setting.SborHashTags_CountCommentUnderPublish_Max ||
                                        Convert.ToInt32(media.CommentsCount) <
                                        setting.SborHashTags_CountCommentUnderPublish_Min)
                                        continue;
                                }

                                if (setting.SborHashTags_TypePublish == TypePublish.Photo)
                                {
                                    var type = media.MediaType;
                                    if (type != InstaMediaType.Image)
                                    {
                                        continue;
                                    }
                                }

                                if (setting.SborHashTags_TypePublish == TypePublish.Video)
                                {
                                    var type = media.MediaType;
                                    if (type != InstaMediaType.Video)
                                    {
                                        continue;
                                    }
                                }

                                var user = tag.Value.Medias[i].Likers[x];
                                if (setting.SborHashTags_WhatPars == WhatPars.Login)
                                {
                                    listAcc.Add(user.UserName);
                                }

                                if (setting.SborHashTags_WhatPars == WhatPars.ID)
                                {
                                    listAcc.Add(user.Pk.ToString());
                                }
                                ew.WaitOne();
                                count++;
                                progress++;
                                info.Progress =
                                    $"{progress}/{setting.SborHashTags_CountUneUser * setting.SborHashTags_ListHashTags.Count}";
                                EventUpdateGrid(this, new UpdateGridAudience(info));
                                if (count > setting.SborHashTags_CountUneUser)
                                {
                                    break;
                                }
                            }
                            catch
                            {
                                continue;
                            }
                        }

                        if (count > setting.SborHashTags_CountUneUser)
                        {
                            count = 0;
                            break;
                        }
                    }
                    Thread.Sleep(500);
                }
                else
                {
                    Thread.Sleep(5000);
                }
            }
            info.Status = "Выполнено";
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
            return "Сбор по хэштегам";
        }

        void Save()
        {
            try
            {
                File.WriteAllLines(setting.SborHashTags_SaveFileName, listAcc.ToArray());
            }
            catch
            {
                info.Status = "Ошибка записи файла, укажите корректный путь до файла";
            }

        }

    }
}
