using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskerClient
{
    class Task
    {
        int id { get; set; }
        string name { get; set; }
        string description { get; set; }
        int priority { get; set; }
        DateTime createDate { get; set; }
        DateTime deadlineDate { get; set; }
        bool isFinished = false;
        public bool IsFinished
        {
            get { return isFinished; }
            set { isFinished = value; }
        }
    }
}
