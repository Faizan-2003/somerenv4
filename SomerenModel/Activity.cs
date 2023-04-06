using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activities
    {
        public int activityId {  get; set; }      // acticity ID which is automatically given by the database
        public string activityName { get; set; }    // activity name as Yoga, football, etc...
        public DateTime startTime { get; set; }     // start date time of the activity   2023-04-06 12:00:00
        public DateTime endTime { get; set; }       // end date time of the activity     2023-04-06 14:00:00

    }
}
