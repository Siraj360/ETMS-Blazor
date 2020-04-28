using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using ETMS.Data;
using Microsoft.Extensions.DependencyInjection;

namespace ETMS.Data.Service
{
    public class EmployeeService : IEmployeeService 
    {
        private readonly ETMSContext _dbContext;

        private List<Employee> _employeeList;
        private List<Course> _courseList;
        private List<EmployeeCourse> _employeeCourseList;

        public EmployeeService(ETMSContext dbContext, IEmployeeCourseService employeeCourseService)
        {
            _dbContext = dbContext;
        }

        public async Task<Employee> GetEmployeeInfo(string employeeId)
        {
            int _employeeId = int.Parse(employeeId);
            foreach (Employee employee in _employeeList)
            {
                if(employee.EmployeeID == _employeeId)
                {
                    return employee;
                }
            }

            return null;
        }
        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee> employeeList;
            List<EmployeeCourse> employeeCourseList;
            List<Course> courseList;
            courseList = await _dbContext.Courses.ToListAsync();
            courseList = courseList.OrderBy(c => c.Name).ToList(); 
            employeeCourseList = await _dbContext.EmployeeCourses.ToListAsync();
            employeeList = await _dbContext.Employees.ToListAsync();
            employeeList = employeeList.OrderBy(e => e.Name).ToList(); 

            foreach (Employee employee in employeeList)
            {
                if (employee.EmployeeCourses != null && employee.EmployeeCourses.Count == 0)
                {
                    foreach (EmployeeCourse employeecourse in employeeCourseList)
                    {
                        if (employee.EmployeeID == employeecourse.EmployeeID)
                        {
                            foreach (Course course in courseList)
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

            return employeeList;
        }
        public async Task<bool> CreateEmployee(Employee employee)
        {
           // List<EmployeeCourse> employeeCourseList = new List<EmployeeCourse>();
            
            employee.RowId = Guid.NewGuid().ToString();
            _dbContext.Add(employee);

            try
            {
                await _dbContext.SaveChangesAsync();

                for (int i = 3; i < 8; i++)
                {
                    EmployeeCourse employeeCourse = new EmployeeCourse();
                    employeeCourse.EmployeeID = employee.EmployeeID;          
                    employeeCourse.isComplete = false;
                    employeeCourse.CourseID = i;
                    _dbContext.Add(employeeCourse);
                }

             
                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }

        }
        public async Task<Employee> SingleEmployee(string id)
        {
            return await _dbContext.Employees.FindAsync(int.Parse(id));
        }
        public async Task<bool> EditEmployee(string id, Employee employee)
        {
            int _id = int.Parse(id);
            if (_id != employee.EmployeeID)
            {
                return false;
            }

            _dbContext.Entry(employee).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteEmployee(string id)
        {
            int _id = int.Parse(id);
            var patient = await _dbContext.Employees.FindAsync(_id);
            if (patient == null)
            {
                return false;
            }

            _dbContext.Employees.Remove(patient);
            await _dbContext.SaveChangesAsync();
            return true;
        }

    }
}
