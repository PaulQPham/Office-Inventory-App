using Project1.src.furnitureClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.src
{
    public class Office
    {
        public List<Furniture> furnitureInOffice;
        private Inventory inventory;
        
        public Office()
        {
            furnitureInOffice = new List<Furniture>();
        }
        public void AddFromInventory(int idOfFurnitureInInventory)
        {
            furnitureInOffice.Add(inventory.currentInventory[idOfFurnitureInInventory]);
            inventory.currentInventory.RemoveAt(idOfFurnitureInInventory);
        }
        public void MoveToInventory(int idOfFurnitureInOffice)
        {
            Furniture furnitureToBeMoved = furnitureInOffice[idOfFurnitureInOffice];
            furnitureInOffice.RemoveAt(idOfFurnitureInOffice);
            inventory.currentInventory.Add(furnitureToBeMoved);
        }
        public void SetInventory(Inventory inventory)
        {
            this.inventory = inventory;
        }
    }
}
