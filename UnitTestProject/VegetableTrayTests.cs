using System;
using SmartRefrigerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class VegetableTrayTests
    {
        VegetableTray tray = new VegetableTray();
        Tomato tomato = new Tomato();
        Cabbage cabbage = new Cabbage();                     

        [TestMethod]
        public void AddVegetableToEmptyTrayTest()
        {            
            tray.Add(cabbage, 2);
            tray.Add(tomato, 5);            
            Assert.AreEqual(2, tray.GetVegetableQuantity().Count);
        }

        [TestMethod]
        public void TakeOutVegetableFromTrayTest()
        {
            tray.Add(cabbage, 2);
            tray.Add(tomato, 5);
            tray.TakeOut(tomato, 2);
            Assert.AreEqual(2, tray.GetVegetableQuantity().Count);
        }

        [TestMethod]
        public void TakeOutVegetableFromTrayTestWithOneVegetableHavingZeroQuantity()
        {
            tray.Add(cabbage, 2);
            tray.Add(tomato, 5);
            tray.TakeOut(cabbage, 2);
            Assert.AreEqual(1, tray.GetVegetableQuantity().Count);
        }
    }
}
