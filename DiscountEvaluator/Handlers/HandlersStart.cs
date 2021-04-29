using DiscountEvaluator.Interfaces;
using System;

namespace DiscountEvaluator.Handlers
{
    public class HandlersStart : IHandlerStartable
    {
        private readonly IShipmentHandler _shipmentHandler;
        private readonly IRulesHandler _rulesHandler;

        public HandlersStart()
        {
            _shipmentHandler = new ShipmentHandler();
            _rulesHandler = new RulesHandler();
        }

        public HandlersStart(decimal maxDiscount)
        {
            _shipmentHandler = new ShipmentHandler();
            _rulesHandler = new RulesHandler(maxDiscount);
        }

        public void Start(string shipmentStr)
        {
            var shipment = _shipmentHandler.CreateShipment(shipmentStr) ?? throw new ArgumentNullException
                ("Shipment is null");
            _rulesHandler.ApplyRules(shipment);
        }
    }
}
