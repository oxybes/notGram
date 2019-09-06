using InstaBot;
using InstaBot.SettingsTask;
using InstaSharper.API;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace WindowsFormsApp2.Task
{
    class TaskMasslike : ITask
    {
        static public event EventHandler<MyEventMessage> EventFromMyClass;
        static public event EventHandler<UpdateGridEvent> EventUpdateGrid;

        private CancellationTokenSource _source;

        private IInstaApi api;
        private SettingTaskToList setting;
        private ManualResetEvent ew;
        private List<long> usersID;
        private List<long> usersIDcopy;
        private Random rnd;
        private int CountLikes;
        private int CountPause;
        private IResult<InstaCurrentUser> userInfoLog;

        private Timer timer;
        public bool Stat { get; private set; } = false;

        public TaskMasslike(IInstaApi api, SettingTaskToList setting)
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
                CountLikes = 0;
                CountPause = 0;
                usersID = new List<long>();
                usersIDcopy = new List<long>();
                try
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback((s) => { MassLike(); }));
                }
                catch
                {
                    EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Лайкинг:{CountLikes}/{usersID.Count}: - : - : - :" +
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

        async void MassLike()
        {
            Stat = true;
            userInfoLog = await api.GetCurrentUserAsync();
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Масслайкинг запущен"));
            EventFromMyClass(this,
                new MyEventMessage(
                    $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Загружаю базу."));
            try
            {
                foreach (string str in File.ReadAllLines(setting.FileNameBase))
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
                EventFromMyClass(this,
                    new MyEventMessage(
                        $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] ОШИБКА: {e.Message}"));

            }
            EventUpdateGrid(this, new UpdateGridEvent(
                $"{userInfoLog.Value.UserName}:Лайкинг:{CountLikes}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                $"Выполняется"));

            foreach (long id in usersID)
            {
                try
                {
                    if (_source == null || _source.IsCancellationRequested)
                        break;

                    if (setting.ChekedSkipSubscriber)
                    {
                        var x = await api.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(10));
                        var o = new InstaUserShort();
                        o.Pk = id;
                        if (x.Value.IndexOf(o) != -1)
                        {
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Подписчик с id: {id} пропущен"));
                            usersIDcopy.Remove(id);
                            Thread.Sleep(500);
                            continue;
                        }
                    }

                    int pages = (int)setting.LikeAtUserMax;
                    var userInfo = await api.GetUserInfoByIdAsync(id);
                    Thread.Sleep(100);
                    var media = await api.GetUserMediaAsync(
                            userInfo.Value.Username,
                            PaginationParameters.MaxPagesToLoad(pages % 18 == 0 ? pages : pages + 1)); //Учет загруки страаниц
                    var mediaList = media.Value.ToList();

                    int random = rnd.Next((int)setting.LikeAtUserMin - 1, (int)setting.LikeAtUserMax);

                    for (int i = 0; i < random; i++) //Учет кол-во лайков на пользователя
                    {
                        if (mediaList.Count > i && setting.LikeUnderPublicMin <= mediaList[i].LikesCount && mediaList[i].LikesCount <= setting.LikeUnderPublicMax) //Учет настройки лайков под публикацией
                        {
                            if (_source == null || _source.IsCancellationRequested)
                                break;

                            await api.LikeMediaAsync(mediaList[i].Pk);
                            CountLikes++;
                            CountPause++;

                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Поставил лайк пользователю {userInfo.Value.Username}. Кол-во лайков: {CountLikes}"));
                            EventUpdateGrid(this, new UpdateGridEvent(
                                $"{userInfoLog.Value.UserName}:Лайкинг:{CountLikes}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                $"Выполняется"));

                            if (setting.ChekedDeleteInBaseAfterLike)
                            {
                                usersIDcopy.Remove(id);
                            }

                            Delay();

                            if (setting.ChekedPause)
                            {
                                if (CountPause >= setting.PauseLimit)
                                {
                                    CountPause = 0;
                                    EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Лайкинг:{CountLikes}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                                              $"Пауза"));
                                    EventFromMyClass(this,
                                        new MyEventMessage(
                                            $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Пауза на " +
                                            setting.PauseTime + " минут "));
                                    if (timer != null)
                                        timer.Dispose();
                                    timer = new Timer(CancelDelay, null, 60000 * (int)setting.PauseTime, Timeout.Infinite);
                                    ew.Reset();
                                    ew.WaitOne();
                                }
                            }
                        }
                        else
                        {
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Недостаточно лайков под постом пользователя {userInfo.Value.Username}. Пропуск"));
                            if (setting.ChekedDeleteInBaseAfterLike)
                            {
                                usersIDcopy.Remove(id);
                            }
                            Thread.Sleep(1000);
                        }
                    }
            }
            catch (Exception e)
            {
                EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] ОШИБКА : {e.Message}"));
                continue;
            }
        }
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Выполнено"));
            EventUpdateGrid(this, new UpdateGridEvent(
                $"{userInfoLog.Value.UserName}:Лайкинг:{CountLikes}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                $"Завершено"));
            Stat = false;
            Save();
        }
        public async void Pause()
        {
            EventFromMyClass(this,
                new MyEventMessage(
                    $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Поставлено на паузу."));
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Лайкинг:{CountLikes}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Пауза"));
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
            return "МассЛайк";
        }
        void Delay()
        {
            int randomDelay = rnd.Next((int)setting.DelayMin, (int)setting.DelayMax + 1);
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
            if (setting.ChekedDeleteInBaseAfterLike)
            {
                string[] x = new string[usersIDcopy.Count];
                for (int i = 0; i < x.Length; i++)
                {
                    x[i] = Convert.ToString(usersID[i]);
                }
                System.IO.File.WriteAllLines(setting.FileNameBase, x);
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
