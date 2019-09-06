using System;
using System.Collections.Generic;
using System.Threading;
using WindowsFormsApp2.Task;

namespace WindowsFormsApp2.Defender_Task
{
    public class DefenderTask:IDefender
    {
        static public event EventHandler<UpdateGridTaskPlans> EventUpdateGrid;
        private InfoDefenderTask infoTask;
        Dictionary<string, ITask> dictionaryTask;
        private InfoGridTaskPlans infoAcc;


        private bool delete;
        private bool forcedStart;

        public DefenderTask(InfoDefenderTask infoTask, Dictionary<string, ITask> dictionaryTask)
        {
            this.infoTask = infoTask;
            this.dictionaryTask = dictionaryTask;
            delete = false;
            forcedStart = false;
        }

        public void Start()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback((s) =>
            {
                ThreadMethod();
            }));
        }

        async void ThreadMethod()
        {
            infoAcc = new InfoGridTaskPlans((await infoTask.Api.GetCurrentUserAsync()).Value.UserName,
                infoTask.OneTask.Info(),
                infoTask.Time.ToString(), "Ожидает", infoTask.Number);
            EventUpdateGrid(this, new UpdateGridTaskPlans(infoAcc));

            string username = (await infoTask.Api.GetCurrentUserAsync()).Value.UserName;
            while (delete == false)
            {
                if (DateTime.Now > infoTask.Time || forcedStart)
                {
                    if (dictionaryTask.ContainsKey(username))
                    {
                        if (dictionaryTask[username].Stat == false)
                        {
                            Tasking();
                            break;
                        }
                    }
                    else
                    {
                        Tasking();
                        break;
                    }
                }
                Thread.Sleep(1000 * 60);
            }
        }

         void Tasking()
         {
             infoAcc.Status = "Выполняется";
             EventUpdateGrid(this, new UpdateGridTaskPlans(infoAcc));
             infoTask.OneTask.Start();
             Thread.Sleep(2000);
             while (infoTask.OneTask.Stat)
             {
                 Thread.Sleep(1000);
             }
             infoAcc.Status = "Выполнено";
             EventUpdateGrid(this, new UpdateGridTaskPlans(infoAcc));
         }

         public void Delete()
         {
             if (infoAcc != null)
             {
                 infoAcc.Status = "Удалено";
                 EventUpdateGrid(this, new UpdateGridTaskPlans(infoAcc));
                 delete = true;
             }
         }
    

        public void ForcedStart()
        {
            if (infoAcc != null)
            {
                infoAcc.Status = "Поставлено в очередь";
                EventUpdateGrid(this, new UpdateGridTaskPlans(infoAcc));
                forcedStart = true;
            }
        }
    }
}
