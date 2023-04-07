using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int orderID { get; set; }  // order ID given automatically
        public int drinkID { get; set; }
        public int studentID { get; set; }
        public int price { get; set; }
        public DateTime OrderDateTime { get; set; }  // date time
        public int sales { get; set; } // sales
    }
}
