using SmartRefrigerator;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class NotifyByMessageTest
    {
        [TestMethod]
        public void GetLogWhenNoValueIsSetTest()
        {
            var notifyByMessage = new NotifyByMessage();
            notifyByMessage.Send("");
            //Assert.AreEqual("", notifyByMessage.GetLog());
        }

        [TestMethod]
        public void GetLogWhenValueIsSetTest()
        {
            var notifyByMessage = new NotifyByMessage();
            notifyByMessage.Send("Order Placed");
            //Assert.AreEqual("Order Placed", notifyByMessage.GetLog());
        }
    }

    [TestClass]
    public class PlaceOrderTest
    {
        [TestMethod]
        public void PlaceOrderOfInsufficientVegetablesTest()
        {
            var vegetableTray = new VegetableTray();
            var inMemoryStorage = new InMemoryStorage();
            var configurationManager = new ConfigurationManager(inMemoryStorage);
            
            Tomato tomato = new Tomato();
            Cabbage cabbage = new Cabbage();

            configurationManager.SetMinimumQuantity(tomato, 3);
            configurationManager.SetMinimumQuantity(cabbage, 1);

            vegetableTray.Add(tomato, 1);
            vegetableTray.Add(cabbage, 3);

            var placeOrder = new PlaceOrder(vegetableTray, configurationManager);
            var placedOrderList =  new Dictionary<Vegetable, int>();

            placedOrderList.Add(tomato, 2);

            Assert.AreEqual(placedOrderList.Count, placeOrder.PlaceOrderOfInsufficientVegetables().Count);
            
        }
    }
}
