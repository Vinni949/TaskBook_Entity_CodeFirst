using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBook_Entity_CodeFirst.Model
{
    class TaskBookContext:DbContext
    {
        public DbSet<TaskBook> TaskBooks { get; set; }
        public DbSet<Priority> Prioritys { get; set; }
        public DbSet<Deadline> Deadlines { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server = localhost; user = sa; database = TaskBook_Entity_CodeFirst; password = SAsa");
            }
        }
    }
}
