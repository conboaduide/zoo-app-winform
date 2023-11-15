using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class AnimalTrainerAssignor
{
    public int Id { get; set; }

    public int? AnimalId { get; set; }

    public int? AssignedBy { get; set; }

    public int? TrainerId { get; set; }

    public virtual Animal? Animal { get; set; }

    public virtual User? AssignedByNavigation { get; set; }

    public virtual User? Trainer { get; set; }
}
