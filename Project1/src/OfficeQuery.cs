using Project1.src.furnitureClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src
{
    //Training said to include these methods in office class but that breaks Single Responsibility Principle so I created a separate class
    public class OfficeQuery
    {
        private Office office;

        public OfficeQuery()
        {
            office = new Office();
        }

        public IEnumerable<Furniture> GetNumberOfItems(string typeOfFurniture)
        {
            var queryResults =
                from items in office.furnitureInOffice
                where items.GetType().Name == typeOfFurniture
                select items;

            Console.WriteLine(queryResults.Count() + " " + typeOfFurniture + "(s) found: \n");
            DisplayQuery(queryResults);

            return queryResults;
        }

        //Class can further be modified to add more queries like below
        //However the best choice design-wise is to allow this class to be inherited from and be extended that way
        //In which case the class constructor should take in a query in string format and construct a LINQ query that way 
        //This would keep signatures the same rather than have different query methods to fufill Liskov Substitution Principle
        public IEnumerable<Furniture> QueryByColor(string color)
        {
            var queryResults =
                from items in office.furnitureInOffice
                where items.Color == color
                select items;

            Console.WriteLine(queryResults.Count() + " items found: \n");
            DisplayQuery(queryResults);

            return queryResults;
        }

        public void SetOffice(Office office)
         {
            this.office = office;
         }

        private void DisplayQuery(IEnumerable<Furniture> queryResults)
        {
            foreach(Furniture item in queryResults)
            {
                item.Write(Console.Out);
                Console.WriteLine();
            }
        }
        
    }
}
