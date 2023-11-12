using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public decimal Price { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedDate { get; set; }
}
