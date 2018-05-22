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
    public class LampTests : FurnitureTests
    {
        [TestInitialize()]
        public void Init()
        {
            testWriter = new StringWriter();
            testFurniture = new Lamp("Silver", 20, 20);
            expectedString = "Lamp \nColor: Silver \nHeight: 20 inches \nWattage: 20w\n";
        }
    }
}