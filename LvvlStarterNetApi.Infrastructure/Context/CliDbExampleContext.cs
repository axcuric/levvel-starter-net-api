using LvvlStarterNetApi.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace LvvlStarterNetApi.Infrastructure.Context
{
    public class CliDbExampleContext : DbContext
    {
        public CliDbExampleContext()
        {
        }

        public CliDbExampleContext(DbContextOptions<CliDbExampleContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Phone>(entity =>
            {
                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.HasOne(d => d.User)
                //    .WithMany(p => p.Phones)
                //    .HasForeignKey(d => d.UserId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_UserPhones_Users");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}