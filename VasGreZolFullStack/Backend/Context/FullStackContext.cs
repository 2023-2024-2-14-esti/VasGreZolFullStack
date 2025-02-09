using VasGreZolFullStack.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace VasGreZolFullStack.Backend.Context
{
    public class FullStackContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public FullStackContext(DbContextOptions<FullStackContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
