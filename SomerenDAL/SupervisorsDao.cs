using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class SupervisorsDao : BaseDao
    {
        public List<Supervisors> GetSupervisor(SomerenModel.Activity activity)
        {
            string query = "SELECT lecturerId, firstName, lastName FROM SUPERVISE WHERE activityId=@activityId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activityId", activity.activityId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Supervisors> GetNotSupervisor(SomerenModel.Activity activity)
        {
            string query = "SELECT lecturerId, firstName, lastName FROM LECTURER WHERE LecturerId not in  (SELECT lecturerId FROM SUPERVISE WHERE activityID = @activityId)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@activityID", activity.activityId);
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Supervisors> ReadTables(DataTable dataTable)
        {
            List<Supervisors> supervisors = new List<Supervisors>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisors activitySupervisor = new Supervisors();
                int number = (int)dr["teacher_number"];
                activitySupervisor.Supervisor = GetLecturer(number);
                supervisors.Add(activitySupervisor);
            }
            return supervisors;
        }

        private Lecturer GetLecturer(int lecturerId)
        {
            string query = "SELECT lecturerId, firstName ,lastName FROM Lecturer WHERE lecturerId=@lecturerId";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@lecturerId", lecturerId);
            return ReadTablesForLecurers(ExecuteSelectQuery(query, sqlParameters));
        }
        private Lecturer ReadTablesForLecurers(DataTable dataTable)
        {
            Lecturer lecturer = new Lecturer();
            foreach (DataRow dr in dataTable.Rows)
            {
                lecturer.lecturerId = (int)dr["lecturerId"];
                lecturer.firstName = (string)dr["firstName"];
                lecturer.lastName = (string)dr["lastName"];
            }
            return lecturer;
        }
    }
}
