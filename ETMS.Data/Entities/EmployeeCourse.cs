using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETMS.Data
{
    public class EmployeeCourse
    {
        public int EmployeeCourseID { get; set; }
        public int EmployeeID { get; set; }
        public int CourseID { get; set; }
        public bool isComplete { get; set; }

        public DateTime CompletedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime AssignedOn { get; set; }
        public Course Course { get; set; }
        public Employee Employee { get; set; }

       
    }
}

