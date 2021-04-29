using DiscountEvaluator.Interfaces;
using System;

namespace DiscountEvaluator
{
    public static class Output
    {
        public static void ShipmentOutput(IShipment shipment)
        {
            Console.WriteLine(shipment);
        }

        public static void EndProgram()
        {
            Console.ReadLine();
        }
    }
}
