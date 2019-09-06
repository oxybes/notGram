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
    class TaskUnSubscribe:ITask
    {
        static public event EventHandler<MyEventMessage> EventFromMyClass;
        static public event EventHandler<UpdateGridEvent> EventUpdateGrid;

        private CancellationTokenSource _source;
        private Timer timer;

        private IInstaApi api;
        private SettingTaskUnSubscribe setting;
        private ManualResetEvent ew;
        private List<long> usersID;
        private List<long> usersIDcopy;
        private Random rnd;
        private int CountUnSubscribe;
        private int CountPause;
        private IResult<InstaCurrentUser> userInfoLog;
        public bool Stat { get; private set; } = false;

        public TaskUnSubscribe(IInstaApi api, SettingTaskUnSubscribe setting)
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
                CountUnSubscribe = 0;
                CountPause = 0;
                usersID = new List<long>();
                usersIDcopy = new List<long>();
                try
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback((s) => { ThreadMethod(); }));
                }
                catch
                {
                    EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Отписка:{CountUnSubscribe}/{usersID.Count}: - : - : - :" +
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

        void ThreadMethod()
        {
            Stat = true;
            if (setting.WhatDoing != null && setting.WhatDoing.Equals("Отписываться по списку из файла"))
                UnSubscribeToList(api, setting);
            if (setting.WhatDoing != null && setting.WhatDoing.Equals("Отписываться от всех"))
                UnSubscribeAll(api, setting);
            if (setting.WhatDoing != null && setting.WhatDoing.Equals("Отписываться от тех, кто не подписан"))
                UnSubscribeDontFollow(api, setting);
        }


         async void UnSubscribeToList(IInstaApi api, SettingTaskUnSubscribe setting)
         {
             userInfoLog = await api.GetCurrentUserAsync();
            EventFromMyClass(this, new MyEventMessage($"[{(await api.GetCurrentUserAsync()).Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Массотписка запущена"));
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Отписка:{CountUnSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Выполняется"));
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
                EventFromMyClass(this, new MyEventMessage($"[{DateTime.Now.ToString("HH:mm:ss")}] ОШИБКА: {e.Message} {e.TargetSite} {DateTime.Now}"));
            }

            foreach (long id in usersID)
            {
                try
                {
                    if (_source == null || _source.IsCancellationRequested)
                        break;

                    var userInfo = await api.GetUserInfoByIdAsync(id);

                    if (setting.FileNameBaseId != null && setting.FileNameDontUnSubscribeId.Length != 0) //Учет не отписки от определнных пользователей
                    {
                        var stringId = setting.FileNameDontUnSubscribeId.Split(' ');
                        foreach (string idDont in stringId)
                        {
                            if (id == Convert.ToInt64(idDont))
                            {
                                EventFromMyClass(null, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Пропущен пользователь {userInfo.Value.Username}. Является исключением"));
                                Delay();
                                continue;
                            }
                        }
                    }

                    if (setting.ChekedUnSubscribeBlock) //Учёт отписки через блокировку
                        await api.BlockUserAsync(id);
                    else
                        await api.UnFollowUserAsync(id);
                    CountUnSubscribe++;
                    CountPause++;
                    EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Отписался от пользователя с ником {userInfo.Value.Username}. Kоличество отписок: {CountUnSubscribe}"));

                    EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Отписка:{CountUnSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                              $"Выполняется"));

                    if (_source == null || _source.IsCancellationRequested)
                        break;

                    Delay();

                    if (setting.LimitUnSubscribe <= CountUnSubscribe) //Учет лимита отписок
                    {
                        EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Превышен лимит подписок"));
                        EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Отписка:{CountUnSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                                  $"Завершено"));
                        Save();
                        return;
                    }

                    if (setting.CheckedPause) //Учет паузы
                    {
                        if (setting.PauseLimit <= CountPause)
                        {
                            CountPause = 0;
                            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Отписка:{CountUnSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                                      $"Пауза"));
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Пауза на " + setting.PauseTime + " минут"));
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
                    EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] ОШИБКА: {e.Message}"));
                }
            }
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Выполнено"));
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Отписка:{CountUnSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Завершено"));
            Save();
            Stat = false;
         }

         async void UnSubscribeAll(IInstaApi api, SettingTaskUnSubscribe setting)
        {
            userInfoLog = await api.GetCurrentUserAsync();

            var x = await api.GetUserFollowingAsync(userInfoLog.Value.UserName, PaginationParameters.MaxPagesToLoad(2));
            var z = await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk);

            EventUpdateGrid(this, new UpdateGridEvent(
                $"{userInfoLog.Value.UserName}:Отписка от всех:{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                $"Выполняется"));
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Массотписка запущена"));

            foreach (InstaUserShort user in x.Value)
            {
                try
                {
                    if (_source == null || _source.IsCancellationRequested)
                        break;

                    if (setting.FileNameBaseId != null && setting.FileNameDontUnSubscribeId.Length != 0) //Учет не отписки от определнных пользователей
                    {
                        var stringId = setting.FileNameDontUnSubscribeId.Split(' ');
                        foreach (string id in stringId)
                        {
                            if (user.Pk == Convert.ToInt64(id))
                            {
                                EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Пропущен пользователь {user.UserName}. Является исключением"));

                                Delay();
                                continue;
                            }
                        }
                    }

                    if (setting.ChekedUnSubscribeBlock) //Учёт отписки через блокировку
                        await api.BlockUserAsync(user.Pk);
                    else
                        await api.UnFollowUserAsync(user.Pk);
                    CountUnSubscribe++;
                    CountPause++;
                    EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Отписался от пользователя с ником: {user.UserName}. Kоличество отписок: {CountUnSubscribe}"));
                    EventUpdateGrid(this, new UpdateGridEvent(
                        $"{userInfoLog.Value.UserName}:Отписка от всех:{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                        $"Выполняется"));

                    if (_source == null || _source.IsCancellationRequested)
                        break;
                    Delay();//Учет задержки

                    if (setting.LimitUnSubscribe <= CountUnSubscribe) //Учет лимита отписок
                    {
                        EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Превышен лимит подписок"));
                        EventUpdateGrid(this, new UpdateGridEvent(
                            $"{userInfoLog.Value.UserName}:Отписка от всех:{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                            $"Завершено"));
                        return;
                    }

                    if (setting.CheckedPause) //Учет паузы
                    {
                        if (setting.PauseLimit <= CountPause)
                        {
                            CountPause = 0;
                            EventUpdateGrid(this, new UpdateGridEvent(
                                $"{userInfoLog.Value.UserName}:Отписка от всех:{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                $"Пауза"));
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Пауза на " + setting.PauseTime + " минут"));
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
                    EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] ОШИБКА: {e.Message}"));
                }
            }
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Выполнено"));
            EventUpdateGrid(this, new UpdateGridEvent(
                $"{userInfoLog.Value.UserName}:Отписка от всех:{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                $"Завершено"));
            Stat = false;
        }

         async void UnSubscribeDontFollow(IInstaApi api, SettingTaskUnSubscribe setting)
        {
            userInfoLog = await api.GetCurrentUserAsync();
            var follow = await api.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(2));
            var x = await api.GetUserFollowingAsync(userInfoLog.Value.UserName, PaginationParameters.MaxPagesToLoad(2));
            var z = await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk);
            EventUpdateGrid(this, new UpdateGridEvent(
                $"{userInfoLog.Value.UserName}:Отписка(кто не подписан):{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                $"Выполняется"));
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Массотписка запущена"));

            foreach (InstaUserShort user in x.Value)
            {
                try
                {
                    if (_source == null || _source.IsCancellationRequested)
                        break;


                    if (setting.FileNameBaseId != null && setting.FileNameDontUnSubscribeId.Length != 0) //Учет не отписки от определнных пользователей
                    {
                        var stringId = setting.FileNameDontUnSubscribeId.Split(' ');
                        foreach (string id in stringId)
                        {
                            if (user.Pk == Convert.ToInt64(id))
                            {
                                EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Пропущен пользователь {user.UserName}. Является исключением"));
                                Delay();
                                continue;
                            }
                        }
                    }
                    var userShort = new InstaUserShort();
                    userShort.Pk = user.Pk;

                    if (follow.Value.IndexOf(userShort) == -1)
                    {
                        if (setting.ChekedUnSubscribeBlock) //Учёт отписки через блокировку
                            await api.BlockUserAsync(user.Pk);
                        else
                            await api.UnFollowUserAsync(user.Pk);
                        CountUnSubscribe++;
                        CountPause++;
                        EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Отписался от пользователя с ником: {user.UserName}. Kоличество отписок: {CountUnSubscribe}"));
                        EventUpdateGrid(this, new UpdateGridEvent(
                            $"{userInfoLog.Value.UserName}:Отписка(кто не подписан):{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                            $"Выполняется"));

                        if (_source == null || _source.IsCancellationRequested)
                            break;

                        Delay();// Учет задержки

                        if (CountUnSubscribe >= setting.LimitUnSubscribe) //Учет лимита отписок
                        {
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{ DateTime.Now.ToString("HH:mm:ss") }] Превышен лимит подписок"));
                            EventUpdateGrid(this, new UpdateGridEvent(
                                $"{userInfoLog.Value.UserName}:Отписка(кто не подписан):{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                $"Завершено"));
                            return;
                        }

                        if (setting.CheckedPause) //Учет паузы
                        {
                            if (setting.PauseLimit <= CountUnSubscribe)
                            {
                                CountPause = 0;
                                EventUpdateGrid(this, new UpdateGridEvent(
                                    $"{userInfoLog.Value.UserName}:Отписка(кто не подписан):{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                    $"Пауза"));
                                EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Пауза на " + setting.PauseTime + " минут"));
                                if (timer != null)
                                    timer.Dispose();
                                timer = new Timer(CancelDelay, null, 60000 * setting.PauseTime, Timeout.Infinite);
                                ew.Reset();
                                ew.WaitOne();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] ОШИБКА: {e.Message}"));
                }
            }
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Выполнено"));
            EventUpdateGrid(this, new UpdateGridEvent(
                $"{userInfoLog.Value.UserName}:Отписка(кто не подписан):{CountUnSubscribe}/{z.Value.FollowingCount}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                $"Завершено"));
            Stat = false;
        }

        public async void Pause()
        {
            EventFromMyClass(this,
                new MyEventMessage(
                    $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Поставлено на паузу."));
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Отписка:{CountUnSubscribe}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
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
            return "Отписка";
        }
        void Delay()
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
            if (setting.ChekedDeleteBaseAfterUnSubscribe)
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
