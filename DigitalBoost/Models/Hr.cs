using System;
using System.Collections.Generic;

namespace DigitalBoost.Models;

public partial class Hr
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? GoogleId { get; set; }
}
