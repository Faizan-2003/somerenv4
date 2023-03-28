using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class studentParticipationDAO : BaseDao
    {
        public List<studentParticipationModel> GetAllParticipaitingStudents()
        {
            string query = "Select PARTICIPATE.StudentId, ACTIVITIES.ActivityId, ActivityName, STUDENT.firstName, STUDENT.lastName\r\nfrom PARTICIPATE\r\njoin STUDENT on PARTICIPATE.[StudentId] = STUDENT.[StudentId]\r\njoin ACTIVITIES on ACTIVITIES.ActivityId = PARTICIPATE.[activityId]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<studentParticipationModel> ReadTables(DataTable dataTable)
        {
            List<studentParticipationModel> students = new List<studentParticipationModel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                studentParticipationModel student = new studentParticipationModel()
                {
                    StudentId = (int)dr["StudentId"],
                    ActivityId= (int)dr["ActivityId"],
                    ActivityName = dr["ActivityName"].ToString(),
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString()
                };
                students.Add(student);
            }
            return students;
        }
    }
}
