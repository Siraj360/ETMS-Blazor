using System.Collections.Generic;
using System.Threading.Tasks;


namespace ETMS.Data.Service
{
    public interface IEmployeeCourseService
    {

        StatusInfo GetStatus();
        Task<bool> ChangeCompleteStatus(int id);
        Task<List<EmployeeCourseInfo>> GetEmployeeCourses();
        Task<bool> CreateEmployeeCourse(EmployeeCourse employeecourse);

    }
}
