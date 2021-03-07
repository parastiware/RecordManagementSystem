using RecordManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RecordManager.Data
{
    public class RMSDbContext : IdentityDbContext
    {
        public RMSDbContext(DbContextOptions<RMSDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees {get;set;}
    }
}
