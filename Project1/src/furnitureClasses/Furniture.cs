using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.furnitureClasses
{
    public abstract class Furniture
    {
        protected string color;

        public Furniture(string color)
        {
            this.color = color;
        }
        public abstract void Display(TextWriter textWriter);     
    }
}
