using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class AnimalCage
{
    public int Id { get; set; }

    public int? AnimalId { get; set; }

    public int? CageId { get; set; }

    public DateTime? MoveInDate { get; set; }

    public DateTime? MoveOutDate { get; set; }
}
