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
    public class SupervisorsDao : BaseDao
    {
        public List<Supervisors> GetSupervisor(Supervisors activity)
        {
            string query = "SELECT SUPERVISE.LecturerId, LECTURER.firstName, LECTURER.lastName FROM SUPERVISE\r\nJOIN LECTURER ON SUPERVISE.LecturerId = LECTURER.LecturerId\r\nJOIN ACTIVITIES ON ACTIVITIES.ActivityId = SUPERVISE.ActivityId\r\nWHERE SUPERVISE.ActivityId=@ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ActivityId", activity.ActivityId);
            return ReadSupervisors(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Supervisors> GetNotSupervisor(Supervisors activity)
        {
            string query = "SELECT DISTINCT SUPERVISE.LecturerId, LECTURER.firstName, LECTURER.lastName FROM SUPERVISE\r\nJOIN LECTURER ON SUPERVISE.LecturerId = LECTURER.LecturerId\r\nJOIN ACTIVITIES ON ACTIVITIES.ActivityId = SUPERVISE.ActivityId\r\nWHERE SUPERVISE.LecturerId not in (SELECT SUPERVISE.LecturerId FROM SUPERVISE WHERE ActivityID =@ActivityId)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ActivityId", activity.ActivityId);
            return ReadSupervisors(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Supervisors> ReadSupervisors(DataTable dataTable)
        {
            List<Supervisors> supervisors = new List<Supervisors>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisors supervisor = new Supervisors()
                {
                    LecturerId = (int)dr["LecturerId"],
                    firstName = dr["firstName"].ToString(),
                    lastName = dr["lastName"].ToString(),
                };

                supervisors.Add(supervisor);
            }
            return supervisors;
        }

        public List<Supervisors> GetSupervisedActivities()
        {
            string query = "SELECT ActivityId, ActivityName, StartDateTime, EndDateTime FROM [ACTIVITIES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadActivities(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Supervisors> ReadActivities(DataTable dataTable)
        {
            List<Supervisors> activities = new List<Supervisors>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisors activity = new Supervisors()
                {
                    ActivityId = (int)dr["ActivityId"],
                    activityName = dr["ActivityName"].ToString(),
                    startTime = (DateTime)dr["StartDateTime"],
                    endTime = (DateTime)dr["EndDateTime"],
                };
                activities.Add(activity);
            }
            return activities;
        }

        public void AddSupervisor(Supervisors activity)
        {
            string query = "INSERT INTO SUPERVISE(LecturerId,ActivityId) VALUES (@LecturerId, @ActivityId)";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@LecturerId", activity.LecturerId);
            sqlParameters[1] = new SqlParameter("@ActivityId", activity.ActivityId);
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveSupervisor(Supervisors supervisors)
        {
            string query = "DELETE FROM SUPERVISE WHERE LecturerId=@LecturerId AND ActivityId=@ActivityId";
            // preventing sql injections 
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@LecturerId", supervisors.LecturerId);
            sqlParameters[1] = new SqlParameter("@ActivityId", supervisors.ActivityId);
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
