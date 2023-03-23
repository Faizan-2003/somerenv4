using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

public class RevenueService
{
    // creating field revenuedb form class RevenueDao
    private RevenueDAO revenuedb;

    public RevenueService()
    {
        // new RevenueDAO from RevenueDAO revenuedb
        revenuedb = new RevenueDAO();
    }

    public List<Revenue> GetRevenues(DateTime selectedDate)
    {
        // getting revenue data from the database
        List<Revenue> revenues = revenuedb.GetAllRevenuesByDate(selectedDate);
        return revenues;
    }
}
