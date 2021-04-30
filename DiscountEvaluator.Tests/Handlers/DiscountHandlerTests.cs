using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscountEvaluator.Interfaces;

namespace DiscountEvaluator.Handlers.Tests
{
    [TestClass()]
    public class DiscountHandlerTests
    {
        [TestMethod()]
        public void StartDiscountFunctionsTest()
        {
            // Arrange
            IDiscountHandler discountHandler = new DiscountHandler();
            IDiscountHandler discountHandlerSec = new DiscountHandler(10M);
            ShipmentHandler shipmentHandler = new ShipmentHandler();
            var shipment = shipmentHandler.CreateShipment("2015-02-01 S MR");
            var shipmentSec = shipmentHandler.CreateShipment("2015-02-01 S MR");

            // Act
            discountHandler.StartDiscountFunctions(shipment, 3M);
            discountHandlerSec.StartDiscountFunctions(shipmentSec, 3M);

            // Assert
            Assert.AreEqual(shipment.ToString(), shipmentSec.ToString());
        }
    }
}