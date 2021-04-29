using DiscountEvaluator.Helpers;
using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Models;
using System;

namespace DiscountEvaluator.Handlers
{
    public class ShipmentHandler : IShipmentHandler
    {
        public IShipment CreateShipment(string shipmentStr)
        {
            string[] shipmentData = shipmentStr.Split(' ');

            if (shipmentData.Length > 0 && shipmentData.Length < 4) 
            {
                try
                {
                    return new Shipment(
                        TryParser.DateTimeTryParse(shipmentData[0]),
                        TryParser.SizeTryParse(shipmentData[1]),
                        TryParser.CompanyTryParse(shipmentData[2])
                        );
                }
                catch (InvalidCastException)
                {
                    Output.IgnoredOutput(shipmentStr);
                }
            }
            return null;
        }
    }
}
