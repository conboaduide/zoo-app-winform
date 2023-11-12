using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Diet
{
    public int Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Type { get; set; }

    public int? CreatedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<DietFood> DietFoods { get; set; } = new List<DietFood>();

    public virtual ICollection<FeedingSchedule> FeedingSchedules { get; set; } = new List<FeedingSchedule>();
}
