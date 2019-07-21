using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBot
{
    public class MyEventMessage : EventArgs
    {
        public readonly string Message;
        public MyEventMessage(string msg)
        {
            Message = msg;
        }        
    }
}
