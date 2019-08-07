using SmartRefrigerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class NotifierTest
    {        
        [TestMethod]
        public void NotifyWhenValueIsSetTest()
        {
            var notifier = new Notifier();
            notifier.SetNotifierType("BySMS");
            Assert.AreEqual(true, notifier.Notify("Low Vegetable Count"));
        }
    }
}
