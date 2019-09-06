namespace WindowsFormsApp2.Defender_Task
{
    public class InfoGridTaskPlans
    {
        public int Number { get; }
        public string Login { get; set; }
        public string TaskOne { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }


        public InfoGridTaskPlans(string login, string taskOne, string time, string status, int number)
        {
            Login = login;
            TaskOne = taskOne;
            Time = time;
            Status = status;
            Number = number;
        }
    }
}
