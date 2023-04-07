using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Supervisors
    {
        public int LecturerId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ActivityId { get; set; }
        public string activityName { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
