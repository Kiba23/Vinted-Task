using DiscountEvaluator.Interfaces;
using DiscountEvaluator.Rules.Rules_Interfaces;
using System;

namespace DiscountEvaluator.Rules
{
    class DiscountExceed : IDiscountExceed
    {
        private readonly decimal _maxDiscount = 10M;
        private decimal DiscountApplied = 0;
        private int MonthExceeded = 0; // Assuming that input given in one-year period (12 month)

        public DiscountExceed() { }

        public DiscountExceed(decimal maxDiscount)
        {
            _maxDiscount = maxDiscount;
        }

        public void ApplyDiscount(IShipment shipment, decimal initialShipmentPrice)
        {
            var necessaryDiscount = initialShipmentPrice - shipment.Price // Calculating the difference
                ?? throw new ArgumentNullException("Price was null.");

            if (necessaryDiscount == 0M)
                return;

            shipment.Discount = necessaryDiscount;
            DiscountApplied += shipment.Discount ?? throw new ArgumentNullException("Discount was null.");

            // Check if discount exceeded the maximum disount price
            if (DiscountApplied + necessaryDiscount >= _maxDiscount && shipment.Date.Month != MonthExceeded)
            {
                CoverDiscountPartially(shipment, initialShipmentPrice);
                MonthExceeded = shipment.Date.Month;
            }
        }

        private void CoverDiscountPartially(IShipment shipment, decimal initialShipmentPrice)
        {
            var difference = _maxDiscount - DiscountApplied;

            shipment.Price = initialShipmentPrice - difference;
            shipment.Discount = difference;
        }
    }
}
