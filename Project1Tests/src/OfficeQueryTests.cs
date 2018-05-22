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
    public class OfficeQueryTests
    {
        Office office;
        OfficeQuery query;
        Chair chair1, chair2, chair3, chair4;
        Table table1, table2;
        Lamp lamp1;

        [TestInitialize()]
        public void Init()
        {
            office = new Office();
            query = new OfficeQuery();
            query.SetOffice(office);
            chair1 = new Chair("Blue", false, true);
            chair2 = new Chair("Brown", true, true);
            chair3 = new Chair("Black", false, false);
            chair4 = new Chair("White", true, true);
            lamp1 = new Lamp("Silver", 20, 20);
            table1 = new Table("White", 200, 100, 100);
            table2 = new Table("Brown", 300, 100, 80);

        }
        [TestMethod()]
        public void Canary()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void SuccesfulGetNumberOfItemsTest()
        {
            office.furnitureInOffice = new List<Furniture> { chair2, chair3, chair4, table2 };

            Assert.AreEqual(3, query.GetNumberOfItems("Chair").Count());
        }

        [TestMethod()]
        public void GetNumberOfItemsTestWhenItemIsNotAFurnitureClass()
        {
            office.furnitureInOffice = new List<Furniture> { chair2, chair3, chair4, table2 };

            Assert.AreEqual(0, query.GetNumberOfItems("NotFurniture").Count());
        }

        [TestMethod()]
        public void QueryByColorTest()
        {
            office.furnitureInOffice = new List<Furniture> { chair2, chair3, chair4, table2 };
            IEnumerable<Furniture> expectedReturn = new List<Furniture> { chair2, table2 };
            var returnedFurniture = query.QueryByColor("Brown");

            Assert.IsTrue(returnedFurniture.SequenceEqual(expectedReturn));
        }
    }
}