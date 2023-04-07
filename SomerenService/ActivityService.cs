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

        // making a new method to introduce the AddActivity used in DAO to use it in UI 
        public void ActivityAdd(Activities activity)
        {
            // AddActivity method from the DAO
            activitydb.AddActivity(activity); 
        }

        // making a new method to introduce the DeleteActivity used in DAO to use it in UI 
        public void ActivityDelete(Activities activity)
        {
            // DeleteActivity method from the DAO
            activitydb.DeleteActivity(activity);
        }

        // making a new method to introduce the UpdateActivity used in DAO to use it in UI
        public void ActivityUpdate(Activities activity)
        {
            // UpdateActivity method from the DAO
            activitydb.UpdateActivity(activity);
        }
    }
}
