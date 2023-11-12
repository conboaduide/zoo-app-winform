using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? ImgUrl { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public bool? Status { get; set; }

    public string? Type { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
