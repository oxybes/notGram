using InstaSharper.API;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using WindowsFormsApp2.Audience.Statistics;

namespace WindowsFormsApp2.Audience.Task
{
    public class AudienceConvert:IAudienceTask
    {
        private IInstaApi api;
        private SettingAudience setting;
        static public event EventHandler<UpdateGridAudience> EventUpdateGrid;
        private CancellationTokenSource _source;
        private ManualResetEvent ew;
        private InfoStatisticsGrid info;
        private List<string> listId;
        private List<string> LoginID;

        public AudienceConvert(IInstaApi api, SettingAudience setting)
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
                    AConvert();
                }));
            }
            else
            {
                ew.Set();
            }
        }

        void AConvert()
        {
            info.Status = "Выполняется";
            EventUpdateGrid(this, new UpdateGridAudience(info));
            switch (setting.Convert_OriginalPars)
            {
                case WhatPars.ID:
                    if(setting.Convert_NewPars == WhatPars.Login)
                        IdLogin();
                    break;
                case WhatPars.Login:
                    if(setting.Convert_NewPars == WhatPars.ID)
                        LoginId();
                    break;
            }
        }

        async void IdLogin()
        {
            string[] baseId = null;
            try
            {
                baseId = File.ReadAllLines(setting.Convert_OriginalFileName);
            }
            catch
            {
                info.File = "Ошибка чтения из в файла, пожалуйста, проверьте корректность введенных данных";
            }
            LoginID = new List<string>();
            int progress = 0;
            info.Progress = $"{progress}/{baseId.Length}";
            info.Status = "Выполняется";
            info.File = setting.Convert_OriginalFileName;
            EventUpdateGrid(this, new UpdateGridAudience(info));

            if (baseId != null)
            {
                foreach (string strId in baseId)
                {
                    if (_source == null || _source.IsCancellationRequested)
                        break;
                    ew.WaitOne();
                    IResult<InstaUserInfo> infoUser = null;
                    try
                    {
                        infoUser = await api.GetUserInfoByIdAsync(Convert.ToInt64(strId));
                        Thread.Sleep(600);
                    }
                    catch
                    {
                        continue;
                    }

                    try
                    {
                        LoginID.Add(infoUser.Value.Username);
                        progress++;
                    }
                    catch
                    {
                        Thread.Sleep(6000);
                        continue;
                    }

                    info.Progress = $"{progress}/{baseId.Length}";
                    EventUpdateGrid(this, new UpdateGridAudience(info));
                }
            }

            try
            {
                File.WriteAllLines(setting.Convert_SaveFileName, LoginID.ToArray());
            }
            catch
            {
                info.File = "Ошибка записи в файл, пожалуйста, проверьте корректность введенных данных";
            }

            info.Status = "Выполнено";
            EventUpdateGrid(this, new UpdateGridAudience(info));
        }


        async void LoginId()
        {
            string[] baseUsername = null;
            try
            {
                baseUsername = File.ReadAllLines(setting.Convert_OriginalFileName);
            }
            catch
            {

                info.File = "Ошибка чтения из файла, пожалуйста, проверьте корректность введенных данных";

            }
            listId = new List<string>();
            int progress = 0;
            info.Progress = $"{progress}/{baseUsername.Length}";
            info.Status = "Выполняется";
            info.File = setting.Convert_OriginalFileName;
            EventUpdateGrid(this, new UpdateGridAudience(info));
            if (baseUsername != null)
            {
                foreach (string username in baseUsername)
                {
                    if (_source == null || _source.IsCancellationRequested)
                        break;
                    ew.WaitOne();
                    IResult<InstaUserInfo> infoUser = null;
                    try
                    {
                        infoUser = await api.GetUserInfoByUsernameAsync(username);
                        listId.Add(Convert.ToString(infoUser.Value.Pk));
                        progress++;
                        info.Progress = $"{progress}/{baseUsername.Length}";
                        EventUpdateGrid(this, new UpdateGridAudience(info));
                        Thread.Sleep(600);
                    }
                    catch
                    {
                        Thread.Sleep(6000);
                        continue;
                    }
                }
            }

            try
            {
                File.WriteAllLines(setting.Convert_SaveFileName, listId.ToArray());
            }
            catch
            {
                info.File = "Ошибка записи в файл, пожалуйста, проверьте корректность введенных данных";
            }

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

        void Save()
        {
            try
            {
                if (listId != null)
                {
                    File.WriteAllLines(setting.SborAcc_SaveFileName, listId.ToArray());
                }

                if (LoginID != null)
                {
                    File.WriteAllLines(setting.SborAcc_SaveFileName, LoginID.ToArray());
                }
            }
            catch { }
        }

        public string Info()
        {
            return "Конвертация баз";
        }
    }
}
