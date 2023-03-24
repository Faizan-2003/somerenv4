using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int orderId { get; set; }  // order ID given automatically
        public string firstName { get; set; } // student first name
        public string lastName { get; set; } // student last name
        public string drinkName { get; set; }  // drink name
        public string drinkType { get; set; }   // drink type
        public int price { get; set; }   // price
        public int stock { get; set; }  // stock
        public DateTime DateTime { get; set; }  // date time
        public int sales { get; set; } // sales
    }
}
