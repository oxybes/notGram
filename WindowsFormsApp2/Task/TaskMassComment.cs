using InstaBot;
using InstaBot.SettingsTask;
using InstaSharper.API;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace WindowsFormsApp2.Task
{
    class TaskMassComment:ITask
    {
        static public event EventHandler<MyEventMessage> EventFromMyClass;
        static public event EventHandler<UpdateGridEvent> EventUpdateGrid;

        private IInstaApi api;
        private SettingTaskComment setting;
        private ManualResetEvent ew;
        private CancellationTokenSource _source;
        private Timer timer;
        private List<long> usersID;
        private List<long> usersIDcopy;
        private Random rnd;
        private int CountComment;
        private int CountPause;
        private IResult<InstaCurrentUser> userInfoLog;
        public bool Stat { get; private set; } = false;

        public TaskMassComment(IInstaApi api, SettingTaskComment setting)
        {
            this.api = api;
            this.setting = setting;
            ew = new ManualResetEvent(true);

        }

        public void Start()
        {
            if (_source == null)
            {
                rnd = new Random();
                CountComment = 0;
                CountPause = 0;
                usersID = new List<long>();
                usersIDcopy = new List<long>();
                try
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback((s) => { MassComment().GetAwaiter().GetResult(); }));
                }
                catch
                {
                    EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Комментинг:{CountComment}/{usersID.Count}: - : - : - :" +
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

        async System.Threading.Tasks.Task MassComment()
        {
            Stat = true;
            userInfoLog = await api.GetCurrentUserAsync();
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Комментирование запущено"));
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
            }
            catch (Exception e)
            {
                EventFromMyClass(null,
                    new MyEventMessage(
                        $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] ОШИБКА: {e.Message}"));
            }

            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Комментинг:{CountComment}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Выполняется"));

            foreach (long id in usersID)
            {
                try
                {
                    if (_source == null || _source.IsCancellationRequested)
                        break;

                    var infoUser = await api.GetUserInfoByIdAsync(id);

                    int pages = setting.CountCommnetUnderPublish;
                    Thread.Sleep(100);
                    var media = await api.GetUserMediaAsync(
                            infoUser.Value.Username,
                            PaginationParameters.MaxPagesToLoad(pages % 18 == 0 ? pages : pages + 1)); //Учет загруки страниц
                    var mediaList = media.Value.ToList();

                    for (int i = 0; i < setting.CountPublishComment; i++)
                    {
                        if (_source == null || _source.IsCancellationRequested)
                            break;

                        for (int y = 0; y < setting.CountCommnetUnderPublish; y++)
                        {
                            if (_source == null || _source.IsCancellationRequested)
                                break;

                            int random = rnd.Next(0, setting.Message.Length);
                            await api.CommentMediaAsync(mediaList[0].Pk, setting.Message[random]);
                            CountComment++;
                            CountPause++;
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Прокомментировал запись пользователя: {infoUser.Value.Username}. Количество комментариев: {CountComment}"));
                            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Комментинг:{CountComment}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                                      $"Выполняется"));
                            if (y != setting.CountCommnetUnderPublish - 1)
                            {
                                int randomDelayUser = rnd.Next(setting.DelayOneUserMin, setting.DelayOneUserMax + 1);
                                EventFromMyClass(this,
                                    new MyEventMessage(
                                        $"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Задержка на пользователя {randomDelayUser} сек"));
                                if (timer != null)
                                    timer.Dispose();
                                timer = new Timer(CancelDelay, null, 1000 * randomDelayUser, Timeout.Infinite);
                                ew.Reset();
                                ew.WaitOne();
                            } //Учет задержки на пользователя      
                        }
                    }

                    if (setting.ChekedDeleteBase)
                    {
                        usersIDcopy.Remove(id);
                    }


                    Delay(); //Задержка в сек.

                    if (setting.CommentCountMax <= CountComment) //Проверка лимита комментариев
                    {
                        EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Превышено максимальное количество комментариев. Завершение задачи."));
                        Save();
                        EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Комментинг:{CountComment}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                                  $"Завершено"));
                        return;
                    }

                    if (setting.CheckedPause) //Учет паузы
                    {
                        if (setting.PauseLimit <= CountPause)
                        {
                            CountPause = 0;
                            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Пауза на " + setting.PauseTime + " минут"));
                            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Комментинг:{CountComment}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                                      $"Пауза"));
                            if (timer != null)
                                timer.Dispose();
                            timer = new Timer(CancelDelay, null, 1000 * setting.PauseTime, Timeout.Infinite);
                            ew.Reset();
                            ew.WaitOne();
                        }
                    }
                }

                catch (Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] ОШИБКА: {e.Message}"));
                    continue;
                }
            }

            Stat = false;
            EventFromMyClass(this, new MyEventMessage($"[{userInfoLog.Value.UserName}][{DateTime.Now.ToString("HH:mm:ss")}][{Info()}] Выполнено"));
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Комментинг:{CountComment}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Завершено"));
            Save();
            
        }
        public async void Pause()
        {
            EventFromMyClass(this,
                new MyEventMessage(
                    $"[{userInfoLog.Value.UserName}][{DateTime.Now:HH:mm:ss}][{Info()}] Поставлено на паузу."));
            EventUpdateGrid(this, new UpdateGridEvent($"{userInfoLog.Value.UserName}:Комментинг:{CountComment}/{usersID.Count}:{UpdateInfoUser(await api.GetUserInfoByIdAsync(userInfoLog.Value.Pk))}:" +
                                                      $"Пауза"));
            Save();
            if (timer != null)
                timer.Dispose();
            ew.Reset();
        }

        public void Stop()
        {
            Save();
            Stat = false;
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
            return "МассКоммент";
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
