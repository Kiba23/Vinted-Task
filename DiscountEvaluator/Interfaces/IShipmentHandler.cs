using DiscountEvaluator.Models;

namespace DiscountEvaluator.Interfaces
{
    interface IShipmentHandler
    {
        IShipment CreateShipment(string shipment);
    }
}
