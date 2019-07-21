using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBot.SettingsTask
{
    public class SettingTaskClearBots
    {
        public string FileNameExceptionId { get; set; }
        public string WhomClear { get; set; }

        public int DelayMin { get; set; }
        public int DelayMax { get; set; }

        public bool ChekedPause { get; set; }
        public int PauseLimit { get; set; }
        public int PauseTime { get; set; }

        public int LimitBlock { get; set; }

        public bool CheckedNoAvatarUser { get; set; }
        public bool CheckedPublicCountLess { get; set; }
        public bool ChekedFollowsCountLess { get; set; }
        public bool ChekedSubscriptionsLess { get; set; }
        public bool ChekedSubscriptionsMore { get; set; }
        public bool ChekedUserBlock { get; set; }

        public int PublicCountLess { get; set; }
        public int FollowsCountLess { get; set; }
        public int SubscriptionsLess { get; set; }
        public int SubscriptionMore { get; set; }
        public int UserBlock { get; set; }
    }
}
