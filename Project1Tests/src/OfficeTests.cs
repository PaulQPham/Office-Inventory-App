using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1.src;
using Project1.src.furnitureClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.Tests
{
    [TestClass()]
    public class OfficeTests
    {
        Office office;
        Inventory inventory;
        Furniture testFurniture1, testFurniture2, testFurniture3;


        [TestInitialize()]
        public void Init()
        {
            office = new Office();
            inventory = new Inventory();
            office.SetInventory(inventory);
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
        public void SuccessfulAddFurnitureToOffice()
        {
            inventory.currentInventory.Add(testFurniture1);
            office.AddFromInventory(0);

            Assert.AreEqual(testFurniture1, office.furnitureInOffice[0]);
        }
        [TestMethod()]
        public void AddFurnitureToOfficeRemovesFromInventory()
        {
            inventory.currentInventory = new List<Furniture> { testFurniture1, testFurniture2 };
            office.AddFromInventory(0);

            Assert.IsFalse(inventory.currentInventory.Remove(testFurniture1));
        }
        [TestMethod()]
        public void SuccessfulRemoveFurnitureFromOffice()
        {
            office.furnitureInOffice = new List<Furniture> { testFurniture1, testFurniture2, testFurniture3 };
            office.MoveToInventory(0);

            Assert.IsFalse(office.furnitureInOffice.Remove(testFurniture1));
        }
        [TestMethod]
        public void MoveToInventoryAddsToInventory()
        {
            office.furnitureInOffice = new List<Furniture> { testFurniture1, testFurniture2, testFurniture3 };
            var expectedList = new List<Furniture> { testFurniture2 };
            office.MoveToInventory(1);

            CollectionAssert.AreEqual(expectedList, inventory.currentInventory);
        }
        [TestMethod()]
        public void MoveToInventoryShouldRemoveOnlyOneItemFromOffice()
        {
            office.furnitureInOffice = new List<Furniture> { testFurniture1, testFurniture2, testFurniture3 };
            var expectedList = new List<Furniture> { testFurniture1, testFurniture3 };
            office.MoveToInventory(1);

            CollectionAssert.AreEqual(expectedList, office.furnitureInOffice);
        }
    }
}