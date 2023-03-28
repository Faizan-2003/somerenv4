using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.IO;
using System.Security.Cryptography;
using System.Data.Common;

namespace SomerenDAL
{
    public class OrderDao : BaseDao
    {
        public void AddData(Order order)
        {
            string query = $"INSERT INTO [Cash Register] (orderId, firstName, lastName, drinkName, drinkType, price, stock, DateTime, sales) VALUES ('{order.firstName}', '{order.lastName}', '{order.drinkName}', '{order.drinkType}', '{order.price}', '{order.stock}', '{order.DateTime}', '{order.sales}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Order> GetAllOrders()
        {
            // selecting data from tables
            string query = "SELECT orderId, firstName, lastName, drinkName, drinkType, price, stock, DateTime, sales FROM [Cash Register]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    // all the required data
                    firstName = dr["firstName"].ToString(),
                    lastName = dr["lastName"].ToString(),
                    drinkName = dr["drinkName"].ToString(),
                    drinkType = dr["drinkType"].ToString(),
                    price = (int)dr["price"],
                    stock = (int)dr["stock"],
                };
                orders.Add(order);
            }
            return orders;
        }

   
      

    }
}
