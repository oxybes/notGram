using InstaBot;
using InstaBot.SettingsTask;
using InstaSharper.API;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace WindowsFormsApp2.Task
{
    class TaskMassDirect:ITask
    {
        static public event EventHandler<MyEventMessage> EventFromMyClass;
        static public event EventHandler<UpdateGridEvent> EventUpdateGrid;

        private CancellationTokenSource _source;
        private Timer timer;

        private IInstaApi api;
        private SettingTaskMassDirect setting;
        private ManualResetEvent ew;
        private List<long> usersID;
        private List<long> usersIDcopy;
        private Random rnd;
        private int CountMessage;
        private int CountPause;
        private IResult<InstaCurrentUser> userInfoLog;

        public bool Stat { get; private set; } = false;

        public TaskMassDirect(IInstaApi api, SettingTaskMassDirect setting)
        {
            this.api = api;
            this.setting = setting;
            ew = new ManualResetEvent(true);
        }

        public void Start()
        {
            if (_source == null)
            {
                _source = new CancellationTokenSource();
                rnd = new Random();
                CountMessage = 0;
                CountPause = 0;
                usersID = new List<long>();
                usersIDcopy = new List<long>();
                try
                {
                    ThreadPool.QueueUserWorkItem((s) => { MassDirect().GetAwaiter().GetResult(); });
                }
                catch
                {
                    EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:МассДирект:{CountMessage}/{usersID.Count}: - : - : - :" +
                                                              $"Забанен"));
                }
            }
            else
            {
                EventFromMyClass(this,
                    new MyEventMessage(
                        $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Продолжаю работу."));
                ew.Set();
            }
        }


        async System.Threading.Tasks.Task MassDirect()
        {
            Stat = true;
            userInfoLog = await api.GetCurrentUserAsync();
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Рассылка сообщений запущена"));
            EventFromMyClass(this,
                new MyEventMessage(
                    $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Загружаю базу."));
            try
            {
                string[] stringID = System.IO.File.ReadAllLines(setting.FileNameBaseId);
                foreach (string str in stringID)
                {
                    try
                    {
                        usersID.Add(Convert.ToInt64(str));
                        usersIDcopy.Add(Convert.ToInt64(str));
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] ОШИБКА: {e.Message}"));
            }
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:МассДирект:{CountMessage}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Выполняется"));

            foreach (long id in usersID)
            {
                try
                {
                    if (_source == null || _source.IsCancellationRequested)
                        break;

                    int random = rnd.Next(0, setting.Messages.Count);
                    var x = await api.SendDirectMessage(id.ToString(), null, setting.Messages[random]);
                    CountMessage++;
                    CountPause++;
                    EventFromMyClass(this,
                        new MyEventMessage(
                            $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Oтправил сообщение пользователю {(await api.GetUserInfoByIdAsync(id)).Value.Username}. Kоличество сообщений: {CountMessage}"));
                    EventUpdateGrid(this, new UpdateGridEvent(
                        $"{userInfoLog.Value.UserName}:МассДирект:{CountMessage}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                        $"Выполняется"));
                    if (setting.ChekedDeleteBase)
                    {
                        usersIDcopy.Remove(id);
                    }
                    Delay();

                    if (setting.CheckedPause) //Учет паузы
                    {
                        if (setting.PauseLimit <= CountPause)
                        {
                            CountPause = 0;
                            EventFromMyClass(this,
                                new MyEventMessage(
                                    $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Пауза на " +
                                    setting.PauseTime + " минут"));
                            EventUpdateGrid(this, new UpdateGridEvent(
                                $"{userInfoLog.Value.UserName}:МассДирект:{CountMessage}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                $"Пауза"));
                            if (timer != null)
                                timer.Dispose();
                            timer = new Timer(CancelDelay, null, 60000 * setting.PauseTime, Timeout.Infinite);
                            ew.Reset();
                            ew.WaitOne();
                        }
                    }
                }
                catch (Exception e)
                {
                    EventFromMyClass(this,
                        new MyEventMessage(
                            $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] ОШИБКА: {e.Message}"));
                }
            }

            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Выполнено"));
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:МассДирект:{CountMessage}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Завершено"));
            Stat = false;
            Save();
        }
        public async void Pause()
        {
            EventFromMyClass(this,
                new MyEventMessage(
                    $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Поставлено на паузу."));
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:МассДирект:{CountMessage}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Пауза"));
            Save();
            if (timer != null)
                timer.Dispose();
            ew.Reset();
        }

        public void Stop()
        {
            Stat = false;
            Save();
            EventFromMyClass(this,
                new MyEventMessage(
                    $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Остановлено."));
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
            return "МассДирект";
        }
        async void Delay()
        {
            int randomDelay = rnd.Next(setting.DelayMin, setting.DelayMax + 1);
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Задержка на {randomDelay} сек"));
            timer = new Timer(CancelDelay, null, 1000 * randomDelay, Timeout.Infinite);
            ew.Reset();
            ew.WaitOne();
        }

        void CancelDelay(object obj)
        {
            ew.Set();
        }

        void Save()
        {
            if (setting.ChekedDeleteBase)
            {
                string[] x = new string[usersIDcopy.Count];
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = Convert.ToString(usersID[i]);
                }
                System.IO.File.WriteAllLines(setting.FileNameBaseId, x);
            }
        }

        static string UpdateInfoUser(IResult<InstaUserInfo> userInfo)
        {
            string subscriptions = Convert.ToString(userInfo.Value.FollowingCount);
            string subscribers = Convert.ToString(userInfo.Value.FollowerCount);
            string publish = Convert.ToString(userInfo.Value.MediaCount);

            return subscriptions + ":" + subscribers + ":" + publish;
        }

    }
}
