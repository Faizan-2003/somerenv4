using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    internal class SupervisorsService
    {
        private SupervisorsDao supervisorsdb;

        public SupervisorsService()
        {
            supervisorsdb = new SupervisorsDao();
        }

        public List<Supervisors> GetSupervisors(Activity activity)
        {
            List<Supervisors> supervisors = supervisorsdb.GetSupervisor(activity);
            return supervisors;
        }

        public List<Supervisors> GetNotSupervisor(Activity activity)
        {
            List<Supervisors> supervisors = supervisorsdb.GetNotSupervisor(activity);
            return supervisors;
        }
    }
}
