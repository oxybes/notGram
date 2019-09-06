using InstaBot;
using InstaBot.SettingsTask;
using InstaSharper.API;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Task
{
    class TaskSubscribe:ITask
    {
        static public event EventHandler<MyEventMessage> EventFromMyClass;
        static public event EventHandler<UpdateGridEvent> EventUpdateGrid;

        private CancellationTokenSource _source;

        private IInstaApi api;
        private SettingTaskSubscribe setting;
        private ManualResetEvent ew;
        private List<long> usersID;
        private List<long> usersIDcopy;
        private Random rnd;
        private int CountSubscribe;
        private int CountPause;
        private IResult<InstaCurrentUser> userInfoLog;
        public bool Stat { get; private set; } = false;
        private Timer timer;

        public TaskSubscribe(IInstaApi api, SettingTaskSubscribe setting)
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
                usersID = new List<long>();
                usersIDcopy = new List<long>();
                CountSubscribe = 0;
                rnd = new Random();
                CountSubscribe = 0;
                CountPause = 0;

                ThreadPool.QueueUserWorkItem(s =>
                {
                    try
                    {
                        StartSubscribe().GetAwaiter().GetResult();
                    }
                    catch
                    {
                        EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Подписка:{CountSubscribe}/{usersID.Count}: - : - : - :" +
                                                                  $"Забанен"));
                    }
                });
            }
            else
            {
                EventFromMyClass(this,
                    new MyEventMessage(
                        $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Продолжаю работу."));
                ew.Set();
            }
        }
        async System.Threading.Tasks.Task StartSubscribe()
        {
            Stat = true;
            userInfoLog = await api.GetCurrentUserAsync();
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Массфоловинг запущен."));
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
                    catch { continue; }
                }
                EventFromMyClass(this,
                    new MyEventMessage(
                        $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] База загружена."));
            }
            catch (Exception e)
            {
                EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] ОШИБКА: {e.Message}"));
            }

            EventFromMyClass(this,
                new MyEventMessage(
                    $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Начинаю подписку."));
            foreach (long id in usersID)
            {
                try
                {
                    
                    userInfoLog = await api.GetCurrentUserAsync();
                    var userInfo = await api.GetUserInfoByIdAsync(id);

                    if (_source == null || _source.IsCancellationRequested)
                        break;

                    if (setting.ChekedSkipSubscriber) //Пропуск подписчиков
                    {
                        var x = await api.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(100));
                        var o = new InstaUserShort();
                        o.Pk = id;
                        if (x.Value.IndexOf(o) != -1)
                        {
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Подписчик с ником: {userInfo.Value.Username} пропущен"));
                            if (setting.ChekedDeleteAdfter)
                            {
                                usersIDcopy.Remove(id);
                            }

                            Delay();
                            continue;
                        }
                    }

                    if (!setting.ChekedSendPrivateUser) //Учет приватных пользователей
                    {
                        if (userInfo.Value.IsPrivate)
                        {
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Приватный аккаунт {userInfo.Value.Username} пропущен"));
                            Delay();
                            continue;
                        }
                    }

                    await api.FollowUserAsync(id); //Подписка
                    CountSubscribe++;
                    CountPause++;

                    EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] " +
                        $"Подписался на пользователя с ником {userInfo.Value.Username}. " +
                        $"Количество подписок: {CountSubscribe}"));

                    EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Подписка:{CountSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                              $"Выполняется"));

                    Delay();
                    ew.WaitOne();

                    if (setting.ChekedLikingBySubscribe) //Учет лайков при подписке
                    {
                        int pages = setting.LikingMax;
                        var media = await api.GetUserMediaAsync(
                            userInfo.Value.Username,
                            PaginationParameters.MaxPagesToLoad(pages % 18 == 0 ? pages : pages + 1)); //Учет загруки страниц
                        var mediaList = media.Value.ToList();

                        int random = rnd.Next(setting.LikingMin, setting.LikingMax + 1);

                        for (int i = 0; i < random; i++)
                        {
                            if (_source == null || _source.IsCancellationRequested)
                                break;

                            await api.LikeMediaAsync(mediaList[i].Pk);
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Поставил лайк пользователю с ником {userInfo.Value.Username}"));

                            int randomLikeDelay = rnd.Next(setting.DelayLikeMin, setting.DelayLikeMax + 1);
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Задержка на {randomLikeDelay} сек"));
                            if (timer != null)
                                timer.Dispose();
                            timer = new Timer(CancelDelay,null,1000 * randomLikeDelay, Timeout.Infinite);
                            ew.Reset();
                            ew.WaitOne();
                        }
                    }

                    if (setting.ChekedDeleteAdfter)
                    {
                        usersIDcopy.Remove(id);
                    }

                    if (setting.ChekedPause) //Учет паузы
                    {
                        if (CountPause >= setting.PauseLimit)
                        {
                            CountPause = 0;
                            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Подписка:{CountSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                                      $"Пауза"));
                            EventFromMyClass(this,
                                new MyEventMessage(
                                    $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Пауза на " +
                                    setting.PauseTime + " минут "));
                            if (timer != null)
                                timer.Dispose();
                            timer = new Timer(CancelDelay, null, 60000 * setting.PauseTime, Timeout.Infinite);
                            ew.Reset();
                            ew.WaitOne();
                        }
                    }

                    if (CountSubscribe >= setting.LimitSubscribe) //Учет лимита подписок
                    {
                        EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Превышен лимит подписок"));
                        EventFromMyClass(this,
                            new MyEventMessage(
                                $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}] Выполнено"));
                        EventUpdateGrid(this, new UpdateGridEvent(
                            $"{userInfoLog.Value.UserName}:Подписка:{CountSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                            $"Завершено"));
                        return;
                    }

                }
                catch (Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] ОШИБКА: {e.Message}"));
                }
            }
            EventFromMyClass(this,
                    new MyEventMessage(
                        $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Задача завершена"));
                EventUpdateGrid(this, new UpdateGridEvent(
                    $"{userInfoLog.Value.UserName}:Подписка:{CountSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                    $"Завершено"));
                Stat = false;
                Save();
        }

        static string UpdateInfoUser(IResult<InstaUserInfo> userInfo)
        {
            string subscriptions = Convert.ToString(userInfo.Value.FollowingCount);
            string subscribers = Convert.ToString(userInfo.Value.FollowerCount);
            string publish = Convert.ToString(userInfo.Value.MediaCount);

            return subscriptions + ":" + subscribers + ":" + publish;
        }

        void Delay()
        {
            int randomDelay = rnd.Next(setting.DelayMin, setting.DelayMax + 1);
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Задержка на {randomDelay} сек"));
            timer = new Timer(CancelDelay, null, 1000 * randomDelay, Timeout.Infinite);
            ew.Reset();
        }
        void CancelDelay(object obj)
        {
            ew.Set();
        }

        void Save()
        {
            if (setting.ChekedDeleteAdfter)
            {
                string[] x = new string[usersIDcopy.Count];
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = Convert.ToString(usersID[i]);
                }
                System.IO.File.WriteAllLines(setting.FileNameBaseId, x);
            }
        }

        public async void Pause()
        {
            EventFromMyClass(this,
                new MyEventMessage(
                    $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Поставлено на паузу."));
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Подписка:{CountSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Пауза"));
            Save();
            if (timer != null)
                timer.Dispose();
            ew.Reset();
        }


        public string Info()
        {
            return "Подписка";
        }
        public async void Stop()
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
    }
}
