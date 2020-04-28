using System.Collections.Generic;
using System.Threading.Tasks;


namespace ETMS.Data.Service
{
    public interface ICourseService
    {
        Task<Course> GetCourseInfo(string courseId);
        Task<List<Course>> GetCourses();
        Task<bool> CreateCourse(Course course);
        Task<bool> EditCourse(string id, Course course);
        Task<Course> SingleCourse(string id);
        Task<bool> DeleteCourse(string id);
    }
}
