using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ETMS.Data.Service;
using ETMS.Data;
using System.Linq;

namespace ETMS.Data.Service
{
    public class CourseService : ICourseService
    {
        private readonly ETMSContext _dbContext;
        private List<Employee> _employeeList;
        private List<Course> _courseList;
        private List<EmployeeCourse> _employeeCourseList;
        public CourseService(ETMSContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Course> GetCourseInfo(string courseId)
        {

            int _courseId = int.Parse(courseId);
            foreach (Course course in _courseList)
            {
                if (course.CourseID == _courseId)
                {
                    return course;
                }
            }

            return null;

        }
        public async Task<List<Course>> GetCourses()
        {
            List<Employee> employeeList;
            List<EmployeeCourse> employeeCourseList;
            List<Course> courseList;
            employeeCourseList = await _dbContext.EmployeeCourses.ToListAsync();
            employeeList = await _dbContext.Employees.ToListAsync();
            employeeList = employeeList.OrderBy(e => e.Name).ToList();
            courseList = await _dbContext.Courses.ToListAsync();
            courseList = courseList.OrderBy(c => c.Name).ToList();

            foreach (Course course in courseList)
                {
                if (course.EmployeeCourses != null && course.EmployeeCourses.Count == 0)
                {
                    foreach (EmployeeCourse employeecourse in employeeCourseList)
                    {
                        if (course.CourseID == employeecourse.CourseID)
                        {
                            foreach (Employee employee in employeeList)
                            {
                                if (employee.EmployeeID == employeecourse.EmployeeID)
                                {
                                    employeecourse.Employee = employee;
                                }
                            }

                            course.EmployeeCourses.Add(employeecourse);
                        }

                    }
                }

            }

            _courseList = courseList;
            return courseList;
        }
        public async Task<bool> CreateCourse(Course course)
        {
            course.RowId = Guid.NewGuid().ToString();
            _dbContext.Add(course);
            try
            {
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }

        }
        public async Task<Course> SingleCourse(string id)
        {
            int _id = int.Parse(id);
            return await _dbContext.Courses.FindAsync(_id);
        }
        public async Task<bool> EditCourse(string id, Course course)
        {
            int _id = int.Parse(id);
            if (_id != course.CourseID)
            {
                return false;
            }

            _dbContext.Entry(course).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteCourse(string id)
        {
            int _id = int.Parse(id);
            var patient = await _dbContext.Courses.FindAsync(_id);
            if (patient == null)
            {
                return false;
            }

            _dbContext.Courses.Remove(patient);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
