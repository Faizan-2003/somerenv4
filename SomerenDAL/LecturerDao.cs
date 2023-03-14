using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class LecturerDao : BaseDao
    {
        public List<Lecturer> GetAllLecturers()
        {
            string query = "SELECT LecturerId, firstName, lastName, telephone, age, roomId FROM LECTURER ORDER BY lastName ASC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> ReadTables(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    lecturerId = (int)dr["LecturerId"],
                    firstName = dr["firstName"].ToString(),
                    lastName= dr["lastName"].ToString(),
                    telephone = (int)dr["telephone"],
                    age = (int)dr["age"],
                    roomId = (int)dr["roomId"]
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}