using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Models;
using DiscountEvaluator.Rules.Rules_Interfaces;
using System.Linq;

namespace DiscountEvaluator.Rules
{
    public class LowestPackagePrice : ILowestPackagePrice
    {
        public void ApplyLowestPriceRule(IShipment shipment)
        {
            if (shipment.Size == Sizes.S)
            {
                shipment.Price = PriceInitializer.Prices.Where(p => p.Size == Sizes.S)
                    .OrderBy(p => p.Price).First().Price;
            }
        }
    }
}
