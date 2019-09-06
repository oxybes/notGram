using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class AccountInfo
    {
        public string Login { get; set; }
        public string Task { get; set; }
        public string Progress { get; set; }
        public string Subscriptions { get; set; }
        public string Subscribers { get; set; }
        public string Publish { get; set; }
        public string Status { get; set; }

        public string Hidden = "";

        public AccountInfo(string login, string task, string progress, string subscribing, string subscriber,
            string publish, string status)
        {
            Login = login;
            Task = task;
            Progress = progress;
            Subscriptions = subscribing;
            Subscribers = subscriber;
            Publish = publish;
            Status = status;
        }
    }
}
