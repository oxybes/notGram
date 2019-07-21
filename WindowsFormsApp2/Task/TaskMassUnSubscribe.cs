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
    class TaskMassUnSubscribe
    {
        InstaSharper.API.IInstaApi api;
        SettingTaskUnSubscribe setting;

        List<long> usersID;
        List<long> usersIDcopy;
        Random rnd;

        bool pause;
        bool cancel;
        public int CountUnSubscribe { get; private set; }

        public event EventHandler<MyEventMessage> EventFromMyClass;


        public TaskMassUnSubscribe(InstaSharper.API.IInstaApi api, SettingTaskUnSubscribe setting)
        {
            this.api = api;
            this.setting = setting;
            usersID = new List<long>();
            usersIDcopy = new List<long>();
            CountUnSubscribe = 0;
            rnd = new Random();
            pause = false;
            cancel = false;
        }

        public void Start()
        {
            EventFromMyClass(this, new MyEventMessage("Массотписка запущена\n"));
            try
            {
                string[] stringID = System.IO.File.ReadAllLines(setting.FileNameBaseId);
                foreach (string str in stringID)
                {
                    usersID.Add(Convert.ToInt64(str));
                    usersIDcopy.Add(Convert.ToInt64(str));
                }
            }
            catch (Exception e)
            {
                EventFromMyClass(this, new MyEventMessage($"ОШИБКА: {e.Message} {e.TargetSite} {DateTime.Now}\n"));
            }
            if (setting.WhatDoing != null && setting.WhatDoing.Equals("Отписываться по списку из файла"))
                UnSubscribeToList();
            if (setting.WhatDoing != null && setting.WhatDoing.Equals("Отписываться от всех"))
                UnSubscribeAll();
            if (setting.WhatDoing != null && setting.WhatDoing.Equals("Отписываться от тех кто не подписан на вас"))
                UnSubscribeDontFollow();
        }

        public async void UnSubscribeToList()
        {
            foreach (long id in usersID)
            {
                try
                {
                    while (pause)
                    {
                        Thread.Sleep(1000);
                    }

                    if (cancel)
                    {
                        return;
                    }

                    var userInfo = await api.GetUserInfoByIdAsync(id);

                    if (setting.FileNameBaseId != null && setting.FileNameDontUnSubscribeId.Length != 0) //Учет не отписки от определнных пользователей
                    {
                        var stringId = setting.FileNameDontUnSubscribeId.Split(' ');
                        foreach (string idDont in stringId)
                        {
                            if (id == Convert.ToInt64(idDont))
                            {
                                EventFromMyClass(this, new MyEventMessage($"Пропущен пользователь {userInfo.Value.Username}. Является исключением"));
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

                EventFromMyClass(this, new MyEventMessage($"Отписался от пользователя с ником {userInfo.Value.Username}, количество отписок: {CountUnSubscribe}"));

                    Delay(); //Учет задержки


                    if (setting.LimitUnSubscribe <= CountUnSubscribe) //Учет лимита отписок
                    {
                        EventFromMyClass(this, new MyEventMessage($"\nПревышен лимит подписок"));
                        return;
                    }

                    if (setting.CheckedPause) //Учет паузы
                    {
                        if (setting.PauseLimit <= CountUnSubscribe)
                        {
                            EventFromMyClass(this,new MyEventMessage("Пауза на " + setting.PauseLimit + "минут"));
                            Thread.Sleep(1000 * setting.PauseTime);
                        }
                    }
                }
                catch (Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"ошибка: {e.Message}"));
                }
            }
            EventFromMyClass(this, new MyEventMessage($"Выполнено"));
        }

        public async void UnSubscribeAll()
        {
            var userInfo = await api.GetCurrentUserAsync();
            var x = await api.GetUserFollowingAsync(userInfo.Value.UserName, PaginationParameters.MaxPagesToLoad(2));
            foreach (InstaUserShort user in x.Value)
            {
                try
                {
                    while (pause)
                    {
                        Thread.Sleep(1000);
                    }

                    if (cancel)
                    {
                        return;
                    }


                    if (setting.FileNameBaseId != null && setting.FileNameDontUnSubscribeId.Length != 0) //Учет не отписки от определнных пользователей
                    {
                        var stringId = setting.FileNameDontUnSubscribeId.Split(' ');
                        foreach (string id in stringId)
                        {
                            if (user.Pk == Convert.ToInt64(id))
                            {
                                EventFromMyClass(this, new MyEventMessage($"Пропущен пользователь {user.UserName}. Является исключением"));
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
                    EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Отписался от пользователя с ником: {user.UserName}, количество отписок: {CountUnSubscribe}"));

                    Delay(); //Учет задержки

                    if (setting.LimitUnSubscribe <= CountUnSubscribe) //Учет лимита отписок
                    {
                        EventFromMyClass(this, new MyEventMessage("\nПревышен лимит подписок"));
                        return;
                    }

                    if (setting.CheckedPause) //Учет паузы
                    {
                        if (setting.PauseLimit <= CountUnSubscribe)
                        {
                            EventFromMyClass(this,new MyEventMessage("Пауза на " + setting.PauseLimit + "минут"));
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

        async void UnSubscribeDontFollow()
        {
            var follow = await api.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(2));

            var userInfo = await api.GetCurrentUserAsync();
            var x = await api.GetUserFollowingAsync(userInfo.Value.UserName, PaginationParameters.MaxPagesToLoad(2));
            foreach (InstaUserShort user in x.Value)
            {
                try
                {
                    while (pause)
                    {
                        Thread.Sleep(1000);
                    }

                    if(cancel)
                    {
                        return;
                    }

                    if (setting.FileNameBaseId != null && setting.FileNameDontUnSubscribeId.Length != 0) //Учет не отписки от определнных пользователей
                    {
                        var stringId = setting.FileNameDontUnSubscribeId.Split(' ');
                        foreach (string id in stringId)
                        {
                            if (user.Pk == Convert.ToInt64(id))
                            {
                                EventFromMyClass(this, new MyEventMessage($"Пропущен пользователь {user.UserName}. Является исключением"));
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
                        EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Отписался от пользователя с ником: {user.UserName}, количество отписок: {CountUnSubscribe}"));

                        Delay(); //Учет задержки

                        if (CountUnSubscribe >= setting.LimitUnSubscribe) //Учет лимита отписок
                        {
                            EventFromMyClass(this, new MyEventMessage("\nПревышен лимит подписок"));
                            return;
                        }

                        if (setting.CheckedPause) //Учет паузы
                        {
                            if (setting.PauseLimit <= CountUnSubscribe)
                            {
                                EventFromMyClass(this, new MyEventMessage("Пауза на " + setting.PauseLimit + "минут"));
                                Thread.Sleep(1000 * setting.PauseTime);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"ОШИБКА: {e.Message} {e.TargetSite} {DateTime.Now}\n"));
                }
            }
            EventFromMyClass(this, new MyEventMessage("Выполнено"));
        }

        void Delay()
        {
            int random = rnd.Next(setting.DelayMin, setting.DelayMax + 1);
            EventFromMyClass(this, new MyEventMessage($"Задержка на {random} сек"));
            Thread.Sleep(1000 * rnd.Next(setting.DelayMin, setting.DelayMax + 1));
        }

        public void Pause()
        {
            EventFromMyClass(this, new MyEventMessage($"...Ставлю на паузу..."));
            SaveBase();
            pause = true;
        }

        public void Resume()
        {
            EventFromMyClass(this, new MyEventMessage($"...Продолжаю..."));
            pause = false;
        }


        public void Stop()
        {
            EventFromMyClass(this, new MyEventMessage($"...Останавлива.\n..."));
            cancel = true;
        }
        void SaveBase()
        {
            string[] x = new string[usersIDcopy.Count];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Convert.ToString(usersID[i]);
            }
            System.IO.File.WriteAllLines(setting.FileNameBaseId, x);
        }

    }
}
