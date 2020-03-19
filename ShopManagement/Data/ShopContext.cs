using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ShopManagement.Models;

namespace ShopManagement.Data
{
    public partial class ShopContext : DbContext
    {
        public ShopContext()
        {
        }

        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=B2B\\SQLEXPRESS;Initial Catalog=Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.Idcategory);

                entity.Property(e => e.Idcategory).HasColumnName("IDcategory");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Picture).HasColumnType("image");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.Idemployee)
                    .HasName("PK__Employee__FD0ADB8192EDD033");

                entity.Property(e => e.Idemployee).HasColumnName("IDemployee");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EmploymentDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(24);

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => new { e.Idorder, e.Idproduct });

                entity.ToTable("Order Details");

                entity.Property(e => e.Idorder).HasColumnName("IDorder");

                entity.Property(e => e.Idproduct).HasColumnName("IDproduct");

                entity.Property(e => e.Discount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.IdorderNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Idorder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersPosition_Orders");

                entity.HasOne(d => d.IdproductNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.Idproduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdersPosition_Products");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.Idorder);

                entity.Property(e => e.Idorder).HasColumnName("IDorder");

                entity.Property(e => e.Idemployee).HasColumnName("IDemployee");

                entity.Property(e => e.SellDate).HasColumnType("date");

                entity.HasOne(d => d.IdemployeeNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Idemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Employees");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.Idproduct);

                entity.Property(e => e.Idproduct).HasColumnName("IDproduct");

                entity.Property(e => e.Discount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Idcategory).HasColumnName("IDcategory");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.UnitQuantity)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdcategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.Idcategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Products_Categories");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Login)
                    .HasName("PK_Users_1");

                entity.Property(e => e.Login)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Idemployee).HasColumnName("IDemployee");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdemployeeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Idemployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Employees");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
