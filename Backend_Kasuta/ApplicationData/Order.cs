using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class Order
{
    public int OrderId { get; set; }

    public string OrderNumber { get; set; } = null!;

    public int ClothId { get; set; }

    public int UserId { get; set; }

    public int DeliveryPointId { get; set; }

    public DateTime OrderDate { get; set; }

    public int StatusId { get; set; }

    public virtual Clothe Cloth { get; set; } = null!;

    public virtual DeliveryPoint DeliveryPoint { get; set; } = null!;

    public virtual Status Status { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
