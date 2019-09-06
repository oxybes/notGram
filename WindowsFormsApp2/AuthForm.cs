using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Logger;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp2.Forms;
using WindowsFormsApp2.Properties;
using InstaSharper.Classes.ResponseWrappers;

namespace WindowsFormsApp2
{
    public partial class AuthForm : MetroForm
    {
        UserSessionData user;
        IInstaApi api;
        private List<IInstaApi> newListApi;


        public AuthForm()
        {
            InitializeComponent();
            LoadSettings();
            MinForm();
        }


        public AuthForm(List<IInstaApi> newListApi)
        {
            InitializeComponent();
            LoadSettings();
            MinForm();
            this.newListApi = newListApi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void MetroTextBoxLogin_Click(object sender, EventArgs e)
        {
            metroTextBoxLogin.WaterMark = "Login";
        }

        private async void MetroButtonAuth_Click_1(object sender, EventArgs e)
        {
            if (newListApi != null)
            {
                try
                {
                    metroButtonAuth.Enabled = false;
                    user = new UserSessionData();
                    user.UserName = metroTextBoxLogin.Text;
                    user.Password = metroTextBoxPassword.Text;

                    if (metroCheckBoxProxy.Checked)
                    {
                        HttpClientHandler handler = new HttpClientHandler();
                        WebProxy proxy = null;

                        try
                        {
                            string strProxy = metroTextBoxProxy.Text;
                            string[] masStrProxy = strProxy.Split(':');
                            string ip = masStrProxy[0];
                            int port = Convert.ToInt32(masStrProxy[1]);
                            proxy = new WebProxy(ip, port);

                            if (metroTextBoxProxyLogin.Text.Length != 0 && metroTextBoxProxyPassword.Text.Length != 0)
                            {
                                string login = metroTextBoxProxyLogin.Text;
                                string password = metroTextBoxProxyPassword.Text;
                                proxy.Credentials = new NetworkCredential(login, password);
                            }
                        }
                        catch
                        {
                            metroTextBoxProxy.Clear();
                            metroTextBoxProxyLogin.Clear();
                            metroTextBoxProxyPassword.Clear();
                            metroTextBoxProxy.WaterMark = "Неверная запись прокси";
                            metroButtonAuth.Enabled = true;
                            return;
                        }

                        handler.UseProxy = true;
                        if (proxy != null)
                            handler.Proxy = proxy;

                        api = InstaApiBuilder.CreateBuilder()
                            .SetUser(user)
                            .UseLogger(new DebugLogger(LogLevel.Exceptions))
                            .SetRequestDelay(RequestDelay.FromSeconds(0, 0))
                            .UseHttpClientHandler(handler)
                            .Build();

                        if (metroCheckBoxMemberProxy.Checked)
                        {
                            Settings.Default["proxy"] = metroTextBoxProxy.Text;
                            Settings.Default["proxyLogin"] = metroTextBoxProxyLogin.Text;
                            Settings.Default["proxyPassword"] = metroTextBoxProxyPassword.Text;
                            Settings.Default["memberProxy"] = true;
                            Settings.Default.Save();
                        }
                        else
                        {
                            Settings.Default["proxy"] = "";
                            Settings.Default["proxyLogin"] = "";
                            Settings.Default["proxyPassword"] = "";
                            Settings.Default["memberProxy"] = false;
                            Settings.Default.Save();
                        }
                    }

                    else
                    {
                        api = InstaApiBuilder.CreateBuilder()
                            .SetUser(user)
                            .UseLogger(new DebugLogger(LogLevel.Exceptions))
                            .SetRequestDelay(RequestDelay.FromSeconds(0, 0))
                            .Build();
                    }

                    var loginRequest = await api.LoginAsync();

                    if (metroCheckBox1.Checked)
                    {
                        Settings.Default["Login"] = metroTextBoxLogin.Text;
                        Settings.Default["Password"] = metroTextBoxPassword.Text;
                        Settings.Default["member"] = true;
                        Settings.Default.Save();
                    }
                    else
                    {
                        Settings.Default["Login"] = "";
                        Settings.Default["Password"] = "";
                        Settings.Default["member"] = false;
                        Settings.Default.Save();
                    }

                    if (loginRequest.Succeeded && api.IsUserAuthenticated)
                    {
                        newListApi.Add(api);
                        //new MainForm(listApi).Show();
                        Close();
                    }

                    else
                    {
                        metroButtonAuth.Enabled = true;
                        switch (loginRequest.Value)
                        {
                            case InstaLoginResult.InvalidUser:
                                metroTextBoxLogin.Clear();
                                metroTextBoxPassword.Clear();
                                metroTextBoxLogin.WaterMark = "Username is invalid.";
                                break;
                            case InstaLoginResult.BadPassword:
                                metroTextBoxLogin.Clear();
                                metroTextBoxPassword.Clear();
                                metroTextBoxLogin.WaterMark = ("Password is wrong.");
                                break;
                            case InstaLoginResult.Exception:
                                metroTextBoxLogin.Clear();
                                metroTextBoxPassword.Clear();
                                MessageBox.Show("Exception throws: " + loginRequest.Info?.Message);
                                break;
                            case InstaLoginResult.ChallengeRequired:
                                new HandleChallengeForm(api).ShowDialog();
                                if (api.IsUserAuthenticated)
                                {
                                    newListApi.Add(api);
                                    //new MainForm(listApi).Show();
                                    Close();
                                }

                                break;
                            default:
                                if (api.IsUserAuthenticated == false)
                                {
                                    MessageBox.Show("Ошибка авторизации " + loginRequest.Info.Message);
                                }

                                break;
                        }
                    }
                }
                catch
                {

                }
            }

            else
            {

                try
                {
                    List<IInstaApi> listApi = new List<IInstaApi>();
                    metroButtonAuth.Enabled = false;
                    user = new UserSessionData();
                    user.UserName = metroTextBoxLogin.Text;
                    user.Password = metroTextBoxPassword.Text;

                    if (metroCheckBoxProxy.Checked)
                    {
                        HttpClientHandler handler = new HttpClientHandler();
                        WebProxy proxy = null;

                        try
                        {
                            string strProxy = metroTextBoxProxy.Text;
                            string[] masStrProxy = strProxy.Split(':');
                            string ip = masStrProxy[0];
                            int port = Convert.ToInt32(masStrProxy[1]);
                            proxy = new WebProxy(ip, port);

                            if (metroTextBoxProxyLogin.Text.Length != 0 && metroTextBoxProxyPassword.Text.Length != 0)
                            {
                                string login = metroTextBoxProxyLogin.Text;
                                string password = metroTextBoxProxyPassword.Text;
                                proxy.Credentials = new NetworkCredential(login, password);
                            }
                        }
                        catch
                        {
                            metroTextBoxProxy.Clear();
                            metroTextBoxProxyLogin.Clear();
                            metroTextBoxProxyPassword.Clear();
                            metroTextBoxProxy.WaterMark = "Неверная запись прокси";
                            metroButtonAuth.Enabled = true;
                            return;
                        }

                        handler.UseProxy = true;
                        if (proxy != null)
                            handler.Proxy = proxy;
                        api = InstaApiBuilder.CreateBuilder()
                            .SetUser(user)
                            .UseLogger(new DebugLogger(LogLevel.Exceptions))
                            .SetRequestDelay(RequestDelay.FromSeconds(0, 0))
                            .UseHttpClientHandler(handler)
                            .Build();

                        if (metroCheckBoxMemberProxy.Checked)
                        {
                            Settings.Default["proxy"] = metroTextBoxProxy.Text;
                            Settings.Default["proxyLogin"] = metroTextBoxProxyLogin.Text;
                            Settings.Default["proxyPassword"] = metroTextBoxProxyPassword.Text;
                            Settings.Default["memberProxy"] = true;
                            Settings.Default.Save();
                        }
                        else
                        {
                            Settings.Default["proxy"] = "";
                            Settings.Default["proxyLogin"] = "";
                            Settings.Default["proxyPassword"] = "";
                            Settings.Default["memberProxy"] = false;
                            Settings.Default.Save();
                        }
                    }

                    else
                    {
                        api = InstaApiBuilder.CreateBuilder()
                            .SetUser(user)
                            .UseLogger(new DebugLogger(LogLevel.Exceptions))
                            .SetRequestDelay(RequestDelay.FromSeconds(0, 0))
                            .Build();
                    }

                    var loginRequest = await api.LoginAsync();

                    if (metroCheckBox1.Checked)
                    {
                        Settings.Default["Login"] = metroTextBoxLogin.Text;
                        Settings.Default["Password"] = metroTextBoxPassword.Text;
                        Settings.Default["member"] = true;
                        Settings.Default.Save();
                    }
                    else
                    {
                        Settings.Default["Login"] = "";
                        Settings.Default["Password"] = "";
                        Settings.Default["member"] = false;
                        Settings.Default.Save();
                    }

                    if (loginRequest.Succeeded && api.IsUserAuthenticated)
                    {
                        listApi.Add(api);
                        new MainForm(listApi).Show();
                        Hide();
                    }

                    else
                    {
                        metroButtonAuth.Enabled = true;
                        switch (loginRequest.Value)
                        {
                            case InstaLoginResult.InvalidUser:
                                metroTextBoxLogin.Clear();
                                metroTextBoxPassword.Clear();
                                metroTextBoxLogin.WaterMark = "Username is invalid.";
                                break;
                            case InstaLoginResult.BadPassword:
                                metroTextBoxLogin.Clear();
                                metroTextBoxPassword.Clear();
                                metroTextBoxLogin.WaterMark = ("Password is wrong.");
                                break;
                            case InstaLoginResult.Exception:
                                metroTextBoxLogin.Clear();
                                metroTextBoxPassword.Clear();
                                MessageBox.Show("Exception throws: " + loginRequest.Info?.Message);
                                break;
                            case InstaLoginResult.ChallengeRequired:
                                new HandleChallengeForm(api).ShowDialog();
                                if (api.IsUserAuthenticated)
                                {
                                    listApi.Add(api);
                                    new MainForm(listApi).Show();
                                    Hide();
                                }

                                break;
                            default:
                                if (api.IsUserAuthenticated == false)
                                {
                                    MessageBox.Show("Ошибка авторизации " + loginRequest.Info.Message);
                                }

                                break;
                        }
                    }
                }
                catch (ArgumentException arg)
                {
                    metroTextBoxLogin.Text = "";
                    metroTextBoxLogin.WaterMark = arg.Message;
                    metroTextBoxPassword.Text = "";
                    metroButtonAuth.Enabled = true;
                }
            }
        }




        private void MinForm()
        {
            Size = new Size(Size.Width, Size.Height - 130);
            metroLabel2.Location = new Point(metroLabel2.Location.X, metroLabel2.Location.Y - 130);
            metroCheckBox1.Location = new Point(metroCheckBox1.Location.X, metroCheckBox1.Location.Y - 130);
            metroButtonAuth.Location = new Point(metroButtonAuth.Location.X, metroButtonAuth.Location.Y - 130);

            metroTextBoxProxy.Hide();
            metroTextBoxProxyLogin.Hide();
            metroTextBoxProxyPassword.Hide();
            metroCheckBoxMemberProxy.Hide();
        }

        private void MaxForm()
        {
            Size = new Size(Size.Width, Size.Height + 130);
            metroLabel2.Location = new Point(metroLabel2.Location.X, metroLabel2.Location.Y + 130);
            metroCheckBox1.Location = new Point(metroCheckBox1.Location.X, metroCheckBox1.Location.Y + 130);
            metroButtonAuth.Location = new Point(metroButtonAuth.Location.X, metroButtonAuth.Location.Y + 130);

            metroTextBoxProxy.Show();
            metroTextBoxProxyLogin.Show();
            metroTextBoxProxyPassword.Show();
            metroCheckBoxMemberProxy.Show();
        }

        private void LoadSettings()
        {
            metroTextBoxLogin.Text = Settings.Default["Login"].ToString();
            metroTextBoxPassword.Text = Settings.Default["Password"].ToString();
            metroTextBoxProxy.Text = Settings.Default["proxy"].ToString();
            metroTextBoxProxyLogin.Text = Settings.Default["proxyLogin"].ToString();
            metroTextBoxProxyPassword.Text = Settings.Default["proxyPassword"].ToString();
            metroCheckBox1.Checked = Convert.ToBoolean(Settings.Default["member"].ToString());
            metroCheckBoxMemberProxy.Checked = Convert.ToBoolean(Settings.Default["memberProxy"].ToString());
        }

        private void MetroTextBoxProxy_Click(object sender, EventArgs e)
        {
            metroTextBoxProxy.WaterMark = "IP:PORT";
        }

        private void MetroCheckBoxProxy_Click(object sender, EventArgs e)
        {
            if (metroCheckBoxProxy.Checked)
            {
                MaxForm();
            }

            if (!metroCheckBoxProxy.Checked)
            {
                MinForm();
            }
        }


        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    if (!metroCheckBoxProxy.Checked)
                    {
                        MinForm();
                    }

                    break;
                case 1:
                    if (!metroCheckBoxProxy.Checked)
                    {
                        MaxForm();
                    }

                    break;
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            metroTextBoxMultAcc.Clear();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = open.FileName;
            var x = System.IO.File.ReadAllLines(filename);
            foreach (string str in x)
            {
                metroTextBoxMultAcc.Text += str + "\r\n";
            }
        }

