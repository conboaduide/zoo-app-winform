using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class FeedingSchedule
{
    public int Id { get; set; }

    public string? ConformationImgUrl { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? Fed { get; set; }

    public DateTime? FedTime { get; set; }

    public DateTime? FeedingTime { get; set; }

    public int? AnimalId { get; set; }

    public int? DietId { get; set; }

    public virtual Animal? Animal { get; set; }

    public virtual Diet? Diet { get; set; }
}
