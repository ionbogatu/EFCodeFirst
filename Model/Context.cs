using Microsoft.EntityFrameworkCore;

namespace CodeFirstEF.Model
{
    internal class Context : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        
        public DbSet <Order> Orders { get; set; }
        
        public DbSet <OrderDetails> OrderDetails { get; set; }
        
        public DbSet <Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=IONBOGATU-PC;Database=efcore; Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>()
                .HasMany(o => o.Orders)
                .WithOne(c => c.Client);

            builder.Entity<OrderDetails>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails);

            builder.Entity<Product>()
                .HasMany(p => p.OrderDetails)
                .WithOne(od => od.Product);
        }
    }
}
