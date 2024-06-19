using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class Material
{
    public int MaterialId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Clothe> Clothes { get; set; } = new List<Clothe>();
}
