using Project1.src.furnitureClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.application
{
    class InventoryApp
    {
        static Inventory inventory;
        static Office office;
        public static void Main(string[] args)
        {
            office = new Office();
            inventory = new Inventory();
            office.SetInventory(inventory);

            Chair chair = new Chair("Blue", false, true);
            Lamp lamp = new Lamp("Silver", 20, 20);
            Table table = new Table("White", 200, 100, 100);

            inventory.currentInventory.Add(chair);
            inventory.currentInventory.Add(lamp);
            inventory.currentInventory.Add(table);

            inventory.Display();

            Console.ReadLine();
        }



    }
}
