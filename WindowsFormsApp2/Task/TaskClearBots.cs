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
    class TaskClearBots:ITask
    {
        static public event EventHandler<MyEventMessage> EventFromMyClass;
        static public event EventHandler<UpdateGridEvent> EventUpdateGrid;

        private CancellationTokenSource _source;

        private IInstaApi api;
        private SettingTaskClearBots setting;
        private ManualResetEvent ew;
        private bool stop;
        private bool pause;
        private List<long> usersID;
        private Random rnd;
        private int CountBlock;
        private int CountPause;
        private Timer timer;
        private IResult<InstaCurrentUser> userInfoLog;
        public bool Stat { get; private set; } = false;
        private int count;

        public TaskClearBots(IInstaApi api, SettingTaskClearBots setting)
        {
            this.api = api;
            this.setting = setting;
            ew = new ManualResetEvent(true);
            count = 0;
        }

        public void Start()
        {
            if (_source == null)
            {
                _source = new CancellationTokenSource();
                rnd = new Random();
                CountBlock = 0;
                CountPause = 0;
                usersID = new List<long>();
                try
                {
                    ThreadPool.QueueUserWorkItem((s) => { ClearBots(); });
                }
                catch
                {
                    EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{usersID.Count}: - : - : - :" +
                                                              $"Забанен"));
                }
            }
            else
            {
                ew.Set();
            }
        }

        async void ClearBots()
        {
            Stat = true;
            userInfoLog = await api.GetCurrentUserAsync();
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Чистка от ботов запущена"));
            try
            {
                if (setting.FileNameExceptionId.Length != 0)
                {
                    string[] stringID = System.IO.File.ReadAllLines(setting.FileNameExceptionId);
                    foreach (string str in stringID)
                    {
                        try
                        {
                            usersID.Add(Convert.ToInt64(str));
                        }
                        catch { continue;}
                    }
                }
            }
            catch (Exception e)
            {
                EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] ОШИБКА: {e.Message}"));
            }

            var userInfo = await api.GetCurrentUserAsync();
            IResult<InstaUserShortList> x = null;

            if (setting.WhomClear.Equals("Подписчиков"))
            {
                x = await api.GetUserFollowersAsync(userInfo.Value.UserName, PaginationParameters.MaxPagesToLoad(2));
            }
            if (setting.WhomClear.Equals("Подписки"))
            {
                x = await api.GetUserFollowingAsync(userInfo.Value.UserName, PaginationParameters.MaxPagesToLoad(2));
            }
            if (x.Succeeded)
            {
                count = x.Value.Count;
                EventUpdateGrid(this, new UpdateGridEvent(
                    $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{x.Value.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                    $"Выполняется"));

                foreach (InstaUserShort user in x.Value)
                {
                    try
                    {
                        if (_source == null || _source.IsCancellationRequested)
                            break;


                        if (usersID.Count != 0) //Учет не отписки от определнных пользователей
                        {
                            bool flag = false;
                            foreach (long id in usersID)
                            {
                                if (user.Pk == id)
                                {
                                    EventFromMyClass(this,
                                        new MyEventMessage(
                                            $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Пользователь {user.UserName} пропущен. Запрет на отписку."));

                                    Delay();

                                    flag = true;
                                    break;
                                }
                            }

                            if (flag)
                                continue;
                        }

                        if (setting.LimitBlock <= CountBlock) //Учет лимита блокировок
                        {
                            EventFromMyClass(this,
                                new MyEventMessage(
                                    $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Превышен лимит блокировок. Останавливаю процесс."));
                            EventUpdateGrid(this, new UpdateGridEvent(
                                $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{x.Value.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                $"Завершено"));
                            return;
                        }

                        if (setting.ChekedPause) //Учет паузы
                        {
                            if (setting.PauseLimit <= CountPause)
                            {
                                CountPause = 0;
                                EventFromMyClass(this,
                                    new MyEventMessage(
                                        $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Пауза на " +
                                        setting.PauseTime + " минут"));
                                EventUpdateGrid(this, new UpdateGridEvent(
                                    $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{x.Value.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                    $"Пауза"));
                                if (timer != null)
                                    timer.Dispose();
                                timer = new Timer(CancelDelay, null, 60000 * (int)setting.PauseTime, Timeout.Infinite);
                                ew.Reset();
                                ew.WaitOne();
                            }
                        }


                        var info = await api.GetUserInfoByIdAsync(user.Pk);
                        if (info.Succeeded == false)
                        {
                            Thread.Sleep(500);
                            continue;
                        }

                        if (setting.CheckedNoAvatarUser) //Если нет автарки
                        {
                            if (info.Value.HasAnonymousProfilePicture)
                            {
                                await api.BlockUserAsync(user.Pk);
                                CountBlock++;
                                CountPause++;
                                EventFromMyClass(this,
                                    new MyEventMessage(
                                        $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Заблокирован пользователя с ником: {user.UserName}. Количество блокировок: {CountBlock}"));
                                EventUpdateGrid(this, new UpdateGridEvent(
                                    $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{x.Value.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                    $"Выполняется"));

                                if (!setting.ChekedUserBlock)
                                {
                                    await api.UnBlockUserAsync(user.Pk);
                                    EventFromMyClass(this,
                                        new MyEventMessage(
                                            $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Разблокирован пользователь с ником: {user.UserName}"));
                                }

                                Delay(); //Учет задержки
                                continue;
                            }
                        }

                        if (setting.CheckedPublicCountLess) //Публикаций меньше
                        {
                            int countPublic = Convert.ToInt32(info.Value.MediaCount);
                            if (countPublic < setting.PublicCountLess)
                            {
                                await api.BlockUserAsync(user.Pk);
                                CountBlock++;
                                CountPause++;
                                EventFromMyClass(this,
                                    new MyEventMessage(
                                        $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Заблокирован пользователь с ником: {user.UserName}. Количество блокировок: {CountBlock}"));
                                EventUpdateGrid(this, new UpdateGridEvent(
                                    $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{x.Value.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                    $"Выполняется"));
                                if (!setting.ChekedUserBlock)
                                {
                                    await api.UnBlockUserAsync(user.Pk);
                                    EventFromMyClass(this,
                                        new MyEventMessage(
                                            $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Разблокирован пользователь с ником: {user.UserName}"));
                                }

                                Delay(); //Учет задержки
                                continue;
                            }
                        }

                        if (setting.ChekedFollowsCountLess)
                        {
                            int countFollower = Convert.ToInt32(info.Value.FollowerCount);
                            if (countFollower < setting.FollowsCountLess)
                            {
                                await api.BlockUserAsync(user.Pk);
                                CountBlock++;
                                CountPause++;
                                EventFromMyClass(this,
                                    new MyEventMessage(
                                        $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Заблокирован пользователь с ником: {user.UserName}. Количество блокировок: {CountBlock}"));
                                EventUpdateGrid(this, new UpdateGridEvent(
                                    $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{x.Value.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                    $"Выполняется"));
                                if (!setting.ChekedUserBlock)
                                {
                                    await api.UnBlockUserAsync(user.Pk);
                                    EventFromMyClass(this,
                                        new MyEventMessage(
                                            $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Разблокирован пользователь с ником: {user.UserName}"));
                                }

                                Delay(); //Учет задержки
                                continue;
                            }
                        }

                        if (setting.ChekedSubscriptionsLess)
                        {
                            int countSubscriptions = Convert.ToInt32(info.Value.FollowingCount);
                            if (countSubscriptions < setting.SubscriptionsLess)
                            {
                                await api.BlockUserAsync(user.Pk);
                                CountBlock++;
                                CountPause++;
                                EventFromMyClass(this,
                                    new MyEventMessage(
                                        $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Заблокирован пользователь с ником: {user.UserName}. Количество блокировок: {CountBlock}"));
                                EventUpdateGrid(this, new UpdateGridEvent(
                                    $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{x.Value.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                    $"Выполняется"));
                                if (!setting.ChekedUserBlock)
                                {
                                    await api.UnBlockUserAsync(user.Pk);
                                    EventFromMyClass(this,
                                        new MyEventMessage(
                                            $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Разблокирован пользователь с ником: {user.UserName}"));
                                }

                                Delay(); //Учет задержки
                                continue;
                            }
                        }

                        if (setting.ChekedSubscriptionsMore)
                        {
                            int countSubscriptions = Convert.ToInt32(info.Value.FollowingCount);
                            if (countSubscriptions > setting.SubscriptionMore)
                            {
                                await api.BlockUserAsync(user.Pk);
                                CountBlock++;
                                CountPause++;
                                EventFromMyClass(this,
                                    new MyEventMessage(
                                        $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Заблокирован пользователь с ником: {user.UserName}. Количество блокировок: {CountBlock}"));
                                EventUpdateGrid(this, new UpdateGridEvent(
                                    $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{x.Value.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                    $"Выполняется"));
                                if (!setting.ChekedUserBlock)
                                {
                                    await api.UnBlockUserAsync(user.Pk);
                                    EventFromMyClass(this,
                                        new MyEventMessage(
                                            $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Разблокирован пользователь с ником: {user.UserName}"));
                                }

                                Delay(); //Учет задержки
                                continue;
                            }
                        }

                        Thread.Sleep(1000);
                    }

                    catch (Exception e)
                    {
                        EventFromMyClass(this,
                            new MyEventMessage(
                                $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] ОШИБКА: {e.Message}"));
                    }
                }
            }

            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{ DateTime.Now.ToString("HH:mm:ss")}] Выполнено."));
            EventUpdateGrid(this, new UpdateGridEvent(
                $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{x.Value.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                $"Завершено"));
            Stat = false;
        }
        
        public async void Pause()
        {
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}] Поставил на паузу."));
            EventUpdateGrid(this, new UpdateGridEvent(
                $"{userInfoLog.Value.UserName}:Чистка от ботов:{CountBlock}/{count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                $"Пауза"));
            if (timer != null)
                timer.Dispose();
            ew.Reset();
        }

        public void Stop()
        {
            Stat = false;
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
            return "Чистка от ботов";
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

        static string UpdateInfoUser(IResult<InstaUserInfo> userInfo)
        {
            string subscriptions = Convert.ToString(userInfo.Value.FollowingCount);
            string subscribers = Convert.ToString(userInfo.Value.FollowerCount);
            string publish = Convert.ToString(userInfo.Value.MediaCount);

            return subscriptions + ":" + subscribers + ":" + publish;
        }
    }
}
