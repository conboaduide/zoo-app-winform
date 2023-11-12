using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessObject.Models;

public partial class ZooManagementContext : DbContext
{
    public ZooManagementContext()
    {
    }

    public ZooManagementContext(DbContextOptions<ZooManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Animal> Animals { get; set; }

    public virtual DbSet<AnimalCage> AnimalCages { get; set; }

    public virtual DbSet<AnimalTrainer> AnimalTrainers { get; set; }

    public virtual DbSet<Cage> Cages { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    private string GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true).Build();
        return configuration["ConnectionStrings:DBDefault"];
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(GetConnectionString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>(entity =>
        {
            entity.ToTable("animal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Class)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("class");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("createdDate");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("location");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Species)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("species");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<AnimalCage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_aninal_cage");

            entity.ToTable("animal_cage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnimalId).HasColumnName("animalId");
            entity.Property(e => e.CageId).HasColumnName("cageId");
            entity.Property(e => e.MoveInDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("moveInDate");
            entity.Property(e => e.MoveOutDate)
                .HasColumnType("date")
                .HasColumnName("moveOutDate");
        });

        modelBuilder.Entity<AnimalTrainer>(entity =>
        {
            entity.ToTable("animal_trainer");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnimalId).HasColumnName("animalId");
            entity.Property(e => e.ZooTrainerId).HasColumnName("zooTrainerId");
        });

        modelBuilder.Entity<Cage>(entity =>
        {
            entity.ToTable("cage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("createdDate");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.ToTable("order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("createdDate");
            entity.Property(e => e.CustomerId).HasColumnName("customerId");
            entity.Property(e => e.Total)
                .HasColumnType("money")
                .HasColumnName("total");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.ToTable("order_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TicketId).HasColumnName("ticketId");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.ToTable("ticket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("createdDate");
            entity.Property(e => e.Price)
                .HasColumnType("money")
                .HasColumnName("price");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("date")
                .HasColumnName("createdDate");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
