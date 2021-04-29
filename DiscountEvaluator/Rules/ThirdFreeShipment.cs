using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Rules.Rules_Interfaces;

namespace DiscountEvaluator.Rules
{
    public class ThirdFreeShipment : IThirdFreeShipment
    {
        private int SpecificShipmentCounter = 0;
        private int MonthExceeded = 0; // Assuming that input given in one-year period (12 month)

        public void ApplyThirdRule(IShipment shipment)
        {
            if (shipment.Size == Sizes.L && shipment.Company == Companies.LP)
            {
                SpecificShipmentCounter++;
                if (SpecificShipmentCounter == 3 && shipment.Date.Month != MonthExceeded)
                {
                    shipment.Price = 0M;
                    // Flags and counters assigning here
                    SpecificShipmentCounter = 0;
                    MonthExceeded = shipment.Date.Month;
                }
            }
        }
    }
}
