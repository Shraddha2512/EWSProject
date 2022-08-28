using EmployeeWorkScheduler.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWorkScheduler.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Employee> Employees { get; set; }
      
        public DbSet<Admin> Admins { get; set; }
       
        public DbSet<AssignedTask> AssignedTasks { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Employee>().HasNoKey().ToView(null); 
        //    modelBuilder.Entity<Admin>().HasNoKey().ToView(null); 
        //    modelBuilder.Entity<AssignedTask>().HasNoKey().ToView(null); 
        //}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
    }
}
