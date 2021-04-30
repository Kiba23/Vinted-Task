
namespace DiscountEvaluator.Interfaces
{
    public interface IDiscountHandler
    {
        void StartDiscountFunctions(IShipment shipment, decimal initialShipmentPrice);
    }
}
