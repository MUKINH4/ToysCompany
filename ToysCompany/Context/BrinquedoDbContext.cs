using Microsoft.EntityFrameworkCore;
using ToysCompany.Models;

namespace ToysCompany.Context
{
    public class BrinquedoDbContext : DbContext
    {
        public BrinquedoDbContext(DbContextOptions<BrinquedoDbContext> options) : base(options)
        {
        }

        public DbSet<Brinquedo> Brinquedos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
