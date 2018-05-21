using Project1.src.furnitureClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src
{
    class OfficeQuery
    {
        private Office office;

        public OfficeQuery()
        {
            office = new Office();
        }

        public void QueryByColor(string color)
        {
           var queryResults =
                from items in office.furnitureInOffice
                where items.Color == color
                select items;

            Console.WriteLine(queryResults.Count() + " items found: ");

            DisplayQuery(queryResults);
        }
        public void DisplayQuery(IEnumerable<Furniture> queryResults)
        {
            foreach(Furniture item in queryResults)
            {
                item.Display(Console.Out);
                Console.WriteLine();
            }
        }
        public void SetOffice(Office office)
        {
            this.office = office;
        }
    }
}
