using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public List<Activities> GetActivities()
        {
            // getting activities data from the database
            List<Activities> activities = activitydb.GetAllActivities();
            return activities;
        }
        public void Add(Activities activity)
        {
            var activityinstance = new ActivityDao();
            activityinstance.AddActivity(activity);
        }
        public void Delete(Activities activity)
        {
            var activityinstance = new ActivityDao();
            activityinstance.DeleteActivity(activity);
        }
    }
}
