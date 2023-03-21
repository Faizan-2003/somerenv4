using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class DrinksDao : BaseDao
    {
        public List<Drinks> GetAllDrinks()
        {
            // Query showing what do we need to take from the database
            string query = "SELECT drinkId, drinkName, drinkType, price, stock, VAT FROM DRINKS ORDER BY drinkName ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drinks> ReadTables(DataTable dataTable)
        {
            // Creating a list for drinks
            List<Drinks> drinks = new List<Drinks>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drinks drink = new Drinks()
                {
                    // The content of the databse assigned to drinks variables
                    drinkId = (int)dr["drinkId"],
                    drinkName = dr["drinkName"].ToString(),
                    drinkType = dr["drinkType"].ToString(),
                    price = (int)dr["price"],
                    stock = (int)dr["stock"],
                    VAT = (int)dr["VAT"]
                };

                //adding the items to the drinks
                drinks.Add(drink);
            }
            return drinks;
        }
    }
}
