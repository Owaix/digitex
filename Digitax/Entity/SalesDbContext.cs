using CoreSM.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreSM.Model
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext()
        {
        }

        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<SalesCategory> SalesCategory { get; set; }
        public DbSet<Payment> Payment { get; set; }
    }
}
