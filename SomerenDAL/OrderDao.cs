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
        public List<Order> GetAllOrders()
        {
            // selecting data from tables
            string query = "SELECT firstName, lastName FROM [STUDENT] " +
                "SELECT drinkName, drinkType, price, stock  FROM [DRINKS]";
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
                    studentID = (int)dr["StudentId"],
                    drinkID = (int)dr["drinkId"],
                    OrderDateTime = DateTime.Parse(dr["dateTime"].ToString()),
                };
                orders.Add(order);
            }
            return orders;
        }
        public void DrinkOrder(Order order)
        {
            string query = $"INSERT INTO [Cash Register] (drinkId, StudentId) VALUES ('{order.drinkID}', '{order.studentID}')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
