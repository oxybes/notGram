using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace WindowsFormsApp2.Audience.Statistics
{
    public class UpdateGridAudience:EventArgs
    {
        public InfoStatisticsGrid Info { get; }

        public UpdateGridAudience(InfoStatisticsGrid info)
        {
            Info = info;
        }
    }
}
