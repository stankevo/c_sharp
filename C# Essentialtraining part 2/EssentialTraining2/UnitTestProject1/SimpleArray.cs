using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class SimpleArray
    {
        public string[] GroceryList;

        public SimpleArray()
        {
            GroceryList = new string[4] { "Milk", "Bread", "Eggs", "Cheese" };

        public override string ToString()
        {
            return "The grocery list contains " + GroceryList.Length + " items: " + GroceryList.ToString();
        }
    }
    }
}
