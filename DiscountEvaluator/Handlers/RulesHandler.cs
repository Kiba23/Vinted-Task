using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Rules;
using DiscountEvaluator.Rules.Rules_Interfaces;

namespace DiscountEvaluator.Handlers
{
    class RulesHandler : IRulesHandler
    {
        private readonly ILowestPackagePrice _lowestPackagePrice;
        private readonly IThirdFreeShipment _thirdFreeShipment;

        public RulesHandler() 
        {
            _lowestPackagePrice = new LowestPackagePrice();
            _thirdFreeShipment = new ThirdFreeShipment();
        }

        public void ApplyRules(IShipment shipment)
        {
            _lowestPackagePrice.ApplyLowestPriceRule(shipment);

            _thirdFreeShipment.ApplyThirdRule(shipment);
        }
    }
}
