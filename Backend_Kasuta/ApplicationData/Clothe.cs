using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class Clothe
{
    public int ClothId { get; set; }

    public string Name { get; set; } = null!;

    public int SeasonId { get; set; }

    public int CategoryId { get; set; }

    public int MaterialId { get; set; }

    public int? SizeRu { get; set; }

    public int GenderId { get; set; }

    public int UserId { get; set; }

    public decimal Cost { get; set; }

    public string? CoverImage { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual Gender Gender { get; set; } = null!;

    public virtual Material Material { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Season Season { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
