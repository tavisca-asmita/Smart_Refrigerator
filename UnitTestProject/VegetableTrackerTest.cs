using SmartRefrigerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class VegetableTrackerTest
    {
        [TestMethod]
        public void GetInsufficientVegetableQuantityTest()
        {
            var inMemoryStorage = new InMemoryStorage();
            var config = new ConfigurationManager(inMemoryStorage);
            var vegetableTray = new VegetableTray();
            Tomato tomato = new Tomato();
            Cabbage cabbage = new Cabbage();

            config.SetMinimumQuantity(tomato, 3);
            config.SetMinimumQuantity(cabbage, 1);

            vegetableTray.Add(tomato, 5);
            vegetableTray.Add(cabbage, 3);
            
            vegetableTray.TakeOut(tomato, 3);

            VegetableTracker vegetableTracker = new VegetableTracker(vegetableTray, config);

            Assert.AreEqual(1, vegetableTracker.GetInsufficientVegetableQuantity().Count);
        }
    }
}
