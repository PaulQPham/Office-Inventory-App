using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.furnitureClasses
{
    public class Chair : Furniture
    {
        private bool isPadded;
        private bool hasArms;

        public Chair(string color, bool isPadded, bool hasArms) : base(color)
        {
            this.color = color;
            this.isPadded = isPadded;
            this.hasArms = hasArms;
        }
        override public void Display(TextWriter textWriter)
        {
            textWriter.WriteLine("Chair" + "\nColor: " + color + "\nPadded: " + isPadded + "\nArms: " + hasArms);
        }
    }
}
