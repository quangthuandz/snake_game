using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace snake.Models
{
    public partial class Project_PRN211Context : DbContext
    {
        public Project_PRN211Context()
        {
        }

        public Project_PRN211Context(DbContextOptions<Project_PRN211Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Game> Games { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserGame> UserGames { get; set; } = null!;
        public virtual DbSet<UserItem> UserItems { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=QUANGTHUAN;Initial Catalog=Project_PRN211;User ID=sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("Game");

                entity.Property(e => e.GameId)
                    .ValueGeneratedNever()
                    .HasColumnName("GameID");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item");

                entity.Property(e => e.ItemId).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(45)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserGame>(entity =>
            {
                entity.ToTable("UserGame");

                entity.Property(e => e.UserGameId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserGameID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.UserGames)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGame_Game");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGames)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGame_User");
            });

            modelBuilder.Entity<UserItem>(entity =>
            {
                entity.ToTable("UserItem");

                entity.Property(e => e.UserItemId).ValueGeneratedNever();

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.UserItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserItem_Item");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserItems)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
