using DiscountEvaluator.Interfaces;
using System;

namespace DiscountEvaluator
{
    public static class Output
    {
        public static void IgnoredOutput(string shipmentStr)
        {
            Console.WriteLine(shipmentStr + " Ignored");
        }

        public static void ShipmentOutput(IShipment shipment)
        {
            if (shipment != null)
                Console.WriteLine(shipment);
        }

        public static void EndProgram()
        {
            Console.ReadLine();
        }
    }
}
