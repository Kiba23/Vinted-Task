using DiscountEvaluator.Interfaces;

namespace DiscountEvaluator.Rules.Rules_Interfaces
{
    interface IThirdFreeShipment
    {
        void ApplyThirdRule(IShipment shipment);
    }
}
