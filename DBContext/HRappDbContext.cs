using HRapp.Models;
using Microsoft.EntityFrameworkCore;

namespace HRapp.DBContext
{
    public class HRappDbContext: DbContext
    {
        public HRappDbContext(DbContextOptions options) : base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees) // A department has many employees
                .WithOne(e => e.Department) // An employee belongs to one department
                .HasForeignKey(e => e.DepartmentId); // Foreign key on Employee references Department
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
