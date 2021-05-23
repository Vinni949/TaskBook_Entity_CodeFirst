using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook_Entity_CodeFirst.Model
{
    class Executor
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public List<TaskBook> TaskBooks { get; set; }
        public Executor()
        {
            TaskBooks = new List<TaskBook>();
        }
    }
}
