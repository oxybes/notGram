namespace WindowsFormsApp2.Deferred_Posting
{
    public class InfoGridAutopost
    {
        public string FileName { get; set; }
        public string Login { get; set; }
        public string Status { get; set; }
        public string Time { get; set; }
        public string TypePost { get; set; }

        public int Number { get; }

        public InfoGridAutopost(string login, string typePost, string fileName, string time, string status,int number )
        {
            Login = login;
            TypePost = typePost;
            FileName = fileName;
            Time = time;
            Status = status;
            Number = number;
        }
    }
}
