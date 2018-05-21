using Project1.src.furnitureClasses;
using System;
using System.Collections.Generic;
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

        public void Display()
        {
            foreach (Furniture item in currentInventory)
            {
                item.Display(Console.Out);
                Console.WriteLine();
            }
        }
    }
}
