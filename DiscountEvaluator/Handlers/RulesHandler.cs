using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Rules;
using DiscountEvaluator.Rules.Rules_Interfaces;

namespace DiscountEvaluator.Handlers
{
    class RulesHandler : IRulesHandler
    {
        private readonly decimal _maxDiscount = 10M;

        public ILowestPackagePrice LowestPackagePrice { get; set; }
        public IThirdFreeShipment ThirdFreeShipment { get; set; }
        public IDiscountExceed DiscountExceed { get; set; }

        public RulesHandler() 
        {
            LowestPackagePrice = new LowestPackagePrice();
            ThirdFreeShipment = new ThirdFreeShipment();
            DiscountExceed = new DiscountExceed();
        }

        public RulesHandler(decimal maxDiscount) : this()
        {
            _maxDiscount = maxDiscount;
        }

        public void ApplyRules(IShipment shipment)
        {
            LowestPackagePrice.ApplyLowestPriceRule(shipment);
            ThirdFreeShipment.ApplyThirdRule(shipment);
            DiscountExceed.CheckDiscount(shipment, _maxDiscount);
            // Difference calcualtion
        }
    }
}