        private async void ButtonMultAuth_Click(object sender, EventArgs e)
        {
            buttonMultAuth.Enabled = false;

            if (newListApi != null)
            {
                var masAcc = metroTextBoxMultAcc.Text.Split('\n');

                int count = 0;
                for (int i = 0; i < masAcc.Length; i++)
                {
                    var infoUser = masAcc[i].Split(':');

                    IInstaApi multApi;

                    user = new UserSessionData();
                    try
                    {
                        user.UserName = infoUser[0].TrimEnd('\r', '\n');
                        user.Password = infoUser[1].TrimEnd('\r', '\n');


                        if (infoUser.Length >= 4)
                        {
                            HttpClientHandler handler = new HttpClientHandler();

                            string ip = infoUser[2].TrimEnd('\r', '\n');
                            int port = Convert.ToInt32(infoUser[3].TrimEnd('\r', '\n'));
                            WebProxy proxy = new WebProxy(ip, port);

                            if (infoUser.Length == 6)
                            {
                                string login = infoUser[4].TrimEnd('\r', '\n');
                                ;
                                string password = infoUser[5].TrimEnd('\r', '\n');
                                ;
                                proxy.Credentials = new NetworkCredential(login, password);
                            }

                            handler.UseProxy = true;
                            handler.Proxy = proxy;

                            multApi = InstaApiBuilder.CreateBuilder()
                                .SetUser(user)
                                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                                .SetRequestDelay(RequestDelay.FromSeconds(0, 0))
                                .UseHttpClientHandler(handler)
                                .Build();
                        }

                        else
                        {
                            multApi = InstaApiBuilder.CreateBuilder()
                                .SetUser(user)
                                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                                .SetRequestDelay(RequestDelay.FromSeconds(0, 0))
                                .Build();
                        }

                        if ((await multApi.LoginAsync()).Succeeded)
                        {
                            newListApi.Add(multApi);
                            count++;
                        }

                        Thread.Sleep(500);
                    }
                    catch
                    {
                        continue;
                    }

                }

                if (newListApi.Count != 0)
                {
                    //new MainForm(listApi).Show();
                    Close();
                }

                else
                {
                    MessageBox.Show("Ни один аккаунт не прошел авторизацию");
                    metroTextBoxMultAcc.Clear();
                    buttonMultAuth.Enabled = true;
                }
            }
            else
            {
                List<IInstaApi> listApi = new List<IInstaApi>();
                var masAcc = metroTextBoxMultAcc.Text.Split('\n');

                int count = 0;
                for (int i = 0; i < masAcc.Length; i++)
                {
                    var infoUser = masAcc[i].Split(':');

                    IInstaApi multApi;

                    user = new UserSessionData();
                    try
                    {
                        user.UserName = infoUser[0].TrimEnd('\r', '\n');
                        user.Password = infoUser[1].TrimEnd('\r', '\n');


                        if (infoUser.Length >= 4)
                        {
                            HttpClientHandler handler = new HttpClientHandler();

                            string ip = infoUser[2].TrimEnd('\r', '\n');
                            int port = Convert.ToInt32(infoUser[3].TrimEnd('\r', '\n'));
                            WebProxy proxy = new WebProxy(ip, port);

                            if (infoUser.Length == 6)
                            {
                                string login = infoUser[4].TrimEnd('\r', '\n');
                                ;
                                string password = infoUser[5].TrimEnd('\r', '\n');
                                ;
                                proxy.Credentials = new NetworkCredential(login, password);
                            }

                            handler.UseProxy = true;
                            handler.Proxy = proxy;

                            multApi = InstaApiBuilder.CreateBuilder()
                                .SetUser(user)
                                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                                .SetRequestDelay(RequestDelay.FromSeconds(0, 0))
                                .UseHttpClientHandler(handler)
                                .Build();
                        }

                        else
                        {
                            multApi = InstaApiBuilder.CreateBuilder()
                                .SetUser(user)
                                .UseLogger(new DebugLogger(LogLevel.Exceptions))
                                .SetRequestDelay(RequestDelay.FromSeconds(0, 0))
                                .Build();
                        }

                        if ((await multApi.LoginAsync()).Succeeded)
                        {
                            listApi.Add(multApi);
                            count++;
                        }

                        Thread.Sleep(500);
                    }
                    catch
                    {
                        continue;
                    }

                }

                if (listApi.Count != 0)
                {
                    new MainForm(listApi).Show();
                    Hide();
                }

                else
                {
                    MessageBox.Show("Ни один аккаунт не прошел авторизацию");
                    metroTextBoxMultAcc.Clear();
                    buttonMultAuth.Enabled = true;
                }
            }
        }
    }
}
