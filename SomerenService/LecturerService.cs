using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class LecturerService
    {
        // creating field lecturerdb form class LecturerDao
        private LecturerDao lecturerdb;

        public LecturerService()
        {
            // new LecturerDao from LecturerDao lecturerdb
            lecturerdb = new LecturerDao();
        }
        public List<Lecturer> GetLecturers()
        {
            // getting lecturer data from the database
            List<Lecturer> lecturers = lecturerdb.GetAllLecturers();
            return lecturers;
        }

    }
}
