using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiscountEvaluator.Interfaces;
using System.Threading;
using System.Globalization;

namespace DiscountEvaluator.Handlers.Tests
{
    [TestClass()]
    public class HandlersStartTests
    {
        [TestMethod()]
        public void StartTest()
        {
            // Setting up dots instead of commas in numeric values
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            // Arrange
            IHandlerStartable handlersStarter = new HandlersStart();
            string shipmentStr = "2015-02-09 L LP";
            IHandlerStartable handlerStartableSec = new HandlersStart();
            string shipmentStrSec = "2015-03-09 L LP";

            // Act
            var resultShipment = handlersStarter.Start(shipmentStr);
            var resultShipmentSec = handlerStartableSec.Start(shipmentStrSec);

            // Assert
            Assert.AreEqual("2015-02-09 L LP 6.90 -", resultShipment.ToString());
            Assert.AreEqual(resultShipment.Price, resultShipmentSec.Price);
            Assert.AreEqual(resultShipment.Discount, resultShipmentSec.Discount);
        }
    }
}