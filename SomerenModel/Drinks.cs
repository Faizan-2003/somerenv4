using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drinks
    {
        public int drinkId { get; set; }     // Database Id of the drink
        public string drinkName { get; set; }   // Name of the drink
        public string drinkType { get; set; }    // Alcoholic or Non-Alcoholic
        public int price { get; set; }  // Price of the drink
        public int stock { get; set; }    // Stock of the drink
        public int VAT { get; set; }     // 21% VAT for alcoholic and 9% for non-alcoholic
    }
}
