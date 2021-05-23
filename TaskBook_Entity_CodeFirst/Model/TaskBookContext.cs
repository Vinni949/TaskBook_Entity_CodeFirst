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
        public DbSet<Consumer> Consumers { get; set; }
        public DbSet<Executor> Executors { get; set; }
        public DbSet<Departamen> Departamens { get; set; }
        public DbSet<Specialization> Specializations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server = localhost; user = sa; database = TaskBook_Entity_CodeFirst; password = SAsa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<TaskBook>(entity =>
            {
                entity.Property(e => e.TaskName)
                .HasMaxLength(20)
                .IsRequired();

                entity.Property(e=>e.Id)
                .HasColumnName("ID")
                .IsRequired();
            });

            modelBuilder.Entity<Priority>(e =>
            {
                e.Property(e => e.Title)
                .HasMaxLength(15)
                .IsRequired();
            });

            modelBuilder.Entity<Status>(e =>
            {
                e.Property(e => e.Title)
                .HasMaxLength(10)
                .IsRequired();
            });
        }
    }
}
