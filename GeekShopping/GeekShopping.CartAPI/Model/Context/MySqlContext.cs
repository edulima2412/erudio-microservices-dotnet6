using GeekShopping.CartAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CartAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(decimal))))
                property.SetColumnType("decimal(10,2)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MySqlContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
