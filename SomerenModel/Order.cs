using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int orderId { get; set; }  
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string drinkName { get; set; }  
        public string drinkType { get; set; }   
        public int price { get; set; }   
        public int stock { get; set; }  
        public DateTime DateTime { get; set; }
        public int sales { get; set; } 
    }
}
