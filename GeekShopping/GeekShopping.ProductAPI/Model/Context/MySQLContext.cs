using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties()
                    .Where(p => p.ClrType == typeof(decimal))))
                property.SetColumnType("decimal(10,2)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MySqlContext).Assembly);

            modelBuilder.Entity<Product>().HasData(Seed());

            base.OnModelCreating(modelBuilder);
        }

        private List<Product> Seed()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Camisa Social",
                    Price = 69.90M,
                    Description = "Camisa social P",
                    CategoryName = "T-shirt",
                    ImageURL = "https://th.bing.com/th/id/R.2a89878829d77f092f240129da8b185b?rik=3eK%2b3Ekb18pHjA&pid=ImgRaw&r=0"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Camisa Time",
                    Price = 150.90M,
                    Description = "Camisa do vasco",
                    CategoryName = "T-shirt",
                    ImageURL = "https://th.bing.com/th/id/R.222559365766c1c20d5a484703a08de1?rik=NAt9lgVgbDm1UQ&pid=ImgRaw&r=0"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Camisa Adidas",
                    Price = 35.90M,
                    Description = "Camisa adidas M",
                    CategoryName = "T-shirt",
                    ImageURL = "https://th.bing.com/th/id/OIP.8gSxyAC3iGCbLdA726Y2TAHaHa?pid=ImgDet&rs=1"
                },
                new Product
                {
                    Id = Guid.NewGuid(),
                    Name = "Camisa Social Feminina",
                    Price = 80.90M,
                    Description = "Camisa feminina manga longa",
                    CategoryName = "T-shirt",
                    ImageURL = "https://th.bing.com/th/id/R.1db75a836a6023f811d21452a8cb93db?rik=SJW8sBtMBBREeg&riu=http%3a%2f%2fmaxdicas.com%2fwp-content%2fuploads%2f2016%2f07%2fcamisa-feminina-xadrez-da-moda.jpg&ehk=yz1Tn4oClJNlMtbf3YkrplbHFJTDhfoLgP9iwXo4m84%3d&risl=&pid=ImgRaw&r=0"
                },
            };
        }
    }
}
