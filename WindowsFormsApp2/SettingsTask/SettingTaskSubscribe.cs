using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBot.SettingsTask
{
    public class SettingTaskSubscribe
    {
        public string FileNameBaseId { get; set; }

        public int DelayMin { get; set; }
        public int DelayMax { get; set; }

        public bool ChekedPause { get; set; }
        public int PauseLimit { get; set; }
        public int PauseTime { get; set; }

        public int LimitSubscribe { get; set; }

        public bool ChekedLikingBySubscribe { get; set; }
        public  int LikingMin { get; set; }
        public  int LikingMax { get; set; }
        public int DelayLikeMin { get; set; }
        public int DelayLikeMax { get; set; }

        public bool ChekedDeleteAdfter { get; set; }
        public bool ChekedSkipSubscriber;
        public bool ChekedSendPrivateUser { get; set; }
    }
}
