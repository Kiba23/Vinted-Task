using DiscountEvaluator.Models;
using System;

namespace DiscountEvaluator
{
    public static class Output
    {
        public static void ShipmentOutput(Shipment shipment)
        {
            Console.WriteLine(shipment + "\n");
        }

        public static void EndProgram()
        {
            Console.ReadLine();
        }
    }
}
