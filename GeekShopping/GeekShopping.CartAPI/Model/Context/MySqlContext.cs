using GeekShopping.CartAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

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
            #region Product

            modelBuilder.Entity<Product>()
                .ToTable("product");

            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
                .Property(s => s.Id)
                .HasColumnName("id");

            modelBuilder.Entity<Product>()
                .Property(s => s.Name)
                .HasColumnName("name")
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(s => s.Price)
                .HasColumnName("price")
                .HasPrecision(10,2)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(s => s.Name)
                .HasColumnName("name")
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(s => s.Description)
                .HasColumnName("description")
                .HasMaxLength(500);

            modelBuilder.Entity<Product>()
                .Property(s => s.CategoryName)
                .HasColumnName("category_name")
                .HasMaxLength(50);

            modelBuilder.Entity<Product>()
                .Property(s => s.ImageURL)
                .HasColumnName("image_url")
                .HasMaxLength(300);

            #endregion

            #region CartHeader
            
            modelBuilder.Entity<CartHeader>().ToTable("cart_header");

            modelBuilder.Entity<CartHeader>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<CartHeader>()
                .Property(s => s.Id)
                .HasColumnName("id");

            modelBuilder.Entity<CartHeader>()
                .Property(s => s.UserId)
                .HasColumnName("user_id");

            modelBuilder.Entity<CartHeader>()
                .Property(s => s.CouponCode)
                .HasColumnName("coupon_code")
                .HasMaxLength(30);

            #endregion

            #region CartDetail

            modelBuilder.Entity<CartDetail>().ToTable("cart_detail");

            modelBuilder.Entity<CartDetail>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<CartDetail>()
                .Property(s => s.Id)
                .HasColumnName("id");

            modelBuilder.Entity<CartDetail>()
                .Property(s => s.Count)
                .HasColumnName("count");

            modelBuilder.Entity<CartDetail>()
                .Property(s => s.CartHeaderId)
                .HasColumnName("cart_header_id");

            modelBuilder.Entity<CartDetail>()
                .HasOne(h => h.CartHeader)
                .WithMany()
                .HasForeignKey(p => p.CartHeaderId);

            modelBuilder.Entity<CartDetail>()
                .Property(s => s.ProductId)
                .HasColumnName("product_id");

            modelBuilder.Entity<CartDetail>()
                .HasOne(p => p.Product)
                .WithMany()
                .HasForeignKey(p => p.ProductId);

            #endregion
        }
    }
}
