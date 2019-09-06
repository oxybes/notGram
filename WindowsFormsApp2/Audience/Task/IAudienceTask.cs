using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Audience.Task
{
    public interface IAudienceTask
    {
        void Start();
        void Pause();
        void Stop();
        string Info();
    }
}
