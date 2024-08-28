using Microsoft.EntityFrameworkCore;
using Session03.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("server = .;database = Session03;trusted_Connection = true; trust server certificate = true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentEmployee>().HasNoKey().ToView("DepartmentEmployeesView");


            modelBuilder.Entity<Department>()
                .HasOne(d=> d.Manager)
                .WithOne(e=> e.ManagedDepartments)
                .HasForeignKey<Department>(d=> d.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
                .HasMany(d=> d.Employees)
                .WithOne(e=> e.Departments)
                .HasForeignKey(d=> d.DeptId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Enrollments)
                .WithOne()
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Course>()
                .HasMany(s => s.Enrollments)
                .WithOne()
                .HasForeignKey(e => e.CourseId);

            //modelBuilder.Entity<Student>()
            //    .HasMany(s => s.Courses)
            //    .WithMany(c => c.Students)
            //    .UsingEntity<Enrollments>()
            //    .HasKey(e => new { e.CourseId, e.StudentId });

            modelBuilder.Entity<FullTimeEmployee>()
                .HasBaseType<CompanyEmployee>();

            modelBuilder.Entity<PartTimeEmployee>()
                .HasBaseType<CompanyEmployee>()
                .HasDiscriminator<string>("employeeType");
        }

        public DbSet<DepartmentEmployee> DepartmentEmployee { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<CompanyEmployee> CompanyEmployee { get; set; }
        //public DbSet<FullTimeEmployee> FullTimeEmployee { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployee { get; set; }


    }
}
