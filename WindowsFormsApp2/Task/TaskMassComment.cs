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
    class TaskMassComment
    {
        InstaSharper.API.IInstaApi api;
        SettingTaskComment setting;
        List<IResult<InstaUserInfo>> userInfo = new List<IResult<InstaUserInfo>>();

        List<long> usersID;
        List<long> usersIDcopy;
        IResult<InstaMediaList> media;
        List<InstaMedia> mediaList;
        Random rnd;

        bool pause;
        bool cancel;

        public int CountComment { get; private set; }

        public event EventHandler<MyEventMessage> EventFromMyClass;


        public TaskMassComment(InstaSharper.API.IInstaApi api, SettingTaskComment setting)
        {
            this.api = api;
            this.setting = setting;
            usersID = new List<long>();
            usersIDcopy = new List<long>();
            CountComment = 0;
            rnd = new Random();
            pause = false;
            cancel = false;
        }

        public void Start()
        {
            EventFromMyClass(this, new MyEventMessage("Комментирование запущено\n"));
            try
            {
                string[] stringID = System.IO.File.ReadAllLines(setting.FileNameBaseId);
                foreach (string str in stringID)
                {
                    usersID.Add(Convert.ToInt64(str));
                    usersID.Add(Convert.ToInt64(str));
                }
            }
            catch (Exception e)
            {
                EventFromMyClass(this, new MyEventMessage($"ОШИБКА: {e.Message} {e.TargetSite} {DateTime.Now}\n"));
            }
            MassComments();
        }

        async void MassComments()
        {
            foreach (long id in usersID)
            {
                try
                {
                    if(cancel)
                        return;
                    while (pause)
                    {
                        Thread.Sleep(1000);
                    }

                    var infoUser = await api.GetUserInfoByIdAsync(id);

                    media = await api.GetUserMediaAsync(
                            infoUser.Value.Username,
                            PaginationParameters.MaxPagesToLoad(getMaxPage(setting.CountPublishComment))); //Учет загруки страниц
                    mediaList = media.Value.ToList();

                    for (int i = 0; i < setting.CountPublishComment; i++)
                    {
                        for (int y = 0; y < setting.CountCommnetUnderPublish; y++)
                        {
                            
                            int random = rnd.Next(0, setting.Message.Length);
                            await api.CommentMediaAsync(mediaList[i].Pk, setting.Message[random]);
                            CountComment++;
                            EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Прокомментировал запись: {infoUser.Value.Username}, количество комментариев: {CountComment}"));

                            DelayUser();
                        }
                    }

                    if(setting.ChekedDeleteBase)
                    {
                        usersIDcopy.Remove(id);
                    }

                    Delay();

                    if(setting.CommentCountMax <= CountComment) //Проверка лимита комментариев
                    {
                        EventFromMyClass(this, new MyEventMessage("Превышено максимальное количество комментариев. Завершение задачи."));
                        return;
                    }

                    CheckedPause();                 
                }

                catch (Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"ОШИБКА : {e.Message}"));
                    continue;
                }
            }
            EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, Выполнено"));
        }

        int getMaxPage(int x) //Максимальная страница для загрузки записей в лист, 1 сраница - 18 записей
        {
            if (x % 18 == 0)
                return x;
            else
                return x + 1;
        }
        void Delay()
        {
            int randomDelay = rnd.Next(setting.DelayMin, setting.DelayMax + 1);
            EventFromMyClass(this, new MyEventMessage($"Задержка на {randomDelay} сек"));
            Thread.Sleep(1000 * randomDelay); //Задержка в сек.
        }
        void DelayUser()
        {
            int randomDelayUser = rnd.Next(setting.DelayOneUserMin, setting.DelayOneUserMax + 1);
            EventFromMyClass(this, new MyEventMessage($"Задержка на {randomDelayUser} сек"));
            Thread.Sleep(1000 * randomDelayUser); //Учет задержки на пользователя      
        }
        void CheckedPause()
        {
            if (setting.CheckedPause) //Учет паузы
            {
                if (setting.PauseLimit <= CountComment)
                {
                    EventFromMyClass(this, new MyEventMessage("Пауза на " + setting.PauseTime + "минут"));
                    Thread.Sleep(1000 * setting.PauseTime);
                }
            }
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
            EventFromMyClass(this, new MyEventMessage($"..Останавливаю\n..."));
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
