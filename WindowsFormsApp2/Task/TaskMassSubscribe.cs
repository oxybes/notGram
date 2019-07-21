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
    class TaskMassSubscribe
    {
        InstaSharper.API.IInstaApi api;
        SettingTaskSubscribe setting;

        List<long> usersID;
        List<long> usersIDcopy;
        IResult<InstaMediaList> media;
        List<InstaMedia> mediaList;

        Random rnd;

        public int CountSubscribe { get; private set; }

        public event EventHandler<MyEventMessage> EventFromMyClass;

        bool pause;
        bool cancel;

        public TaskMassSubscribe(InstaSharper.API.IInstaApi api, SettingTaskSubscribe setting)
        {
            this.api = api;
            this.setting = setting;
            usersID = new List<long>();
            usersIDcopy = new List<long>();
            CountSubscribe = 0;
            rnd = new Random();
            pause = false;
            cancel = false;
        }

        public void Start()
        {
            EventFromMyClass(this, new MyEventMessage("Массфоловинг запущен\n"));
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
            Subscribe();
        }

        public async void Subscribe()
        {
            foreach (long id in usersID)
            {
                try
                {
                    while(pause)
                    {
                        Thread.Sleep(1000);
                    }

                    if (cancel)
                    {
                        return;
                    }

                    var userInfo = await api.GetUserInfoByIdAsync(id);

                    if (setting.ChekedSkipSubscriber) //Пропуск подписчиков
                    {
                        var x = await api.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(100));
                        var o = new InstaUserShort();
                        o.Pk = id;
                        if (x.Value.IndexOf(o) != -1)
                        {
                            EventFromMyClass(this, new MyEventMessage($"Подписчик с ником: {userInfo.Value.Username} пропущен"));
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
                            EventFromMyClass(this, new MyEventMessage($"Приватный аккаунт {userInfo.Value.Username} пропущен"));
                        continue;
                    }

                    await api.FollowUserAsync(id); //Подписка
                    CountSubscribe++;
                    EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, " +
                        $"Подписался на пользователя с ником {userInfo.Value.Username}\n" +
                        $"Количество подписок: {CountSubscribe}"));

                    if (setting.ChekedLikingBySubscribe) //Учет лайков при подписке
                    {
                        media = await api.GetUserMediaAsync(
                            userInfo.Value.Username,
                            PaginationParameters.MaxPagesToLoad(getMaxPage((int)setting.LikingMax))); //Учет загруки страниц
                        mediaList = media.Value.ToList();

                        int random = rnd.Next(setting.LikingMin, setting.LikingMax + 1);

                        for (int i = 0; i < random; i++)
                        {
                            await api.LikeMediaAsync(mediaList[i].Pk);
                            EventFromMyClass(this, new MyEventMessage($"Поставил лайк пользователю с ником {userInfo.Value.Username}"));

                            int randomLikeDelay = rnd.Next(setting.DelayLikeMin, setting.DelayLikeMax + 1);
                            EventFromMyClass(this, new MyEventMessage($"Задержка на {randomLikeDelay} сек"));
                            Thread.Sleep(1000 * randomLikeDelay);
                        }
                    }

                    if (setting.ChekedDeleteAdfter)
                    {
                        usersIDcopy.Remove(id);
                    }

                    Delay();

                    if (setting.ChekedPause) //Учет паузы
                    {
                        if (CountSubscribe >= setting.PauseLimit)
                        {
                            Thread.Sleep(1000 * setting.PauseLimit);
                        }
                    }

                    if (CountSubscribe >= setting.LimitSubscribe) //Учет лимита подписок
                    {
                        EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Превышен лимит подписок"));
                        return;
                    }

                    EventFromMyClass(this, new MyEventMessage("\n"));
                }
                catch (Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"ОШИБКА: {e.Message}  {DateTime.Now.ToString("HH:mm:ss")}\n"));
                }
            }
        }

        void Delay()
        {
            int randomDelay = rnd.Next(setting.DelayMin, setting.DelayMax + 1);
            EventFromMyClass(this, new MyEventMessage($"Задержка на {randomDelay} сек"));
            Thread.Sleep(1000 * randomDelay);
        }

        private int getMaxPage(int likeAtUserMax)
        {
            if (likeAtUserMax % 18 == 0)
                return likeAtUserMax;
            else
                return likeAtUserMax + 1;
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
            EventFromMyClass(this, new MyEventMessage($"...Осстанавливаю...\n"));
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
