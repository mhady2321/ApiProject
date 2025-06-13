using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Models
{
    public class ApiAppContext : DbContext
    {
        public ApiAppContext(DbContextOptions options) : base(options)
        { 

        }
       public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

    }
}    
