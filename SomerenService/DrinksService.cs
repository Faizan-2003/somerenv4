using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinksService
    {
        // creating field drinksdb form class DrinksDao
        private DrinksDao drinksdb;

        public DrinksService()
        {
            drinksdb = new DrinksDao();
        }
        public List<Drinks> GetDrinks()
        {
            // getting drinks data from the database
            List<Drinks> drinks = drinksdb.GetAllDrinks();
            return drinks;
        }

        public string GetTotalSales(string drinkName)
        {
            return drinksdb.GetSales(drinkName);
        }
    }
}