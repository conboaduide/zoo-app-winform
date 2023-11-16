using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class OrderDetailDTO
{
    public int Id { get; set; }


    public int TicketId { get; set; }

    public decimal Price { get; set; }

    public bool Status { get; set; }
    public int Quantity { get; set; }
}
