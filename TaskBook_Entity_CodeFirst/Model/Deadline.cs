using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook_Entity_CodeFirst.Model
{
    class Deadline
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public List<TaskBook> TaskBooks { get; set; }
        public Deadline()
        {
            TaskBooks = new List<TaskBook>();
        }
    }
}
