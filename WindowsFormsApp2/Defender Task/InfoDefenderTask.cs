using InstaSharper.API;
using System;
using WindowsFormsApp2.Task;

namespace WindowsFormsApp2.Defender_Task
{
    public class InfoDefenderTask
    {
        public IInstaApi Api { get; set; }
        public ITask OneTask { get; set; }

        public DateTime Time { get; set; }
        public int Number { get; set; }
    }
}
