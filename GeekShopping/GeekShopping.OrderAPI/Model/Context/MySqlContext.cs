using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.OrderAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<OrderHeader> Headers { get; set; }
        public DbSet<OrderDetail> Details { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region OrderHeader

            modelBuilder.Entity<OrderHeader>().ToTable("order_header");

            modelBuilder.Entity<OrderHeader>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.Id)
                .HasColumnName("id");

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.UserId)
                .HasColumnName("user_id");

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.CouponCode)
                .HasColumnName("coupon_code")
                .HasMaxLength(30);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.PurchaseAmount)
                .HasColumnName("purchase_amount")
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.DiscountAmount)
                .HasColumnName("discount_amount")
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.FirstName)
                .HasColumnName("first_name")
                .HasMaxLength(100);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.LastName)
                .HasColumnName("last_name")
                .HasMaxLength(100);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.PurchaseDate)
                .HasColumnName("purchase_date");

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.OrderTime)
                .HasColumnName("order_time");

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.Phone)
                .HasColumnName("phone_number")
                .HasMaxLength(30);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.Email)
                .HasColumnName("email")
                .HasMaxLength(150);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.CardNumber)
                .HasColumnName("card_number")
                .HasMaxLength(24);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.CVV)
                .HasColumnName("cvv")
                .HasMaxLength(3);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.ExpiryMonthYear)
                .HasColumnName("expiry_month_year")
                .HasMaxLength(4);

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.CartTotalItens)
                .HasColumnName("total_itens");

            modelBuilder.Entity<OrderHeader>()
                .Property(s => s.PaymentStatus)
                .HasColumnName("payment_status");

            modelBuilder.Entity<OrderHeader>()
                .HasMany(d => d.OrderDetails)
                .WithOne(h => h.OrderHeader)
                .HasForeignKey(e => e.OrderHeaderId);

            #endregion

            #region OrderDetail

            modelBuilder.Entity<OrderDetail>().ToTable("order_detail");

            modelBuilder.Entity<OrderDetail>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<OrderDetail>()
                .Property(s => s.Id)
                .HasColumnName("id");

            modelBuilder.Entity<OrderDetail>()
                .Property(s => s.Count)
                .HasColumnName("count");

            modelBuilder.Entity<OrderDetail>()
                .Property(s => s.ProductId)
                .HasColumnName("product_id");

            modelBuilder.Entity<OrderDetail>()
                .Property(s => s.Price)
                .HasColumnName("price")
                .HasPrecision(10, 2);

            modelBuilder.Entity<OrderDetail>()
                .Property(s => s.ProductName)
                .HasColumnName("product_name")
                .HasMaxLength(150);

            modelBuilder.Entity<OrderDetail>()
                .Property(s => s.OrderHeaderId)
                .HasColumnName("order_header_id");

            #endregion
        }
    }
}
