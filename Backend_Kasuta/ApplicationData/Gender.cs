using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class Gender
{
    public int GenderId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Clothe> Clothes { get; set; } = new List<Clothe>();
}
