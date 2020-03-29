using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace RepositoryInfrastructure
{
    public class DomainContext : DbContext
    {
        public DomainContext(DbContextOptions<DomainContext> options) : 
            base(options)
        {
        }

        public DbSet<SimulatedPatient> SimulatedPatients { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Instructor> Instructors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().Property(assignment => assignment.Name).IsRequired();
            modelBuilder.Entity<Customer>().Property(assignment => assignment.Name).IsRequired();
            modelBuilder.Entity<Instructor>().Property(assignment => assignment.Name).IsRequired();

            modelBuilder.Entity<SimulatedPatient>().Property(assignment => assignment.Email).IsRequired();
            modelBuilder.Entity<SimulatedPatient>().Property(assignment => assignment.FirstName).IsRequired();
            modelBuilder.Entity<SimulatedPatient>().Property(assignment => assignment.LastName).IsRequired();

            modelBuilder.Entity<AssignmentInstructor>().HasKey(table => new {table.AssignmentId, table.InstructorId});
        }
    }
}
