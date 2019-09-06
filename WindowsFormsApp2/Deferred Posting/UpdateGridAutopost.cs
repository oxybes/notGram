using System;

namespace WindowsFormsApp2.Deferred_Posting
{
    class UpdateGridAutopost : EventArgs
    {
        public InfoGridAutopost info { get; }

        public UpdateGridAutopost(InfoGridAutopost info)
        {
            this.info = info;
        }
    }
}
