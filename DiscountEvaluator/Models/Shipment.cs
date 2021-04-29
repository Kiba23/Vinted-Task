using DiscountEvaluator.Interfaces;
using System;
using System.Linq;

namespace DiscountEvaluator.Models
{
    public class Shipment : IShipment
    {
        public DateTime Date { get; set; }
        public Sizes? Size { get; set; }
        public Companies? Company { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }

        public Shipment(DateTime date, Sizes size, Companies company)
        {
            Date = date;
            Size = size;
            Company = company;
            Price = PriceInitializer.Prices.FirstOrDefault(p => p.Size == Size && p.Company == Company).Price;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} {Size} {Company} {string.Format("{0:0.00}", Price)} " +
                $"{(Discount == 0 || Discount == null ? "-" : $"{string.Format("{0:0.00}", Discount)}")}";
        }
    }
}