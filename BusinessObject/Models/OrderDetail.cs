using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class OrderDetail
{
    public int Id { get; set; }

    public bool? IsChecked { get; set; }

    public int? CheckedBy { get; set; }

    public int? OrderId { get; set; }

    public int? TicketId { get; set; }

    public virtual User? CheckedByNavigation { get; set; }

    public virtual User? Order { get; set; }

    public virtual Ticket? Ticket { get; set; }
}
