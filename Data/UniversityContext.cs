using Microsoft.EntityFrameworkCore;
using MSSQL_Number_Three.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSQL_Number_Three.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext()
        {

        }

        public UniversityContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Students> Students {get;set;}
        public virtual DbSet<Courses> Courses {get;set;}
        public virtual DbSet<Resources> Resources { get; set; }
        public virtual DbSet<HomeworkSubmissions> HomeworkSubmissions { get; set; }
        public virtual DbSet<StudentCourses> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString: @"Server=.;Database=University;Integrated Security=True;");
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>(entity =>
            {
                entity.HasKey(sc => new { sc.CourseId, sc.StudentId });
            });
        }
    }
}
