using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBot.SettingsTask
{

    public class SettingTaskUnSubscribe
    {
        public string FileNameBaseId { get; set; }
        public string FileNameDontUnSubscribeId { get; set; }
      
        public int DelayMin { get; set; }
        public int DelayMax { get; set; }

        public bool CheckedPause { get; set; }
        public int PauseLimit { get; set; }
        public int PauseTime { get; set; }

        public bool ChekedDeleteBaseAfterUnSubscribe { get; set; }
        public bool ChekedUnSubscribeBlock { get; set; }

        public int LimitUnSubscribe { get; set; }
        
        public string WhatDoing { get; set; }

    }
}
