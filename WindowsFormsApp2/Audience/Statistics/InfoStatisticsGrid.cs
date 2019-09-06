using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Audience.Statistics
{
    public class InfoStatisticsGrid
    {
        public string TypeSbor { get; set; }
        public string Progress { get; set; }
        public string File { get; set; }
        public string Status { get; set; }


        public InfoStatisticsGrid(string type,string progress,string file,string status)
        {
            TypeSbor = type;
            Progress = progress;
            File = file;
            Status = status;
        }
    }
}
