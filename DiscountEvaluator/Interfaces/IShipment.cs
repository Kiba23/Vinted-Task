using System;

namespace DiscountEvaluator.Interfaces
{
    public interface IShipment
    {
        DateTime Date { get; set; }
        Sizes? Size { get; set; }
        Companies? Company { get; set; }
        decimal? Price { get; set; }
        decimal? Discount { get; set; }
    }
}
