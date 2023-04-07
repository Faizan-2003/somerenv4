using SomerenDAL;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

public class RevenueDAO : BaseDao
{
    public List<Revenue> GetAllRevenuesByDate(DateTime selectedDate)
    {
        string query = "SELECT [Cash Register].OrderID, Drinks.drinkName, Drinks.drinkType, Drinks.price, Drinks.stock, [Cash Register].dateTime FROM [Cash Register] INNER JOIN Drinks ON [Cash Register].drinkID = Drinks.drinkID WHERE CAST([Cash Register].dateTime AS DATE) = @SelectedDate ORDER BY Drinks.drinkName ASC";
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
                sales = (int)dr["OrderID"]
            };

            revenues.Add(revenue);
        }
        return revenues;
    }
}
