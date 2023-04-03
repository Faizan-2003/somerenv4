using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activities
    {
        public int activityId {  get; set; }    
        public string activityName { get; set; }
        public DateTime startTime { get; set; } 
        public DateTime endTime { get; set; }   
    }
}
