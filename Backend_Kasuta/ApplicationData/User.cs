using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class User
{
    public int UserId { get; set; }

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? CoverImage { get; set; }

    public virtual ICollection<Clothe> Clothes { get; set; } = new List<Clothe>();

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
