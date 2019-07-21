using InstaBot.SettingsTask;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InstaBot.Task
{
    class TaskClearOfBots
    {
        InstaSharper.API.IInstaApi api;
        SettingTaskClearBots setting;

        List<long> usersID = new List<long>();
        Random rnd;

        public int CountBlock{ get; private set; }

        public event EventHandler<MyEventMessage> EventFromMyClass;

        bool pause;
        bool cancel;

        public TaskClearOfBots(InstaSharper.API.IInstaApi api, SettingTaskClearBots setting)
        {
            this.api = api;
            this.setting = setting;
            CountBlock = 0;
            rnd = new Random();
            pause = false;
            cancel = false;
        }

        public void Start()
        {
            EventFromMyClass(this, new MyEventMessage("Чистка от ботов запущена\n"));
            try
            {
                if (setting.FileNameExceptionId.Length != 0)
                {
                    string[] stringID = System.IO.File.ReadAllLines(setting.FileNameExceptionId);
                    foreach (string str in stringID)
                    {
                        usersID.Add(Convert.ToInt64(str));
                    }
                }
            }
            catch (Exception e)
            {
                EventFromMyClass(this, new MyEventMessage($"ОШИБКА: {e.Message} {e.TargetSite} {DateTime.Now}\n"));
            }
            ClearOfBots();
        }

        public async void ClearOfBots()
        {
            var userInfo = await api.GetCurrentUserAsync();
            IResult<InstaUserShortList> x = null;

            if (setting.WhomClear.Equals("Подписчиков"))
            {
                 x = await api.GetUserFollowersAsync(userInfo.Value.UserName, PaginationParameters.MaxPagesToLoad(2));
            }
            if(setting.WhomClear.Equals("Подписки"))
            {
                x = await api.GetUserFollowingAsync(userInfo.Value.UserName, PaginationParameters.MaxPagesToLoad(2));
            }

            foreach (InstaUserShort user in x.Value)
            {
                try
                {
                    if (cancel)
                        return;
                    while (pause)
                    {
                        Thread.Sleep(1000);
                    }


                    if (usersID.Count != 0) //Учет не отписки от определнных пользователей
                    {
                        foreach (long id in usersID)
                        {
                            if (user.Pk == id)
                            {
                                EventFromMyClass(this, new MyEventMessage($"Пользователь {user.UserName} пропущен. Исключение."));
                                Delay();
                                continue;
                            }
                        }
                    }
                    var info = await api.GetUserInfoByIdAsync(user.Pk);

                    if (setting.CheckedNoAvatarUser) //Если нет автарки
                    {
                        if (info.Value.HasAnonymousProfilePicture)
                        {
                            await api.BlockUserAsync(user.Pk);
                            CountBlock++;
                            EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Заблокировал пользователя с ником: {user.UserName}, количество блокировок: {CountBlock}"));
                            if (!setting.ChekedUserBlock)
                            {
                                await api.UnBlockUserAsync(user.Pk);
                                EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Разблокировал пользователя с ником: {user.UserName}"));
                            }
                            Delay(); //Учет задержки
                        }
                    }

                    if (setting.CheckedPublicCountLess) //Публикаций меньше
                    {
                        int countPublic = Convert.ToInt32(info.Value.MediaCount);
                        if (countPublic < setting.PublicCountLess)
                        {
                            await api.BlockUserAsync(user.Pk);
                            CountBlock++;
                            EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Заблокировал пользователя с ником: {user.UserName}, количество блокировок: {CountBlock}"));
                            if (!setting.ChekedUserBlock)
                            {
                                await api.UnBlockUserAsync(user.Pk);
                                EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Разблокировал пользователя с ником: {user.UserName}"));
                            }
                            Delay(); //Учет задержки
                        }
                    }

                    if (setting.ChekedFollowsCountLess)
                    {
                        int countFollower = Convert.ToInt32(info.Value.FollowerCount);
                        if (countFollower < setting.FollowsCountLess)
                        {
                            await api.BlockUserAsync(user.Pk);
                            CountBlock++;
                            EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Заблокировал пользователя с ником: {user.UserName}, количество блокировок: {CountBlock}"));
                            if (!setting.ChekedUserBlock)
                            {
                                await api.UnBlockUserAsync(user.Pk);
                                EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Разблокировал пользователя с ником: {user.UserName}"));
                            }
                            Delay(); //Учет задержки
                        }
                    }

                    if (setting.ChekedSubscriptionsLess)
                    {
                        int countSubscriptions = Convert.ToInt32(info.Value.FollowingCount);
                        if(countSubscriptions < setting.SubscriptionsLess)
                        {
                            await api.BlockUserAsync(user.Pk);
                            CountBlock++;
                            EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Заблокировал пользователя с ником: {user.UserName}, количество блокировок: {CountBlock}"));
                            if (!setting.ChekedUserBlock)
                            {
                                await api.UnBlockUserAsync(user.Pk);
                                EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Разблокировал пользователя с ником: {user.UserName}"));
                            }
                            Delay(); //Учет задержки
                        }
                    }

                    if (setting.ChekedSubscriptionsMore)
                    {
                        int countSubscriptions = Convert.ToInt32(info.Value.FollowingCount);
                        if (countSubscriptions > setting.SubscriptionMore)
                        {
                            await api.BlockUserAsync(user.Pk);
                            CountBlock++;
                            EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Заблокировал пользователя с ником: {user.UserName}, количество блокировок: {CountBlock}"));
                            if (!setting.ChekedUserBlock)
                            {
                                await api.UnBlockUserAsync(user.Pk);
                                EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Разблокировал пользователя с ником: {user.UserName}"));
                            }
                            Delay(); //Учет задержки
                        }
                    }

                   

                    if (setting.LimitBlock <= CountBlock) //Учет лимита блокировок
                    {
                        EventFromMyClass(this, new MyEventMessage("\nПревышен лимит блокировок"));
                        return;
                    }

                    if (setting.ChekedPause) //Учет паузы
                    {
                        if (setting.PauseLimit <= CountBlock)
                        {
                            EventFromMyClass(this, new MyEventMessage("Пауза на " + setting.PauseTime + "минут"));
                            Thread.Sleep(1000 * setting.PauseTime);
                        }
                    }
                }
                catch (Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"ОШИБКА: {e.Message} {e.TargetSite} {DateTime.Now}\n"));
                }
            }
            EventFromMyClass(this, new MyEventMessage("\nВыполнено"));
        }

        void Delay()
        {
            int randomDelay = rnd.Next(setting.DelayMin, setting.DelayMax + 1);
            EventFromMyClass(this, new MyEventMessage($"Задержка на {randomDelay} сек"));
            Thread.Sleep(1000 * randomDelay);
        }

        public void Pause()
        {
            EventFromMyClass(this, new MyEventMessage($"...Ставлю на паузу..."));
            pause = true;
        }

        public void Resume()
        {
            EventFromMyClass(this, new MyEventMessage($"...Продолжаю..."));
            pause = false;
        }

        public void Stop()
        {
            EventFromMyClass(this, new MyEventMessage($"..стоп.."));
            cancel = true;
        }

    }
}
