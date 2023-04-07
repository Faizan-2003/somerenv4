using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class StudnetParticipationService
    {
        // creating field lecturerdb form class LecturerDao
        private studentParticipationDAO participationdb;

        public StudnetParticipationService()
        {
            // new LecturerDao from LecturerDao lecturerdb
            participationdb = new studentParticipationDAO();
        }
        public List<studentParticipationModel> GetStudnetParticipetns()
        {
            // getting lecturer data from the database
            List<studentParticipationModel> participents = participationdb.GetAllParticipaitingStudents();
            return participents;
        }

    }
}
