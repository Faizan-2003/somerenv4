using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class ActivityService
    {
        // creating field activitydb form class ActivityDao
        private ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }
        public List<Activity> GetActivities()
        {
            // getting activities data from the database
            List<Activity> activities = activitydb.GetAllActivities();
            return activities;
        }
    }
}
