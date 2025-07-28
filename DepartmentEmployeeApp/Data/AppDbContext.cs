using DepartmentEmployeeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DepartmentEmployeeApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; } 
    }
}
