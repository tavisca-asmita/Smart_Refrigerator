using SmartRefrigerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class ConfigurationManagerTest
    {
        [TestMethod]
        public void GetMinimumQuantityTest()
        {
            var inMemoryStorage = new InMemoryStorage();
            var config = new ConfigurationManager(inMemoryStorage);
            Tomato tomato = new Tomato();
            config.SetMinimumQuantity(tomato, 5);

            Assert.AreEqual(5, config.GetMinimumQuantity(tomato));
        }
    }
}
