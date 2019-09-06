using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InstaSharper.API;
using InstaSharper.Classes.Models;

namespace WindowsFormsApp2.Deferred_Posting
{
    class AutoPostUploadPhoto:IPost
    {
        static public event EventHandler<UpdateGridAutopost> EventUpdateGrid;
        private InfoGridAutopost infoAcc;

        private IInstaApi api;
        private Post post;

        private bool delete;
        private bool forcedStart;

        public AutoPostUploadPhoto(IInstaApi api, Post post)
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
            infoAcc = new InfoGridAutopost((await api.GetCurrentUserAsync()).Value.UserName, "Фото",
                post.FileNamePhoto, post.Time.ToString(), "Ожидает публикации", post.Number);
            EventUpdateGrid(this,new UpdateGridAutopost(infoAcc));

            while (delete == false)
            {
                if (DateTime.Now > post.Time || forcedStart)
                {
                    Posting();
                    break;;
                }
                Thread.Sleep(1000 * 30);
            }
        }

        async void Posting()
        {
            string message = post.Message;
            if (post.AlbumFileNamePhoto == null)
            {
                var mediaImage = new InstaImage
                {
                    Height = 1080,
                    Width = 1350,
                    URI = post.FileNamePhoto
                };
                var result = await api.UploadPhotoAsync(mediaImage, message);
            }

            if (post.AlbumFileNamePhoto != null  && post.AlbumFileNamePhoto.Length > 1)
            {
                InstaImage[] img = new InstaImage[post.AlbumFileNamePhoto.Length];
                for(int i = 0; i < post.AlbumFileNamePhoto.Length; i++)
                {
                    img[i] = new InstaImage
                    {
                        Height = 1080,
                        Width = 1350,
                        URI = post.AlbumFileNamePhoto[i]
                    };
                }
                var result = await api.UploadPhotosAlbumAsync(img, message);
            }
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
            forcedStart = true;
        }
    }
}
