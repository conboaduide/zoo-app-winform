using System;
using System.Collections.Generic;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccessObject;

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

    public virtual DbSet<AnimalTrainerAssignor> AnimalTrainerAssignors { get; set; }

    public virtual DbSet<Diet> Diets { get; set; }

    public virtual DbSet<DietFood> DietFoods { get; set; }

    public virtual DbSet<FeedingSchedule> FeedingSchedules { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

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
            entity.HasKey(e => e.Id).HasName("PK__animal__3213E83FD6320989");

            entity.ToTable("animal");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ArivalDate)
                .HasPrecision(6)
                .HasColumnName("arival_date");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(6)
                .HasColumnName("created_date");
            entity.Property(e => e.DateOfBirth)
                .HasPrecision(6)
                .HasColumnName("date_of_birth");
            entity.Property(e => e.DateOfDeath)
                .HasPrecision(6)
                .HasColumnName("date_of_death");
            entity.Property(e => e.ImgUrl)
                .IsUnicode(false)
                .HasColumnName("img_url");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Origin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("origin");
            entity.Property(e => e.Sex).HasColumnName("sex");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Animals)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__animal__created___5DCAEF64");
        });

        modelBuilder.Entity<AnimalTrainerAssignor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__animal_t__3213E83F2C222E31");

            entity.ToTable("animal_trainer_assignor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnimalId).HasColumnName("animal_id");
            entity.Property(e => e.AssignedBy).HasColumnName("assigned_by");
            entity.Property(e => e.TrainerId).HasColumnName("trainer_id");

            entity.HasOne(d => d.Animal).WithMany(p => p.AnimalTrainerAssignors)
                .HasForeignKey(d => d.AnimalId)
                .HasConstraintName("FK__animal_tr__anima__60A75C0F");

            entity.HasOne(d => d.AssignedByNavigation).WithMany(p => p.AnimalTrainerAssignorAssignedByNavigations)
                .HasForeignKey(d => d.AssignedBy)
                .HasConstraintName("FK__animal_tr__assig__619B8048");

            entity.HasOne(d => d.Trainer).WithMany(p => p.AnimalTrainerAssignorTrainers)
                .HasForeignKey(d => d.TrainerId)
                .HasConstraintName("FK__animal_tr__train__628FA481");
        });

        modelBuilder.Entity<Diet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__diet__3213E83F10869EFA");

            entity.ToTable("diet");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(6)
                .HasColumnName("created_date");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Diets)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__diet__created_by__693CA210");
        });

        modelBuilder.Entity<DietFood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__diet_foo__3213E83F1B8EABDF");

            entity.ToTable("diet_food");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DietId).HasColumnName("diet_id");
            entity.Property(e => e.FoodId).HasColumnName("food_id");

            entity.HasOne(d => d.Diet).WithMany(p => p.DietFoods)
                .HasForeignKey(d => d.DietId)
                .HasConstraintName("FK__diet_food__diet___6C190EBB");

            entity.HasOne(d => d.Food).WithMany(p => p.DietFoods)
                .HasForeignKey(d => d.FoodId)
                .HasConstraintName("FK__diet_food__food___6D0D32F4");
        });

        modelBuilder.Entity<FeedingSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__feeding___3213E83F798C4178");

            entity.ToTable("feeding_schedule");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AnimalId).HasColumnName("animal_id");
            entity.Property(e => e.ConformationImgUrl)
                .IsUnicode(false)
                .HasColumnName("conformation_img_url");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(6)
                .HasColumnName("created_date");
            entity.Property(e => e.DietId).HasColumnName("diet_id");
            entity.Property(e => e.Fed).HasColumnName("fed");
            entity.Property(e => e.FedTime)
                .HasPrecision(6)
                .HasColumnName("fed_time");
            entity.Property(e => e.FeedingTime)
                .HasPrecision(6)
                .HasColumnName("feeding_time");

            entity.HasOne(d => d.Animal).WithMany(p => p.FeedingSchedules)
                .HasForeignKey(d => d.AnimalId)
                .HasConstraintName("FK__feeding_s__anima__6FE99F9F");

            entity.HasOne(d => d.Diet).WithMany(p => p.FeedingSchedules)
                .HasForeignKey(d => d.DietId)
                .HasConstraintName("FK__feeding_s__diet___70DDC3D8");
        });

        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__food__3213E83F6618E90C");

            entity.ToTable("food");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(6)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_date");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Foods)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK__food__created_by__66603565");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__order__3213E83F09370685");

            entity.ToTable("order");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(6)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_date");
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("payment_method");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Total).HasColumnName("total");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__order__customer___5535A963");
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__order_de__3213E83F60CD4DB2");

            entity.ToTable("order_detail");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CheckedBy).HasColumnName("checked_by");
            entity.Property(e => e.IsChecked).HasColumnName("is_checked");
            entity.Property(e => e.OrderId).HasColumnName("orderId");
            entity.Property(e => e.TicketId).HasColumnName("ticketId");

            entity.HasOne(d => d.CheckedByNavigation).WithMany(p => p.OrderDetailCheckedByNavigations)
                .HasForeignKey(d => d.CheckedBy)
                .HasConstraintName("FK__order_det__check__59063A47");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetailOrders)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__order_det__order__59FA5E80");

            entity.HasOne(d => d.Ticket).WithMany(p => p.OrderDetails)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK__order_det__ticke__5AEE82B9");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__role__3213E83F41F2369E");

            entity.ToTable("role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ticket__3213E83FF5EEBF8E");

            entity.ToTable("ticket");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(6)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_date");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.ImgUrl)
                .IsUnicode(false)
                .HasColumnName("img_url");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user__3213E83F5FC0F16F");

            entity.ToTable("user");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.AvatarUrl)
                .IsUnicode(false)
                .HasColumnName("avatar_url");
            entity.Property(e => e.CreatedDate)
                .HasPrecision(6)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("created_date");
            entity.Property(e => e.DateOfBirth)
                .HasPrecision(6)
                .HasColumnName("dateOfBirth");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Nationality)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nationality");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.ResetToken)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("reset_token");
            entity.Property(e => e.Sex).HasColumnName("sex");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__user_rol__3213E83F84BA7240");

            entity.ToTable("user_role");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleId).HasColumnName("role_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__user_role__role___4F7CD00D");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__user_role__user___4E88ABD4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
