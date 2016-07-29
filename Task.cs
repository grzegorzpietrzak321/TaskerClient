using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskerClient
{
    public class Task
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public int priority { get; set; }

        public DateTime deadlineDate { get; set; }

        public bool isFinished { get; set; }

        public DateTime CreateDate;

        public Task(string name, string description, int priority, DateTime deadlineDate)
        {
            this.name = name;
            this.description = description;
            this.priority = priority;
            this.deadlineDate = deadlineDate;
        }

        public Task()
        {

        }
    }
}

