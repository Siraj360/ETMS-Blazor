using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ETMS.Data
{
    public class Employee
    {
        [MaxLength(50)]
        public string RowId { get; set; }
        public int EmployeeID { get; set; }
        public DateTime HireDate { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
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
                double per = TotalCoursesCompleted * 100 / TotalCoursesAssined;
                return (per/100).ToString("p");
            }
        }
        public int TotalCoursesCompleted
        {
            get
            {
                return EmployeeCourses.Where(e => e.isComplete==true).ToList().Count;
            }
        }


        public string cssStyle
        {
            get
            {
                string cssStyle = "";
                if (TotalCoursesCompleted == 0)
                {
                    cssStyle = "danger";
                }
                if (TotalCoursesAssined == TotalCoursesCompleted)
                {
                    cssStyle = "success";
                }
                if (TotalCoursesAssined == 0)
                {
                    cssStyle = "warning";
                }

                return cssStyle;
            }
        }
    }
}
