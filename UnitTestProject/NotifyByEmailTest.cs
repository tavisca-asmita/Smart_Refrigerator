using SmartRefrigerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class NotifyByEmailTest
    {
        [TestMethod]
        public void GetLogWhenNoValueIsSetTest()
        {
            var notifyByEmail = new NotifyByEmail();
            Assert.AreEqual(true, notifyByEmail.Send("Order Placed"));
        }

        [TestMethod]
        public void GetLogWhenValueIsSetTest()
        {
            var notifyByEmail = new NotifyByEmail();            
            Assert.AreEqual(true, notifyByEmail.SendSubject("Insufficient Quantity"));
        }
    }
}
