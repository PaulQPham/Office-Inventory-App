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
        static OfficeQuery officeQuery;
        public static void Main(string[] args)
        {
            office = new Office();
            inventory = new Inventory();
            officeQuery = new OfficeQuery();

            office.SetInventory(inventory);
            officeQuery.SetOffice(office);

            Chair chair1 = new Chair("Blue", false, true);
            Chair chair2 = new Chair("Brown", true, true);
            Lamp lamp1 = new Lamp("Silver", 20, 20);
            Table table1 = new Table("White", 200, 100, 100);
            Table table2 = new Table("Brown", 300, 100, 80);

            inventory.currentInventory.Add(chair1);
            inventory.currentInventory.Add(chair2);
            inventory.currentInventory.Add(lamp1);
            inventory.currentInventory.Add(table1);
            inventory.currentInventory.Add(table2);

            inventory.Display();

            Console.ReadLine();

            office.AddFromInventory(1);
            office.AddFromInventory(1);
            office.AddFromInventory(2);

            officeQuery.QueryByColor("Brown");

            Console.ReadLine();
        }



    }
}
