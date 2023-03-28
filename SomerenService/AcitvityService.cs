using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class AcitvityService
    {
        // creating field drinksdb form class DrinksDao
        private ActivityDao activitydb;

        public AcitvityService()
        {
            activitydb = new ActivityDao();
        }
        public List<Activity> GetActivities()
        {
            // getting drinks data from the database
            List<Activity> activities = activitydb.GetAllActivities();
            return activities;
        }

    }
}
