using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class Favorite
{
    public int FavoriteId { get; set; }

    public int ClothId { get; set; }

    public int UserId { get; set; }

    public virtual Clothe Cloth { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
