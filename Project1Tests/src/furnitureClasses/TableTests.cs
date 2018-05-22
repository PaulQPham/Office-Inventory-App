using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1.src.furnitureClasses;
using Project1Tests.src.furnitureClasses.Tests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.furnitureClasses.Tests
{
    [TestClass()]
    public class TableTests : FurnitureTests
    {
        [TestInitialize()]
        public void Init()
        {
            testWriter = new StringWriter();
            testFurniture = new Table("White", 200, 100, 100);
            expectedString = "Table\nColor: White\nLength: 200 inches\nWidth: 100 inches\nHeight: 100 inches\n";
        }
    }
}