using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2.Deferred_Posting
{
    class Post
    {
        public string FileNamePhoto { get; set; }
        public string[] AlbumFileNamePhoto { get; set; }
        public string Message { get; set; }
        public string FileNameVideo { get; set; }
        public string FileNamePreview { get; set; }
        public int Number { get; set; }
        public DateTime Time { get; set; }
    }
}
