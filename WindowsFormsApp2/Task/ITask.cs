namespace WindowsFormsApp2.Task
{
    public interface ITask
    {
        void Start();
        void Pause();
        void Stop();

        string Info();

        bool Stat { get; }
    }
}
