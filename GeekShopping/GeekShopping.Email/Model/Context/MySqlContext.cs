using Microsoft.EntityFrameworkCore;

namespace GeekShopping.Email.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<EmailLog> Emails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmailLog>().ToTable("email_logs");

            modelBuilder.Entity<EmailLog>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<EmailLog>()
                .Property(s => s.Id)
                .HasColumnName("id");

            modelBuilder.Entity<EmailLog>()
                .Property(s => s.Email)
                .HasColumnName("email")
                .HasMaxLength(255);

            modelBuilder.Entity<EmailLog>()
                .Property(s => s.Log)
                .HasColumnName("log")
                .HasMaxLength(500);

            modelBuilder.Entity<EmailLog>()
                .Property(s => s.SentDate)
                .HasColumnName("sent_date");
        }
    }
}
