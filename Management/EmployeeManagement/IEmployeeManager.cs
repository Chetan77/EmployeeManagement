using EmployeeModel.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public interface IEmployeeManager
    {
        Employee GetEmployee(int empId);
        IEnumerable<Employee> GetAllEmployees();
        Task<int> AddEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee changes);
        Employee DeleteEmployee(int empId);
    }
}
