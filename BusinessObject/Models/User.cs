using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public bool? Sex { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Nationality { get; set; }

    public string? Phone { get; set; }

    public string? Password { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? Status { get; set; }

    public string? AvatarUrl { get; set; }

    public string? ResetToken { get; set; }

    public virtual ICollection<AnimalTrainerAssignor> AnimalTrainerAssignorAssignedByNavigations { get; set; } = new List<AnimalTrainerAssignor>();

    public virtual ICollection<AnimalTrainerAssignor> AnimalTrainerAssignorTrainers { get; set; } = new List<AnimalTrainerAssignor>();

    public virtual ICollection<Animal> Animals { get; set; } = new List<Animal>();

    public virtual ICollection<Diet> Diets { get; set; } = new List<Diet>();

    public virtual ICollection<Food> Foods { get; set; } = new List<Food>();

    public virtual ICollection<OrderDetail> OrderDetailCheckedByNavigations { get; set; } = new List<OrderDetail>();

    public virtual ICollection<OrderDetail> OrderDetailOrders { get; set; } = new List<OrderDetail>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
