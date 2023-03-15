﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT StudentId, StudentNumber, firstName, lastName, telephone, class, roomId FROM STUDENT";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    StudentId = (int)dr["StudentId"],
                    StudentNumber = (int)dr["StudentNumber"],
                    FirstName = dr["firstName"].ToString(),
                    LastName = dr["lastName"].ToString(),
                    telephone = (int)dr["telephone"],
                    Class = dr["class"].ToString(),
                    RoomID = (int)dr["roomId"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}