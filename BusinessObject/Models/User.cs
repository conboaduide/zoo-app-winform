using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Role { get; set; }

    public string? Email { get; set; }

    public bool Status { get; set; }

    public DateTime? CreatedDate { get; set; }
}
