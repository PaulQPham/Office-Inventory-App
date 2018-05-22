using Project1.src.furnitureClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src
{
    public class Inventory
    {
        public List<Furniture> currentInventory;
        public Inventory()
        {
            currentInventory = new List<Furniture>();
        }

        public void Write(TextWriter textWriter)
        {
            foreach (Furniture item in currentInventory)
            {
                item.Write(textWriter);
                Console.WriteLine();
            }
        }
    }
}
