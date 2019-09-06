using InstaSharper.API;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp2.Defender_Task;
using WindowsFormsApp2.Task;

namespace WindowsFormsApp2.Forms
{
    public partial class AddPlansForm : MetroForm
    {
        private List<IInstaApi> listApi;
        private InfoDefenderTask infoDefenderTask = new InfoDefenderTask();
        Dictionary<string, ITask> dictionaryTask;
        private int number;
        private List<DefenderTask> listDefenderTask;
        public AddPlansForm(List<IInstaApi> listApi, Dictionary<string, ITask> dictionaryTask, int number, List<DefenderTask> listDefenderTask)
        {
            InitializeComponent();
            this.listApi = listApi;
            this.dictionaryTask = dictionaryTask;
            this.number = number;
            this.listDefenderTask = listDefenderTask;

        }

        private async void AddPlansForm_Load(object sender, EventArgs e)
        {
            foreach (var api in listApi)
            {
                var infoUser = (await api.GetCurrentUserAsync()).Value.UserName;
                cmBox_Acc.Items.Add(infoUser);
            }
        }

        private void B_TaskOne_Click(object sender, EventArgs e)
        {
            try
            {
                infoDefenderTask.Api = listApi[cmBox_Acc.SelectedIndex];
                new OptionsTask(listApi[cmBox_Acc.SelectedIndex], infoDefenderTask).ShowDialog();
                if (infoDefenderTask.OneTask != null)
                    metroLabel2.Text = infoDefenderTask.OneTask.Info();
            }
            catch
            {
                MessageBox.Show("Сначала выберите аккаунт");
            }
        }

        private void B_CancelTaskOne_Click(object sender, EventArgs e)
        {
            infoDefenderTask.OneTask = null;
            metroLabel2.Text = "";
        }

        private void B_Apply_Click(object sender, EventArgs e)
        {
            if (infoDefenderTask.Api != null && infoDefenderTask.OneTask != null)
            { 
                infoDefenderTask.Time = dateTimePlans.Value;
                infoDefenderTask.Number = number;
                listDefenderTask.Add(new DefenderTask(infoDefenderTask, dictionaryTask));
                listDefenderTask[number].Start();
                Close();
            }
            else
            {
                MessageBox.Show("Выберите задание или аккаунт");
            }
        }
    }
    
}
