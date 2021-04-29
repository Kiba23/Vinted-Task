using DiscountEvaluator.Helpers;
using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Models;
using System;

namespace DiscountEvaluator.Handlers
{
    class ShipmentHandler : IShipmentHandler
    {
        public IShipment CreateShipment(string shipmentStr)
        {
            string[] shipmentData = shipmentStr.Split(' ');

            if (shipmentData.Length > 0 && shipmentData.Length < 4) 
            {
                return new Shipment(
                    DateTime.Parse(shipmentData[0]),
                    TryParser.SizeTryParse(shipmentData[1]),
                    TryParser.CompanyTryParse(shipmentData[2])
                    );
            }
            throw new Exception("Shipment was incorrect");
        }
    }
}
