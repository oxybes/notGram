using InstaSharper.API;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp2.Deferred_Posting;

namespace WindowsFormsApp2.Forms
{
    public partial class AddPostForm : MetroForm
    {
        private List<IInstaApi> listApi;
        private List<string> albumPhoto;
        private Dictionary<int, IPost> dictionaryAutoPost;
        public AddPostForm(List<IInstaApi> listApi, Dictionary<int, IPost> dictionaryAutoPost)
        {
            InitializeComponent();
            this.listApi = listApi;
            this.post_tBox_RoadImage.ButtonClick += Post_tBox_RoadImage_Click;
            tBox_Preview.ButtonClick += tBox_Preview_Click;
            albumPhoto = new List<string>();
            this.dictionaryAutoPost = dictionaryAutoPost;
        }

        private async void AddPostForm_Load(object sender, EventArgs e)
        {
            cmBox_WhatPost.SelectedIndex = 0;
            foreach (var api in listApi)
            {
                var infoUser = (await api.GetCurrentUserAsync()).Value.UserName;
                cmBox_Acc.Items.Add(infoUser);
            }
        }

        private void Post_tBox_RoadImage_Click(object sender, EventArgs e)
        {
            var x = new OpenFileDialog();
            x.Multiselect = true;
            x.Filter = "Файлы изображений (*.jpg, *.png)|*.jpg;*.png";
            if (cmBox_WhatPost.SelectedIndex == 1)
            {
                x.Multiselect = false;
                x.Filter = "Файлы видео (*.mp4)|*.mp4";
            }
            if (x.ShowDialog() == DialogResult.Cancel)
                return;
            post_tBox_RoadImage.Text = x.FileName;
            foreach (string file in x.FileNames)
            {
                albumPhoto.Add(file);
            }
        }

        private void tBox_Preview_Click(object sender, EventArgs e)
        {
            var x = new OpenFileDialog();
            x.Filter = "Файлы изображений (*.jpg, *.png)|*.jpg;*.png";
            ;
            if (x.ShowDialog() == DialogResult.Cancel)
                return;
            tBox_Preview.Text = x.FileName;
        }

        private void CmBox_WhatPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmBox_WhatPost.SelectedIndex)
            {
                case 0:
                    metroLabel1.Text = "Укажите путь до фото(Можно несколько)";
                    metroLabel2.Location = new Point(23,170);
                    tBox_Message.Location = new Point(23,192);
                    tBox_Message.Size = new Size(291,203);
                    metroDateTimePost.Location = new Point(23, 401);
                    post_b_AddPost.Location = new Point(23, 432);
                    this.Size = new Size(337, 473);
                    tBox_Message.Show();
                    metroLabel2.Show();
                    metroLabel3.Hide();
                    tBox_Preview.Hide();
                    break;
                case 1:
                    metroLabel1.Text = "Укажите путь до видео";
                    metroLabel2.Location = new Point(23, 218);
                    tBox_Message.Location = new Point(23, 240);
                    tBox_Message.Size = new Size(291, 155);
                    metroDateTimePost.Location = new Point(23, 401);
                    post_b_AddPost.Location = new Point(23, 432);
                    this.Size = new Size(337, 473);
                    tBox_Message.Show();
                    metroLabel3.Show();
                    tBox_Preview.Show();
                    metroLabel2.Show();
                    break;
                case 2:
                    metroLabel1.Text = "Укажите путь до фото";
                    metroDateTimePost.Location = new Point(23,173);
                    post_b_AddPost.Location = new Point(23, 205);
                    this.Size = new Size(337, 250);
                    metroLabel2.Hide();
                    metroLabel3.Hide();
                    tBox_Preview.Hide();
                    tBox_Message.Hide();
                    break;
            }
        }

        private void Post_b_AddPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (post_tBox_RoadImage.Text.Length < 5)
                throw  new Exception("Путь для фото не указан");
                switch (cmBox_WhatPost.SelectedIndex)
                {
                    case 0:
                        Post postPhoto = new Post();
                        if (albumPhoto.Count == 1)
                            postPhoto.FileNamePhoto = post_tBox_RoadImage.Text;
                        if (albumPhoto.Count > 1)
                        {
                            string[] x = albumPhoto.ToArray();
                            postPhoto.AlbumFileNamePhoto = x;
                        }

                        postPhoto.Message = tBox_Message.Text;
                        postPhoto.Time = metroDateTimePost.Value;
                        postPhoto.Number = dictionaryAutoPost.Count;

                        dictionaryAutoPost[postPhoto.Number] =
                            new AutoPostUploadPhoto(listApi[cmBox_Acc.SelectedIndex], postPhoto);
                        dictionaryAutoPost[postPhoto.Number].Start();
                        break;


                    case 1:
                        Post postVideo = new Post
                        {
                            Message = tBox_Message.Text,
                            Time = metroDateTimePost.Value,
                            FileNameVideo = post_tBox_RoadImage.Text,
                            FileNamePreview = tBox_Preview.Text,
                            Number = dictionaryAutoPost.Count
                        };
                        string usernameVideo = cmBox_Acc.SelectedItem.ToString();
                        dictionaryAutoPost[postVideo.Number] =
                            new AutoPostUploadVideo(listApi[cmBox_Acc.SelectedIndex], postVideo);
                        dictionaryAutoPost[postVideo.Number].Start();
                        break;
                    case 2:
                        Post postHistory = new Post
                        {
                            FileNamePhoto = post_tBox_RoadImage.Text,
                            Time = metroDateTimePost.Value,
                            Number = dictionaryAutoPost.Count
                        };

                        string usernameHistory = cmBox_Acc.SelectedItem.ToString();
                        dictionaryAutoPost[postHistory.Number] =
                            new AutoPostUploadHistory(listApi[cmBox_Acc.SelectedIndex], postHistory);
                        dictionaryAutoPost[postHistory.Number].Start();

                        break;
                }

                Close();
            }
            catch (ArgumentOutOfRangeException q)
            {
                MessageBox.Show("Выберите аккаунт");
            }
            catch (Exception p)
            {
                MessageBox.Show(p.Message);
            }

        }
    }
}
