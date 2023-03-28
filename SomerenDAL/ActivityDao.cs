using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            // query showing what do we need to take from the database
            string query = "SELECT ActivityId, ActivityName, StartDateTime, EndDateTime FROM [ACTIVITIES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            //creating a list activities
            List<Activity> activities= new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
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
    }
}
