using EmployeeModel.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepo
    {
        Task<int> RegisterEmployee(Employee employee);

        Task<int> UpdateEmployee(Employee employee);

        IEnumerable<Employee> GetAllEmployees();

        Employee DeleteEmployee(int empId);
        Employee GetEmployee(int empId);
    }
}
