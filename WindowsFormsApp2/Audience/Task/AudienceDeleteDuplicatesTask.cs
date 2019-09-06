using System;
using System.IO;
using System.Linq;
using System.Threading;
using WindowsFormsApp2.Audience.Statistics;
using InstaSharper.API;

namespace WindowsFormsApp2.Audience.Task
{
    class AudienceDeleteDuplicatesTask:IAudienceTask
    {
        private SettingAudience setting;
        static public event EventHandler<UpdateGridAudience> EventUpdateGrid;
        private ManualResetEvent ew;
        private bool stop, pause;
        private InfoStatisticsGrid info;

        public AudienceDeleteDuplicatesTask(SettingAudience setting)
        {
            this.setting = setting;
            ew = new ManualResetEvent(true);
            stop = true;
            info = new InfoStatisticsGrid(Info(),"-",setting.DeleteDouble_OriginalFileName,"-");
        }

        public void Start()
        {
            if (stop)
            {
                stop = false;
                ThreadPool.QueueUserWorkItem((s) =>
                {
                    DeleteDublicates();
                });
            }
            else
            {
                ew.Set();
            }
        }

        void DeleteDublicates()
        {
            string[] x = null;
            try
            {
                 x = File.ReadAllLines(setting.DeleteDouble_OriginalFileName);
            }
            catch
            {
                info.File = "Ошибка чтения из файлф, проверьте корректность введенных данных";
            }

            if (x != null)
            {
                info.Progress = $"-";
                info.Status = "Выполняется";
                info.File = setting.DeleteDouble_OriginalFileName;
                EventUpdateGrid(this, new UpdateGridAudience(info));
                var q = x.Distinct();
                try
                {
                    File.WriteAllLines(setting.DeleteDouble_SaveFileName, q);
                }
                catch
                {
                    info.File = "Ошибка записи в файл, проверьте корректность введенных данных";
                }
            }
            info.Status = "Выполнено";
            EventUpdateGrid(this, new UpdateGridAudience(info));
        }
        
        public void Pause()
        {
            info.Status = "Пауза";
            EventUpdateGrid(this, new UpdateGridAudience(info));
            ew.Reset();
        }

        public void Stop()
        {
            stop = true;
        }

        public string Info()
        {
            return "Удаление дубликатов";
        }
    }
}
