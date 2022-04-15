using Microsoft.EntityFrameworkCore;

namespace GeekShopping.CouponAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coupon>()
                .ToTable("coupon");

            modelBuilder.Entity<Coupon>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Coupon>()
                .Property(s => s.Id)
                .HasColumnName("id");

            modelBuilder.Entity<Coupon>()
                .Property(s => s.CouponCode)
                .HasColumnName("coupon_code")
                .HasMaxLength(30)
                .IsRequired();

            modelBuilder.Entity<Coupon>()
                .Property(s => s.DiscountAmount)
                .HasColumnName("discount_amount")
                .HasPrecision(10,2)
                .IsRequired();

            modelBuilder.Entity<Coupon>()
                .HasData(Seed());
        }

        private List<Coupon> Seed()
        {
            return new List<Coupon>
            {
                new Coupon
                {
                    Id = Guid.NewGuid(),
                    CouponCode = "EDU_10",
                    DiscountAmount = 10
                },
                new Coupon
                {
                    Id = Guid.NewGuid(),
                    CouponCode = "EDU_20",
                    DiscountAmount = 20
                }
            };
        }
    }
}
