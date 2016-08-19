using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;

namespace TaskerClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            if (_contentLoaded)
            {
                refreshTasks();
            }
        }

        

        public void refreshTasks()
        {
            string wcfResponse = null;
            IList<Task> listTask = new List<Task>();
            TaskerServ taskerServ = new TaskerServ();

            dtgrid_0.Items.Clear();
            dtgrid_1.Items.Clear();
            dtgrid_2.Items.Clear();
            dtgrid_3.Items.Clear();

            wcfResponse = taskerServ.GetTasks(0);
            listTask = JsonConvert.DeserializeObject<IList<Task>>(wcfResponse);
            foreach (var task in listTask)
            {
                dtgrid_0.Items.Add(task);
            }

            wcfResponse = taskerServ.GetTasks(1);
            listTask = JsonConvert.DeserializeObject<IList<Task>>(wcfResponse);
            foreach (var task in listTask)
            {
                dtgrid_1.Items.Add(task);
            }

            wcfResponse = taskerServ.GetTasks(2);
            listTask = JsonConvert.DeserializeObject<IList<Task>>(wcfResponse);
            foreach (var task in listTask)
            {
                dtgrid_2.Items.Add(task);
            }

            wcfResponse = taskerServ.GetTasks(3);
            listTask = JsonConvert.DeserializeObject<IList<Task>>(wcfResponse);
            foreach (var task in listTask)
            {
                dtgrid_3.Items.Add(task);
            }
            taskerServ.Close();
        }

        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            TaskForm taskForm = new TaskForm(new Task());
            taskForm.InitializeComponent();
            taskForm.Show();

            taskForm.Closed += TaskFormOnClosed;
        }

        private void TaskFormOnClosed(object sender, EventArgs eventArgs)
        {
            refreshTasks();
        }

        public void PartialUpdateItem(Task t)
        {
            TaskForm taskForm = new TaskForm(t);
            taskForm.InitializeComponent();
            taskForm.Show();

            taskForm.Closed += TaskFormOnClosed;
        }

        private void dtgrid_0_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgrid_0.SelectedItem == null)
            {
                return;
            }
            Task t = new Task();
             t = (Task)dtgrid_0.SelectedItem;

            PartialUpdateItem(t);

        }

        private void dtgrid_1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgrid_1.SelectedItem == null)
            {
                return;
            }
            Task t = new Task();
            t = (Task)dtgrid_1.SelectedItem;

            PartialUpdateItem(t);
        }

        

        private void dtgrid_2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgrid_2.SelectedItem == null)
            {
                return;
            }
            Task t = new Task();
            t = (Task)dtgrid_2.SelectedItem;

            PartialUpdateItem(t);
        }

        private void dtgrid_3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dtgrid_3.SelectedItem == null)
            {
                return;
            }
            Task t = new Task();
            t = (Task)dtgrid_3.SelectedItem;

            PartialUpdateItem(t);
        }
    }
}
