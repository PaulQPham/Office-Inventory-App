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
            this.color = color;
            this.height = height;
            this.wattage = wattage;
        }
        override public void Display(TextWriter textWriter)
        {
            textWriter.WriteLine("Lamp" + "\nColor: " + color + "\nHeight: " + height + " inches \nWattage: " + wattage + "w");
        }
    }
}
