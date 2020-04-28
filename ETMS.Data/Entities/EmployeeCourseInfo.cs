using System;
using System.Collections.Generic;
using System.Text;

namespace ETMS.Data
{
    public class EmployeeCourseInfo : EmployeeCourse
    { 
        //public string EmployeeName { get; set; }
        //public string CouseName { get; set; }
        public int TotalEmployeeCompleted{ get; set; }

        public int TotalEmployeeNotStarted { get; set; }

        public int TotalCourseCompleted { get; set; }

        public int TotalCourseNotStarted { get; set; }

        public string PercentEmployeCompleted
        {
            get
            {
                double total = TotalEmployeeNotStarted + TotalEmployeeCompleted;
                double perEC =  TotalEmployeeCompleted/ total;
                return perEC.ToString("p");
            }
        }
        public string cellCSS
        {
            get
            {
                string cellCSS = "";
                if(TotalEmployeeCompleted == 0)
                {
                    cellCSS = "table-danger";
                }
                if (TotalEmployeeNotStarted == 0)
                {
                    cellCSS = "table-success";
                }
                if (TotalEmployeeNotStarted == 0 && TotalEmployeeCompleted == 0)
                {
                    cellCSS = "table-secondry";
                }

                return cellCSS;
            }
        }
        public string PercentCourcesCompleted
        {
            get
            {
                double total = TotalCourseCompleted + TotalCourseNotStarted;
                double perEC = TotalCourseCompleted / total;
                return perEC.ToString("p");
            }
        }



    }
}
