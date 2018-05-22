using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.furnitureClasses
{
    public class Lamp : Furniture
    {
        private int height;
        private int wattage;

        public Lamp(string color, int height, int wattage) : base(color)
        {
            this.Color = color;
            this.height = height;
            this.wattage = wattage;
        }
        //coverage for this method is included in InventoryTests.cs
        override public void Write(TextWriter textWriter)
        {
            textWriter.WriteLine("Lamp \nColor: {0} \nHeight: {1} inches \nWattage: {2}w", Color, height, wattage);
        }
    }
}
