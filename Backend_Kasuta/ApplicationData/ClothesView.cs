using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class ClothesView
{
    public int ClothId { get; set; }

    public string Name { get; set; } = null!;

    public string Material { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int? SizeRu { get; set; }

    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public decimal Cost { get; set; }

    public string? CoverImage { get; set; }

    public int CategoryId { get; set; }

    public int SeasonId { get; set; }
}
