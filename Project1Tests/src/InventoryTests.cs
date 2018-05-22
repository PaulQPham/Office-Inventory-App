using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1.src;
using Project1.src.furnitureClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.Tests
{
    [TestClass()]
    public class InventoryTests
    {
        Inventory inventory;
        Furniture testFurniture1, testFurniture2, testFurniture3;
        TextWriter testWriter;


        [TestInitialize()]
        public void Init()
        {
            inventory = new Inventory();
            testFurniture1 = new Chair("Blue", false, true);
            testFurniture2 = new Lamp("Silver", 20, 20);
            testFurniture3 = new Table("White", 200, 100, 100);
        }
        [TestMethod()]
        public void Canary()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void DisplayTestWithNoFurniture()
        {

        }

        [TestMethod()]
        public void DisplayTestWithOneItem()
        {

        }

        [TestMethod()]
        public void DisplayTestWithTwoOrMoreItems()
        {

        }
    }
}