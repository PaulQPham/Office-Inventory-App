using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.furnitureClasses
{
    public class Table : Furniture
    {
        private int length;
        private int width;
        private int height;

        public Table(string color, int length, int width, int height) : base(color)
        {
            this.Color = color;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        override public void Write(TextWriter textWriter)
        {
            textWriter.Write("Table\nColor: {0}\nLength: {1} inches\nWidth: {2} inches\nHeight: {3} inches\n", Color, length, width, height);
        }
    }
}
