using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBot.SettingsTask
{
    public class SettingTaskComment
    {
        public string FileNameBaseId { get; set; }

        public int DelayMin { get; set; }
        public int DelayMax { get; set; }

        public int DelayOneUserMin { get; set; }
        public int DelayOneUserMax { get; set; }

        public bool CheckedPause { get; set; }
        public int PauseLimit { get; set; }
        public int PauseTime { get; set; }

        public bool ChekedDeleteBase { get; set; }
        public int CommentCountMax { get; set; }
        public int CountPublishComment { get; set; }
        public int CountCommnetUnderPublish { get; set; }

        public string[] Message { get; set; }
    }
}
