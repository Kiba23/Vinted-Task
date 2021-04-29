using DiscountEvaluator.Interfaces;
using System;

namespace DiscountEvaluator.Handlers
{
    public class HandlersStart : IHandlerStartable
    {
        private readonly IShipmentHandler _shipmentHandler;
        private readonly IRulesHandler _rulesHandler;
        private readonly IDiscountHandler _discountHandler;

        public HandlersStart()
        {
            _shipmentHandler = new ShipmentHandler();
            _rulesHandler = new RulesHandler();
            _discountHandler = new DiscountHandler();
        }

        public HandlersStart(decimal maxDiscount)
        {
            _shipmentHandler = new ShipmentHandler();
            _rulesHandler = new RulesHandler();
            _discountHandler = new DiscountHandler(maxDiscount);
        }

        public IShipment Start(string shipmentStr)
        {
            var shipment = _shipmentHandler.CreateShipment(shipmentStr);

            if (shipment == null)
                return null;

            var initialShipmentPrice = shipment.Price ?? throw new ArgumentNullException("Price is null.");

            _rulesHandler.ApplyRules(shipment);

            _discountHandler.StartDiscountFunctions(shipment, initialShipmentPrice);

            return shipment;
        }
    }
}
