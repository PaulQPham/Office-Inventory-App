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
        private string color;

        public Furniture(string color)
        {
            this.color = color;
        }

        internal string Color { get => color; set => color = value; }

        //Each child class must implement Display()
        public abstract void Write(TextWriter textWriter);     
    }
}
