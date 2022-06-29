using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication1.Models
{
    public partial class EcomContext : DbContext
    {
        public EcomContext()
        {
        }

        public EcomContext(DbContextOptions<EcomContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ecom> Ecoms { get; set; }
        public virtual DbSet<Tbllogin> Tbllogins { get; set; }
        public object Tbllogin { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Ecom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ecom");

                entity.Property(e => e.UserContact)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("userContact");

                entity.Property(e => e.UserId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("userId");

                entity.Property(e => e.UserName)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<Tbllogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbllogin");

                entity.Property(e => e.Id)
                    .HasMaxLength(100)
                    .HasColumnName("ID");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
