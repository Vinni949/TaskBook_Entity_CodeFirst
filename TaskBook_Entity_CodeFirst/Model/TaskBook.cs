using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook_Entity_CodeFirst.Model
{
    class TaskBook
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TechnicalSpecification { get; set; }
        public int Deadline { get; set; }
        public int Status_ID { get; set; }
        public int Executor_ID { get; set; }
        public int Consumer_ID { get; set; }

        public Priority Priorities { get; set; }


    }
}
