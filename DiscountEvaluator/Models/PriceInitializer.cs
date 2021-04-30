using System.Collections.Generic;

namespace DiscountEvaluator.Models
{
    static class PriceInitializer // It is static because we don't need to have objects of this class
    {
        // Simulating the table of prices
        public static readonly List<Pricing> Prices = new List<Pricing>
        {
            new Pricing(Companies.LP, Sizes.S, 1.50M),
            new Pricing(Companies.LP, Sizes.M, 4.90M),
            new Pricing(Companies.LP, Sizes.L, 6.90M),
            new Pricing(Companies.MR, Sizes.S, 2M),
            new Pricing(Companies.MR, Sizes.M, 3M),
            new Pricing(Companies.MR, Sizes.L, 4M)
        };
    }
}
