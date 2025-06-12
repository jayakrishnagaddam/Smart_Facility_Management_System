using System;
using System.Collections.Generic;

namespace SFM_DataAccessLayer.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? Department { get; set; }

    public string SecurityAnswer0 { get; set; } = null!;

    public string SecurityAnswer1 { get; set; } = null!;
}
