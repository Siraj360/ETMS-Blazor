using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ETMS.Data.Service;
using ETMS.Data;
using System.Linq; 


namespace ETMS.Data.Service
{
    public class EmployeeCourseService : IEmployeeCourseService
    {

        private readonly ETMSContext _dbContext;
        private StatusInfo _status = new StatusInfo();
        private List<Employee> _employeeList;
        private List<EmployeeCourse> _employeeCourseList;
        private List<Course> _courseList;

        public EmployeeCourseService(ETMSContext dbContext)
        {
            _dbContext = dbContext;
        }


        public StatusInfo GetStatus()
        {
            return _status;
        }



        public async Task<List<EmployeeCourseInfo>> GetEmployeeCourses()
        {
            List<EmployeeCourseInfo> employeeCourseInfoList = new List<EmployeeCourseInfo>();
            List<Employee> employeeList;
            _courseList = await _dbContext.Courses.ToListAsync();
            _employeeCourseList = await _dbContext.EmployeeCourses.ToListAsync();
            _employeeList = await _dbContext.Employees.ToListAsync();
            List<EmployeeCourse> employeeCourseListCompleted;

            employeeList = await _dbContext.Employees.ToListAsync();

            foreach (Employee employee in employeeList)
            {
                if (employee.EmployeeCourses != null && employee.EmployeeCourses.Count == 0)
                {
                    foreach (EmployeeCourse employeecourse in _employeeCourseList)
                    {
                        if (employee.EmployeeID == employeecourse.EmployeeID)
                        {
                            foreach (Course course in _courseList)
                            {
                                if (course.CourseID == employeecourse.CourseID)
                                {
                                    employeecourse.Course = course;
                                }
                            }

                            employee.EmployeeCourses.Add(employeecourse);
                        }
                    }
                }

            }

            _employeeList = employeeList;

            int _employeeAllCompleted = 0;
            int _employeeAllPending = 0;

            foreach (EmployeeCourse employeecourse in _employeeCourseList)
            {
                EmployeeCourseInfo employeeCourseInfo = new EmployeeCourseInfo();
                employeeCourseInfo.CourseID = employeecourse.CourseID;
                employeeCourseInfo.EmployeeID = employeecourse.EmployeeID;
                employeeCourseInfo.EmployeeCourseID = employeecourse.EmployeeCourseID;
                employeeCourseInfo.isComplete = employeecourse.isComplete;
                employeeCourseInfo.CompletedOn = employeecourse.CompletedOn;
                employeeCourseInfo.AssignedOn = employeecourse.AssignedOn;
                employeeCourseInfo.UpdatedOn = employeecourse.UpdatedOn;

                foreach (Employee employee in _employeeList)
                {
                 
                    if (employee.EmployeeID == employeecourse.EmployeeID)
                    {
                        employeeCourseInfo.Employee = employee;
                        int _completed = 0;
                        int _notStarted = 0;

                        foreach (Course course in _courseList)
                        {
                            if (employee.EmployeeCourses != null)
                            {
                                foreach (EmployeeCourse eeCource in employee.EmployeeCourses)
                                {
                                    if (course.CourseID == eeCource.CourseID)
                                    {
                                        if (eeCource.isComplete)
                                        {
                                            _completed++;
                                        }
                                        else
                                        {
                                            _notStarted++;
                                        }
                                    }
                                }

                            }
                        }
                        employeeCourseInfo.TotalEmployeeCompleted = _completed;
                        employeeCourseInfo.TotalEmployeeNotStarted = _notStarted;
                        if (_completed == 0)
                        {
                            _employeeAllPending++;
                        }
                        if (_notStarted == 0)
                        {
                            _employeeAllCompleted++;
                        }
                    }
                  

                }

                foreach (Course course in _courseList)
                {
       
                    if (course.CourseID == employeecourse.CourseID)
                    {
                        employeeCourseInfo.Course = course;
                        int _completed = 0;
                        int _notStarted = 0;

                        foreach (Employee employee in _employeeList)
                        {
                            if (employee.EmployeeCourses != null)
                            {
                                foreach (EmployeeCourse eeCource in employee.EmployeeCourses)
                                {
                                    if (course.CourseID == eeCource.CourseID)
                                    {
                                        if (eeCource.isComplete)
                                        {
                                            _completed++;
                                        }
                                        else
                                        {
                                            _notStarted++;
                                        }
                                    }
                                }
                            }

                        }

                        employeeCourseInfo.TotalCourseCompleted = _completed;
                        employeeCourseInfo.TotalCourseNotStarted = _notStarted;
                    }

                }

                employeeCourseInfoList.Add(employeeCourseInfo);
            }


            employeeCourseListCompleted = _employeeCourseList.Where(item => item.isComplete).ToList();
            _status.EmployeeAllComplterd = _employeeAllCompleted/4;
            _status.EmployeeAllNotStarted = _employeeAllPending/4;
            _status.TotalCourses = _courseList.Count;
            _status.TotalEmployees = _employeeList.Count;
            _status.TotalEmployeeCourses = _employeeCourseList.Count;
            _status.EmployeeCoursesComplted = employeeCourseListCompleted.Count;
            ;
          
            List<EmployeeCourseInfo> _EICList = employeeCourseInfoList.OrderByDescending(item => item.UpdatedOn).ToList();

            return _EICList;
        }

        public async Task<bool> ChangeCompleteStatus(int id)
        {
            var employeeCourse = await _dbContext.EmployeeCourses.FindAsync(id);
            if (employeeCourse == null)
            {
                return false;
            }

            employeeCourse.UpdatedOn = DateTime.Now;
            employeeCourse.isComplete = !employeeCourse.isComplete;
            if (employeeCourse.isComplete)
            {
                employeeCourse.CompletedOn = DateTime.Now;
            }
            //else
            //{
            //    employeeCourse.CompletedOn = null;
            //}

            _dbContext.Entry(employeeCourse).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return true;
        }


        public async Task<bool> CreateEmployeeCource(EmployeeCourse employeecource)
        {
           // employeecource.RowId = Guid.NewGuid().ToString();
            _dbContext.Add(employeecource);
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

        public Task<bool> CreateEmployeeCourse(EmployeeCourse employeecourse)
        {
            throw new NotImplementedException();
        }

        
    }
}
