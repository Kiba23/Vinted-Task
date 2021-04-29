using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Rules;
using DiscountEvaluator.Rules.Rules_Interfaces;

namespace DiscountEvaluator.Handlers
{
    class DiscountHandler : IDiscountHandler
    {
        private readonly IDiscountExceed _discountExceed;

        public DiscountHandler()
        {
            _discountExceed = new DiscountExceed();
        }

        public DiscountHandler(decimal maxDiscount)
        {
            _discountExceed = new DiscountExceed(maxDiscount);
        }

        public void StartDiscountFunctions(IShipment shipment, decimal initialShipmentPrice)
        {
            _discountExceed.ApplyDiscount(shipment, initialShipmentPrice);
        }
    }
}
