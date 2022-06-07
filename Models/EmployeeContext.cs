using Microsoft.EntityFrameworkCore;

namespace MVC_CRUD_EF_Core.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}