using DiscountEvaluator.Handlers;
using DiscountEvaluator.Interfaces;
using System;
using System.IO;

namespace DiscountEvaluator
{
    public class EvaluatorMain
    {
        private readonly IHandlerStartable _handlerStart;

        public EvaluatorMain()
        {
            _handlerStart = new HandlersStart();
        }

        public EvaluatorMain(decimal maxDiscount) // In case to change the max amount of discounts
        {
            _handlerStart = new HandlersStart(maxDiscount);
        }

        public void RunEvaluator()
        {
            try
            {
                string line;

                using (var sr = new StreamReader("input.txt"))
                {
                    while (!String.IsNullOrWhiteSpace(line = sr.ReadLine()))
                    {
                        var shipment = _handlerStart.Start(line);

                        Output.ShipmentOutput(shipment);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
