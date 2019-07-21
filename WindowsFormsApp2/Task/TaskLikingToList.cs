using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InstaBot.SettingsTask;
using InstaSharper;
using InstaSharper.Classes;
using InstaSharper.Classes.Models;

namespace InstaBot
{
    public class TaskLikingToList
    {
        InstaSharper.API.IInstaApi api;
        SettingTaskToList setting;
        string[] stringId;

        List<long> usersID;
        List<long> usersIDcopy;
        IResult<InstaMediaList> media;
        List<InstaMedia> mediaList;
        Random rnd;

        bool pause;
        bool cancel;

        public int CountLikes { get; private set; }

        public event EventHandler<MyEventMessage> EventFromMyClass;

        public TaskLikingToList(InstaSharper.API.IInstaApi api, SettingTaskToList setting)
        {
            this.api = api;
            this.setting = setting;
            stringId = System.IO.File.ReadAllLines(setting.FileNameBase);
            usersID = new List<long>();
            usersIDcopy = new List<long>();
            CountLikes = 0;
            rnd = new Random();
            pause = false;
            cancel = false;
        }

        public void Start()
        {
            EventFromMyClass(this, new MyEventMessage("Масслайкинг запущен\n"));
            try
            {
                foreach (string str in stringId)
                {
                    usersID.Add(Convert.ToInt64(str));
                    usersIDcopy.Add(Convert.ToInt64(str));
                }
            }
            catch(Exception e)
            {
                EventFromMyClass(this, new MyEventMessage($"ОШИБКА: {e.Message}\n"));
                return;
            }
            LinkingUserToList();
        }

        async void LinkingUserToList()
        {
            foreach (long id in usersID)
            {
                try
                {
                    if (cancel)
                        return;
                    while (pause)
                    {
                        Thread.Sleep(500);
                    }

                    var x = await api.GetCurrentUserFollowersAsync(PaginationParameters.MaxPagesToLoad(100));

                    if(SkipFollowers(id,x))
                    {
                        usersIDcopy.Remove(id);
                        continue;
                    }

                    var userInfo = await api.GetUserInfoByIdAsync(id);
                    media = await api.GetUserMediaAsync(
                            userInfo.Value.Username,
                            PaginationParameters.MaxPagesToLoad(getMaxPage((int)setting.LikeAtUserMax))); //Учет загруки страаниц
                    mediaList = media.Value.ToList();

                    int random = rnd.Next((int)setting.LikeAtUserMin - 1, (int)setting.LikeAtUserMax + 1);

                    for (int i = 0; i < random; i++) //Учет кол-во лайков на пользователя
                    {
                        if (ChekedLikeUnderPublic(mediaList[i].LikesCount)) //Учет настройки лайков под публикацией
                        {
                            await api.LikeMediaAsync(mediaList[i].Pk);
                            CountLikes++;
                            EventFromMyClass(this, new MyEventMessage($"{DateTime.Now} поставил лайк пользователю {userInfo.Value.Username}, кол-во лайков: {CountLikes}"));

                            if(setting.ChekedDeleteInBaseAfterLike)
                            {
                                usersIDcopy.Remove(id);
                            }

                            while (pause)
                            {
                                Thread.Sleep(500);
                            }

                            Delay();//Учет задержки

                            ChekedPause(); //Проверка паузы
                        }
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    continue;
                }
                catch (Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"ОШИБКА : {e.Message}"));
                    continue;
                }         
            }
        }

         bool SkipFollowers(long id, IResult<InstaUserShortList> x)
         {
            if (setting.ChekedSkipSubscriber) //Пропуск подписчиков
            {
                var o = new InstaUserShort();
                o.Pk = id;
                if (x.Value.IndexOf(o) != -1)
                {
                    EventFromMyClass(this, new MyEventMessage($"Подписчик с id: {id} пропущен"));
                }
                return true;
            }
            return false;
        }
         void Delay()
         {
            int randomDelay = rnd.Next((int)setting.DelayMin, (int)setting.DelayMax + 1);
            EventFromMyClass(this, new MyEventMessage($"Задержка на {randomDelay} сек"));
            Thread.Sleep(1000 * randomDelay); //Учет задержки
         }
         void ChekedPause()
        {
            if (setting.ChekedPause)
            {
                if (CountLikes >= setting.PauseLimit)
                {
                    Thread.Sleep(60000 * (int)setting.PauseTime); //Пауза на кол-во минут
                    EventFromMyClass(this, new MyEventMessage($"Пауза на {setting.PauseTime} минут"));
                }
            }
        }

        int getMaxPage(int x) //Максимальная страница для загрузки записей в лист, 1 сраница - 18 записей
        {
            if (x % 18 == 0)
                return x;
            else 
                return x+1;
        }

        bool ChekedLikeUnderPublic(int countLikes)
        {
            if (setting.LikeUnderPublicMin <= countLikes && countLikes <= setting.LikeUnderPublicMax)
                return true;
            return false;
        }

        public void Pause()
        {
            EventFromMyClass(this, new MyEventMessage($"...Ставлю на паузу..."));
            SaveBase();
            pause = true;
        }

        public void Stop()
        {
            EventFromMyClass(this, new MyEventMessage($"Останавлив\nаю"));
            cancel = true;
        }

        public void Resume()
        {
            EventFromMyClass(this, new MyEventMessage($"...Продолжаю..."));
            pause = false;
        }

        void SaveBase()
        {
            string[] x = new string[usersIDcopy.Count];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Convert.ToString(usersID[i]);
            }
            System.IO.File.WriteAllLines(setting.FileNameBase, x);
        }

    }
}
