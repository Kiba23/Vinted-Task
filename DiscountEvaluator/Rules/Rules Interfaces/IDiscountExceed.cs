using DiscountEvaluator.Interfaces;

namespace DiscountEvaluator.Rules.Rules_Interfaces
{
    interface IDiscountExceed
    {
        void CheckDiscount(IShipment shipment, decimal maxDiscount);
    }
}
