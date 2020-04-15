using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BGCMIN4;Database=orderdb;Trusted_Connection=True;");
        }
    }
}