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
    public class studentParticipationDAO : BaseDao
    {
        public List<studentParticipationModel> GetAllParticipaitingStudents()
        {
            string query = "SELECT PARTICIPATE.StudentId, ACTIVITIES.ActivityId, ACTIVITIES.ActivityName, STUDENT.firstName, STUDENT.lastName\r\nFROM PARTICIPATE\r\nJOIN STUDENT ON PARTICIPATE.StudentId = STUDENT.StudentId\r\nJOIN ACTIVITIES ON ACTIVITIES.ActivityId = PARTICIPATE.ActivityId";
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
                    ActivityId = (int)dr["ActivityId"],
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
