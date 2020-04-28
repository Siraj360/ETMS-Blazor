using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETMS.Data
{
    public class Course
    {
        [MaxLength(50)]
        public string RowId { get; set; }
        public int CourseID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Code { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public List<EmployeeCourse> EmployeeCourses { get; set; }

        public int TotalCoursesAssined
        {
            get
            {
                return EmployeeCourses.Count;
            }
        }

        public string PercentCourcesCompleted
        {
            get
            {
                double per = TotalCoursesCompleted * 100/ TotalCoursesAssined;
                return (per/100).ToString("p");
            }
        }
        public int TotalCoursesCompleted
        {
            get
            {
                return EmployeeCourses.Where(e => e.isComplete == true).ToList().Count;
            }
        }


    }
}
