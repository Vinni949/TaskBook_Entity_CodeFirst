using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook_Entity_CodeFirst.Model
{
    class Consumer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Departamen Departamens { get; set; }
        public Specialization Specializations { get; set; }

        public List<TaskBook> TaskBooks { get; set; }
        public Consumer()
        {
            TaskBooks = new List<TaskBook>();
        }


    }
}
