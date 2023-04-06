﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using System.Data.Common;
using System.Diagnostics;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activities> GetAllActivities()
        {
            // query showing what do we need to take from the database
            string query = "SELECT ActivityId, ActivityName, StartDateTime, EndDateTime FROM [ACTIVITIES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activities> ReadTables(DataTable dataTable)
        {
            //creating a list activities
            List<Activities> activities = new List<Activities>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activities activity = new Activities()
                {
                    // the content of the databse redirecrting to the variables given from the activities
                    activityId = (int)dr["ActivityId"],
                    activityName = dr["ActivityName"].ToString(),
                    startTime = (DateTime)dr["StartDateTime"],
                    endTime = (DateTime)dr["EndDateTime"],

                };
                //adding the items to the activity
                activities.Add(activity);
            }
            return activities;
        }
        public void AddActivity(Activities activity)
        {
            //try to perform the query
            try
            {
                // connect to the database
                conn.Open();
                // sql query to add data into database
                SqlCommand command = new SqlCommand("INSERT INTO ACTIVITIES (ActivityName, StartDateTime, EndDateTime)" +
                                                           "VALUES (@ActivityName, @StartDateTime, @EndDateTime)" +
                                                           "SELECT SCOPE_IDENTITY();",
                                                             conn);

                // adding the values in the database from the varibles...
                command.Parameters.AddWithValue("@ActivityName", activity.activityName);
                command.Parameters.AddWithValue("@StartDateTime", activity.startTime);
                command.Parameters.AddWithValue("@EndDateTime", activity.endTime);

                // execute the query...
                command.ExecuteNonQuery();
            }
            catch (Exception exp)
            {
                // throw exception if any error occurs
                throw new Exception("Adding Activity Failed!" + exp.Message);
            }
            finally
            {
                // disconnect
                conn.Close();
            }
        }
        public void UpdateActivity(Activities activity)
        {
            try
            {
                // connect to the database
                conn.Open();
                // sql query to update data in the database
                SqlCommand command = new SqlCommand(
            "UPDATE ACTIVITIES SET   ActivityName = @ActivityName, StartDateTime = @StartDateTime, EndDateTime = @EndDateTime" +
             " WHERE activityId = @ActivityId",
            conn);

                // adding the values in the database from the varibles
                command.Parameters.AddWithValue("@ActivityId", activity.activityId);
                command.Parameters.AddWithValue("@ActivityName", activity.activityName);
                command.Parameters.AddWithValue("@StartDateTime", activity.startTime);
                command.Parameters.AddWithValue("@EndDateTime", activity.endTime);

                // execute the query...
                int nrOfRowsAffected = command.ExecuteNonQuery();

                if (nrOfRowsAffected == 0)
                {
                    // throw exception if any no row affected
                    throw new Exception("No Records Affected!");
                }
            }

            catch (Exception exp)
            {
                // throw exception if any error occurs
                throw new Exception("Updating Activity Failed!" + exp.Message);
            }
            finally
            {
                // disconnect
                conn.Close();
            }
        }
        public void DeleteActivity(Activities activity)
        {
            try
            {
                // connect to the database
                conn.Open();
                // sql query to dekete data from database
                SqlCommand command = new SqlCommand(
                "DELETE FROM ACTIVITIES WHERE activityId = @ActivityId",
                conn);

                // adding the values in the database from the varibles
                command.Parameters.AddWithValue("@ActivityId", activity.activityId);

                // execute the query...
                int nrOfRowsAffected = command.ExecuteNonQuery();

                if (nrOfRowsAffected == 0)
                {
                    throw new Exception("No Records Affected!");
                }
            }
            catch (Exception exp)
            {
                // throw exception if any error occurs
                throw new Exception("Deleting Activity Failed!");
            }
            finally
            {
                // disconnect
                conn.Close();
            }
        }
    }
}
