using DiscountEvaluator.Interfaces;

namespace DiscountEvaluator.Rules.Rules_Interfaces
{
    interface IDiscountExceed
    {
        void ApplyDiscount(IShipment shipment, decimal initialShipmentPrice);
    }
}
