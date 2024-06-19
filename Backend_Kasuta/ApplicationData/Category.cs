using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public string HexColor { get; set; } = null!;

    public string CoverImage { get; set; } = null!;

    public string CircleImage { get; set; } = null!;

    public virtual ICollection<Clothe> Clothes { get; set; } = new List<Clothe>();
}
