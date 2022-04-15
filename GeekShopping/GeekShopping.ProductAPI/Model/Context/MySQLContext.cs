using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
                .HasPrecision(10, 2)
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

            modelBuilder.Entity<Product>()
                .HasData(Seed());
        }

        private List<Product> Seed()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Camisa Jurassic Park",
                    Price = 69.90M,
                    Description = "Camisa social P",
                    CategoryName = "T-shirt",
                    ImageURL = "2_no_internet.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Camisa Star Wars",
                    Price = 150.90M,
                    Description = "Camisa do star wars",
                    CategoryName = "T-shirt",
                    ImageURL = "4_storm_tropper.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Camisa SpaceX",
                    Price = 35.90M,
                    Description = "Camisa spaceX M",
                    CategoryName = "T-shirt",
                    ImageURL = "6_spacex.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Caneca Mario",
                    Price = 15.90M,
                    Description = "Linda caneca do mario",
                    CategoryName = "Caneca",
                    ImageURL = "1_super_mario.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Nave Millenium Falcon",
                    Price = 1500M,
                    Description = "Nave millenium falcon do star wars",
                    CategoryName = "Brinquedo",
                    ImageURL = "10_milennium_falcon.jpg"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Camisa Dragon Ball",
                    Price = 55.90M,
                    Description = "Camisa do dragon ball G",
                    CategoryName = "T-shirt",
                    ImageURL = "13_dragon_ball.jpg"
                },
            };
        }
    }
}
