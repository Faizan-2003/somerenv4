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
            // Query showing what do we need to take from the database
            string query = "SELECT LecturerId, firstName, lastName, telephone, age, roomId, isSupervisor FROM LECTURER";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> ReadTables(DataTable dataTable)
        {
            // Creating a list for lecturers
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    // The content of the databse assigned to lecturer variables
                    lecturerId = (int)dr["LecturerId"],
                    firstName = dr["firstName"].ToString(),
                    lastName= dr["lastName"].ToString(),
                    telephone = (int)dr["telephone"],
                    age = (int)dr["age"],
                    roomId = (int)dr["roomId"],
                    isSupervisor = (bool)dr["isSupervisor"]
                };

                //adding the items to the lecturer
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}