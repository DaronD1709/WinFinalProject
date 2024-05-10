using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager.Classes
{
    public class Item
    {
        public int ID_Items { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Item(int idItems, string name, decimal price)
        {
            ID_Items = idItems;
            Name = name;
            Price = price;
        }
    }
}
