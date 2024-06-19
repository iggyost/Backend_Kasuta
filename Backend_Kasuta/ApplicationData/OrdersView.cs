using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class OrdersView
{
    public int OrderId { get; set; }

    public string? CoverImage { get; set; }

    public string Address { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string OrderNumber { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public int UserId { get; set; }
}
