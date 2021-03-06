﻿using Ahbc.Class.FiftyOne.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ahbc.Class.FiftyOne.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
            Database.SetInitializer(new SchoolDbInitializer());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}