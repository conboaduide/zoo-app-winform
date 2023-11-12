using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Animal
{
    public int Id { get; set; }

    public DateTime? ArivalDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public DateTime? DateOfDeath { get; set; }

    public string? ImgUrl { get; set; }

    public string? Name { get; set; }

    public string? Origin { get; set; }

    public bool? Sex { get; set; }

    public int? CreatedBy { get; set; }

    public virtual ICollection<AnimalTrainerAssignor> AnimalTrainerAssignors { get; set; } = new List<AnimalTrainerAssignor>();

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<FeedingSchedule> FeedingSchedules { get; set; } = new List<FeedingSchedule>();
}
