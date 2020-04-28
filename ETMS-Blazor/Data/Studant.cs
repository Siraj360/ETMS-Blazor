using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETMS_Blazor.Data
{
    public class Studant
    {
        public int StudentID { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
        public int CourseID { get; set; }
        public string Grade { get; set; }
    }
}
