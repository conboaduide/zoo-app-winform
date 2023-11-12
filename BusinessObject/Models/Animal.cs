using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Animal
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Species { get; set; }

    public string? Location { get; set; }

    public string? Class { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? Status { get; set; }
}
