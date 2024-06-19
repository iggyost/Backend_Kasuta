using System;
using System.Collections.Generic;

namespace Backend_Kasuta.ApplicationData;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string CardNumber { get; set; } = null!;

    public int Month { get; set; }

    public int Year { get; set; }

    public int Cvv { get; set; }

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
