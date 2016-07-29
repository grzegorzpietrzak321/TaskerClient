﻿using System;
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
using System.Windows.Shapes;

namespace TaskerClient
{
    /// <summary>
    /// Interaction logic for TaskForm.xaml
    /// </summary>
    public partial class TaskForm : Window
    {
        public TaskForm(Task t)
        {
            DateTime deadline;
            if (t.deadlineDate != default(DateTime))
            {
                deadline = t.deadlineDate;
            }
            else
            {
                deadline = DateTime.Now;
            }
            

            InitializeComponent();

            

            
            txb_name.Text = t.name;
            txb_description.Text = t.description;
            cmb_priorityId.SelectedIndex = t.priority;
            datePicker_deadlineDate.SelectedDate = deadline;
            txb_taskIdHidden.Text = t.id.ToString();

            if (txb_taskIdHidden.Text == "0")
            {

                bnt_FinishTask.Visibility = Visibility.Hidden;
            }
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            TaskerServ taskerServ = new TaskerServ();
            if (txb_taskIdHidden.Text == "0")
            {
                
                taskerServ.CreateTask(CreateTaskFromReference());
            }
            else
            {
                
                taskerServ.EditTask(CreateTaskFromReference());
            }

            this.Close();
        }

        public TaskerReference.Task CreateTaskFromReference()
        {
            TaskerReference.Task t = new TaskerReference.Task();

            t.id = Int32.Parse(txb_taskIdHidden.Text);
            t.name = txb_name.Text;
            t.description = txb_description.Text;
            t.priority = cmb_priorityId.SelectedIndex;
            t.deadlineDate = datePicker_deadlineDate.DisplayDate;


            return t;
        }

        private void bnt_FinishTask_Click(object sender, RoutedEventArgs e)
        {
            TaskerServ taskerServ = new TaskerServ();
            int id = Int32.Parse(txb_taskIdHidden.Text);
            taskerServ.FinishTask(id);
            this.Close();
        }
    }
}