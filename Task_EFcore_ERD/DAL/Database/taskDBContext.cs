using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task_EFcore_ERD.DAL.Entity;

namespace Task_EFcore_ERD.DAL.Database
{
    internal class taskDBContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=EF_ERD;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<Instractor> instractors { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Course> courses { get; set; }
        //public DbSet<important_feld> important_Felds { get; set; }
        public DbSet<Topic> topics { get; set; }


    }
}
