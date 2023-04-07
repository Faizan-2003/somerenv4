using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Security.Policy;

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

        public List<Drinks> ReadTables(DataTable dataTable)
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
                    drinkPrice = (int)dr["price"],
                    stock = (int)dr["stock"],
                    VAT = (int)dr["VAT"]
                };
                //adding the items to the drinks
                drinks.Add(drink);
            }
            return drinks;
        }

        public string GetSales(string drinkName)
        {
            SqlConnection cnn;
            SqlCommand cmd;


            string ConnectionString = "Data Source=group5databaseproject.database.windows.net; Initial Catalog=group5Database; User=group5; Password='PFYproject5'";
            string sql ="SELECT SUM(sales) FROM[Cash Register] WHERE drinkName = '" +drinkName+"'";


            cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            string value = cmd.ExecuteScalar().ToString();
            cmd.Dispose();
            cnn.Close();


            return value;
        }
        
    }
}
