
namespace DiscountEvaluator.Interfaces
{
    interface IDiscountHandler
    {
        void StartDiscountFunctions(IShipment shipment, decimal initialShipmentPrice);
    }
}
