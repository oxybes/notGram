using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBot.SettingsTask
{
    public class SettingTaskToList
    {
        public string FileNameBase { get; set; } = null;

        public uint DelayMin { get; set; } = 30;
        public uint DelayMax { get; set; } = 60;

        public bool ChekedPause { get; set; } = true;
        public uint PauseLimit { get; set; } = 100;
        public uint PauseTime { get; set; } = 30;

        public uint LikeUnderPublicMin { get; set; } = 30;
        public uint LikeUnderPublicMax { get; set; } = 60;

        public uint LikeAtUserMin { get; set; } = 1;
        public uint LikeAtUserMax { get; set; } = 2;

        public bool ChekedDeleteInBaseAfterLike { get; set; } = false;
        public bool ChekedSkipSubscriber { get; set; } = false;
    }
}
