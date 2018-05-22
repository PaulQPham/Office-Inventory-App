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
            testWriter = new StringWriter();
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
            inventory.Write(testWriter);

            Assert.AreEqual(String.Empty, testWriter.ToString());
        }

        [TestMethod()]
        public void DisplayTestWithOneItem()
        {
            inventory.currentInventory = new List<Furniture> { testFurniture1 };
            inventory.Write(testWriter);

            Assert.AreEqual("Chair \nColor: Blue \nPadded: False \nArms: True\n", testWriter.ToString());
        }

        [TestMethod()]
        public void DisplayTestWithTwoOrMoreItems()
        {
            inventory.currentInventory = new List<Furniture> { testFurniture1, testFurniture2, testFurniture3 };
            inventory.Write(testWriter);

            Assert.AreEqual("Chair \nColor: Blue \nPadded: False \nArms: True\nLamp \nColor: Silver \nHeight: 20 inches \nWattage: 20w\nTable\nColor: White\nLength: 200 inches\nWidth: 100 inches\nHeight: 100 inches\n", testWriter.ToString());
        }
    }
}