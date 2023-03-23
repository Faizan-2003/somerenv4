using SomerenDAL;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

public class RevenueDAO : BaseDao
{
    public List<Revenue> GetAllRevenuesByDate(DateTime selectedDate)
    {
        string query = "SELECT orderId, firstName, lastName, drinkName, drinkType, price, stock, dateTime, sales FROM [Cash Register] WHERE CAST(dateTime AS DATE) = @SelectedDate ORDER BY drinkName ASC";
        SqlParameter[] sqlParameters = new SqlParameter[]
        {
            new SqlParameter("@SelectedDate", SqlDbType.Date) { Value = selectedDate.Date }
        };
        return ReadTables(ExecuteSelectQuery(query, sqlParameters));
    }

    private List<Revenue> ReadTables(DataTable dataTable)
    {
        List<Revenue> revenues = new List<Revenue>();

        foreach (DataRow dr in dataTable.Rows)
        {
            Revenue revenue = new Revenue()
            {
                drinkName = dr["drinkName"].ToString(),
                drinkType = dr["drinkType"].ToString(),
                price = (int)dr["price"],
                stock = (int)dr["stock"],
                dateTime = (DateTime)dr["dateTime"],
                sales = (int)dr["sales"]
            };

            revenues.Add(revenue);
        }
        return revenues;
    }
}
