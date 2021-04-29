using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscountEvaluator.Interfaces;

namespace DiscountEvaluator.Handlers.Tests
{
    [TestClass()]
    public class HandlersStartTests
    {
        [TestMethod()]
        public void StartTest()
        {
            // Arrange
            IHandlerStartable handlersStarter = new HandlersStart();
            string shipmentStr = "2015-02-09 L LP";

            // Act
            var resultShipment = handlersStarter.Start(shipmentStr);

            // Assert
            Assert.AreEqual("09.02.2015 L LP 6,90 -", resultShipment.ToString());
        }
    }
}