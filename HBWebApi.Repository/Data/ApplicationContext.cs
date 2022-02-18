using HBWebApi.Entities.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace HBWebApi.Repository.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasKey(p => new { p.PersonID });
            modelBuilder.Entity<Orders>().HasKey(o => new { o.OrderID, o.PersonID });
            modelBuilder.Entity<OrdersDetails>().HasKey(od => new { od.OrderID });
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrdersDetails> OrdersDetails { get; set; }

    }
}
