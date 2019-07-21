using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBot.SettingsTask
{
    public class SettingTaskMassDirect
    {
        public string FileNameBaseId { get; set; }

        public int DelayMin { get; set; }
        public int DelayMax { get; set; }

        public bool CheckedPause { get; set; }
        public int PauseLimit { get; set; }
        public int PauseTime { get; set; }

        public bool ChekedDeleteBase { get; set; }

        public List<string> Messages { get; set; }
        public List<string> LinkPublic { get; set; }
    }
}
