using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class UpdateGridEvent : EventArgs
    {
        public readonly string Message;
        public UpdateGridEvent(string msg)
        {
            Message = msg;
        }
    }
}
