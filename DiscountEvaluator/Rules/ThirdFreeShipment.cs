using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Models;
using DiscountEvaluator.Rules.Rules_Interfaces;
using System.Linq;

namespace DiscountEvaluator.Rules
{
    public class ThirdFreeShipment : IThirdFreeShipment
    {
        public void ApplyThirdRule(IShipment shipment)
        {
            if (shipment.Company == Companies.LP)
            {
                //
            }
        }
    }
}
