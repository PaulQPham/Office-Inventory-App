using Project1.src.furnitureClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src.application
{
    //This class contains no logic and does not require unit tests
    //Should this become more than a console app any classes and methods added for UI should not contain any logic
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

            //Generate some furniture
            //UI can be made so that users can create furniture and since it would only call constructors no logic is involved
            Chair chair1 = new Chair("Blue", false, true);
            Chair chair2 = new Chair("Brown", true, true);
            Chair chair3 = new Chair("Black", false, false);
            Chair chair4 = new Chair("White", true, true);
            Lamp lamp1 = new Lamp("Silver", 20, 20);
            Table table1 = new Table("White", 200, 100, 100);
            Table table2 = new Table("Brown", 300, 100, 80);

            inventory.currentInventory.Add(chair1);
            inventory.currentInventory.Add(chair2);
            inventory.currentInventory.Add(chair3);
            inventory.currentInventory.Add(chair4);
            inventory.currentInventory.Add(lamp1);
            inventory.currentInventory.Add(table1);
            inventory.currentInventory.Add(table2);


            inventory.Write(Console.Out);

            Console.ReadLine();

            office.AddFromInventory(1); //chair2
            office.AddFromInventory(1); //chair3
            office.AddFromInventory(2); //lamp1
            office.AddFromInventory(1); //chair4
            office.AddFromInventory(2); //table 2

            officeQuery.GetNumberOfItems("Chair");

            Console.ReadLine();

            officeQuery.QueryByColor("Brown");

            Console.ReadLine();
        }



    }
}
