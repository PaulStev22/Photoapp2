using System;
using System.Collections.Generic;
using System.Text;

namespace Photoapp2
{
    public class Store
    {
        public List<Photo> PhotoList { get; set; }
        public List<Photo> ShoppingList { get; set; }

        public Store()
        {
            PhotoList = new List<Photo>();
            ShoppingList = new List<Photo>();
        }

        public decimal checkout()
        {
            decimal totalCost = 0.00M;

            foreach (var c in ShoppingList)
            {
                totalCost = totalCost + c.Price;
            }
            ShoppingList.Clear();
            return totalCost;


        }
    }
}
