using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Rules.Rules_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountEvaluator.Rules
{
    public class DiscountExceed : IDiscountExceed
    {
        public void CheckDiscount(IShipment shipment, decimal maxDiscount)
        {
            //
        }
    }
}
