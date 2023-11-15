using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Order
{
    public int Id { get; set; }

    public string? PaymentMethod { get; set; }

    public bool? Status { get; set; }

    public double? Total { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual User? Customer { get; set; }
}
