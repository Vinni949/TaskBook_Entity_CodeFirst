using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook_Entity_CodeFirst.Model
{
    class Specialization
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public List<Consumer> Consumers { get; set; }
        public List<Executor> Executors { get; set; }
        public Specialization()
        {
            Executors = new List<Executor>();
            Consumers = new List<Consumer>();
        }
    }
}
