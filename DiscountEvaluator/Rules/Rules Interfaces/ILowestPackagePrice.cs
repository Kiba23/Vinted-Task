using DiscountEvaluator.Interfaces;

namespace DiscountEvaluator.Rules.Rules_Interfaces
{
    interface ILowestPackagePrice
    {
        void ApplyLowestPriceRule(IShipment shipment);
    }
}
