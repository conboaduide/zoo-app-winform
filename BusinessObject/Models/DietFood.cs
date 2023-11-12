using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class DietFood
{
    public int Id { get; set; }

    public int? DietId { get; set; }

    public int? FoodId { get; set; }

    public virtual Diet? Diet { get; set; }

    public virtual Food? Food { get; set; }
}
