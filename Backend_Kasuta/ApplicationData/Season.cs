using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class Season
{
    public int SeasonId { get; set; }

    public string Name { get; set; } = null!;

    public string HexColor { get; set; } = null!;

    public string CoverImage { get; set; } = null!;

    public virtual ICollection<Clothe> Clothes { get; set; } = new List<Clothe>();
}
