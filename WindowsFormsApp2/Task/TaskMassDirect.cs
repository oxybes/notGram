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
    class TaskMassDirect
    {
        InstaSharper.API.IInstaApi api;
        SettingTaskMassDirect setting;

        List<long> usersID;
        List<long> usersIDcopy;
        Random rnd;

        bool pause;
        bool cancel;

        public int CountMessage { get; private set; }

        public event EventHandler<MyEventMessage> EventFromMyClass;


        public TaskMassDirect(InstaSharper.API.IInstaApi api, SettingTaskMassDirect setting)
        {
            this.api = api;
            this.setting = setting;
            usersID = new List<long>();
            usersIDcopy = new List<long>();
            CountMessage = 0;
            rnd = new Random();
            pause = false;
            cancel = false;
        }

        public void Start()
        {
            EventFromMyClass(this, new MyEventMessage("Рассылка сообщений запущена\n"));
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
            MassDirect();
        }

        public async void MassDirect()
        {
            foreach (long id in usersID)
            {
                try
                {
                    if (cancel)
                        return;

                    while (pause)
                    {
                        Thread.Sleep(1000);
                    }

                    int random = rnd.Next(0, setting.Messages.Count);
                    var x = await api.SendDirectMessage(id.ToString(), null, setting.Messages[random]);
                    CountMessage++;
                    EventFromMyClass(this, new MyEventMessage($"{DateTime.Now.ToString("HH:mm:ss")}, отправил сообщение пользователю {(await api.GetUserInfoByIdAsync(id)).Value.Username}, количество сообщений: {CountMessage}"));

                    if(setting.ChekedDeleteBase)
                    {
                        usersIDcopy.Remove(id);
                    }

                    Delay(); //Задержка в сек.

                    if (setting.CheckedPause) //Учет паузы
                    {
                        if (setting.PauseLimit <= CountMessage)
                        {
                            EventFromMyClass(this, new MyEventMessage("Пауза на " + setting.PauseTime + "минут"));
                            Thread.Sleep(1000 * setting.PauseTime);
                        }
                    }
                }
                catch(Exception e)
                {
                    EventFromMyClass(this, new MyEventMessage($"ОШИБКА: {e.Message} {e.TargetSite} {DateTime.Now}\n"));
                }
            }
            EventFromMyClass(this, new MyEventMessage("Выполнено"));
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
            EventFromMyClass(this, new MyEventMessage($"...Останавливаю..."));
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
