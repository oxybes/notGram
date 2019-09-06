using InstaSharper.API;
using InstaSharper.Classes.Models;
using System;
using System.Threading;

namespace WindowsFormsApp2.Deferred_Posting
{
    class AutoPostUploadHistory:IPost
    {
        static public event EventHandler<UpdateGridAutopost> EventUpdateGrid;
        private InfoGridAutopost infoAcc;

        private IInstaApi api;
        private Post post;

        private bool delete;
        private bool forcedStart;

        public AutoPostUploadHistory(IInstaApi api, Post post)
        {
            this.api = api;
            this.post = post;
            delete = false;
            forcedStart = false;
        }

        public void Start()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback((s) =>
            {
                ThreadMethod();
            }));
        }

         async void ThreadMethod()
        {
            infoAcc = new InfoGridAutopost((await api.GetCurrentUserAsync()).Value.UserName, "История",
                post.FileNamePhoto, post.Time.ToString(), "Ожидает публикации", post.Number);
            EventUpdateGrid(this, new UpdateGridAutopost(infoAcc));

            while (delete == false)
            {
                if (DateTime.Now > post.Time || forcedStart)
                {
                    Posting();
                    break; ;
                }
                Thread.Sleep(1000 * 60);
            }
        }

        async void Posting()
        {
            string message = post.Message;
            var mediaImage = new InstaImage
            {
                Height = 1920,
                Width = 1080,
                URI = post.FileNamePhoto
            };
            var result = await api.UploadStoryPhotoAsync(mediaImage, message);

            infoAcc.Status = "Опубликовано";
            EventUpdateGrid(this, new UpdateGridAutopost(infoAcc));
        }

        public void Delete()
        {
            infoAcc.Status = "Удалено";
            EventUpdateGrid(this, new UpdateGridAutopost(infoAcc));
            delete = true;
        }

        public void ForcedStart()
        {
            infoAcc.Status = "Опубликовано";
            EventUpdateGrid(this, new UpdateGridAutopost(infoAcc));
            forcedStart = true;
        }
    }
}
