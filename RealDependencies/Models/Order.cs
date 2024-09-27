﻿namespace RealDependencies.Models;

public class Order
{
    public DateTime TimeOfPurchase { get; set; }
    public decimal TotalPrice { get; set; }
    public List<string> LineItems { get; set; }
}