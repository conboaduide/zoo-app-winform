using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Cage
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int Capacity { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? Status { get; set; }
}
