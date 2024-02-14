using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PoprizhonokTest.Models;

namespace PoprizhonokTest.Context
{
    public partial class PoprizhonokContext : DbContext
    {
        public PoprizhonokContext()
        {
        }

        public PoprizhonokContext(DbContextOptions<PoprizhonokContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agents { get; set; } = null!;
        public virtual DbSet<AgentsOfProduct> AgentsOfProducts { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<TtpeAgent> TtpeAgents { get; set; } = null!;
        public virtual DbSet<TypeProduct> TypeProducts { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-URICGBM\\SQLEXPRESS;Database=Poprizhonok;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agent>(entity =>
            {
                entity.HasKey(e => e.IdAgent)
                    .HasName("PK__Agents__92FC7C030A32A974");

                entity.Property(e => e.Adres).HasMaxLength(255);

                entity.Property(e => e.Director).HasMaxLength(255);

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.Property(e => e.Kpp).HasColumnName("KPP");

                entity.Property(e => e.Mail).HasMaxLength(255);

                entity.Property(e => e.NameAg).HasMaxLength(255);

                entity.Property(e => e.Number).HasMaxLength(255);

                entity.HasOne(d => d.TypeAgent)
                    .WithMany(p => p.Agents)
                    .HasForeignKey(d => d.TypeAgentId)
                    .HasConstraintName("FK_Agents_TtpeAgent");
            });

            modelBuilder.Entity<AgentsOfProduct>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Agent)
                    .WithMany()
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgentsOfProducts_Agents");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgentsOfProducts_Products");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.NamePr).HasMaxLength(255);

                entity.HasOne(d => d.TypeProduct)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.TypeProductId)
                    .HasConstraintName("FK_Products_TypeProducts");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Titel).HasMaxLength(80);
            });

            modelBuilder.Entity<TtpeAgent>(entity =>
            {
                entity.ToTable("TtpeAgent");

                entity.Property(e => e.Titel).HasMaxLength(255);
            });

            modelBuilder.Entity<TypeProduct>(entity =>
            {
                entity.Property(e => e.Titel).HasMaxLength(255);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(80)
                    .HasColumnName("login");

                entity.Property(e => e.Password)
                    .HasMaxLength(80)
                    .HasColumnName("password");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Users__RoleId__6477ECF3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
