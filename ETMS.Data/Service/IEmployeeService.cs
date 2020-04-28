using System.Collections.Generic;
using System.Threading.Tasks;


namespace ETMS.Data.Service
{
    public interface IEmployeeService
    {
        Task<Employee> GetEmployeeInfo(string employeeId);
        Task<List<Employee>> GetEmployees();
        Task<bool> CreateEmployee(Employee employee);
        Task<bool> EditEmployee(string id, Employee employee);
        Task<Employee> SingleEmployee(string id);
        Task<bool> DeleteEmployee(string id);
   
    }
}
