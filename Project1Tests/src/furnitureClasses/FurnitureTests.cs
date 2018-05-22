using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1.src.furnitureClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Tests.src.furnitureClasses.Tests
{
    [TestClass()]
    public abstract class FurnitureTests
    {
        protected Furniture testFurniture;
        protected TextWriter testWriter;
        protected string expectedString;

        [TestMethod()]
        public void Canary()
        {
            Assert.IsTrue(true);
        }

        [TestMethod()]
        public void WriteTest()
        {
            testFurniture.Write(testWriter);

            Assert.AreEqual(expectedString, testWriter.ToString());
        }



    }
}
