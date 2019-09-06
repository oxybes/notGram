using System;

namespace WindowsFormsApp2.Defender_Task
{
    public class UpdateGridTaskPlans:EventArgs
    {
        public InfoGridTaskPlans info { get; }

        public UpdateGridTaskPlans(InfoGridTaskPlans info)
        {
            this.info = info;
        }
    }
}
