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
        private Lamp lamp;
        private TextWriter textWriter;

        [TestInitialize()]
        public void Init()
        {
            lamp = new Lamp("Silver", 20, 20);
            textWriter = Console.Out;
        }

        [TestMethod()]
        public void DisplayTest()
        {
            
        }
    }
}