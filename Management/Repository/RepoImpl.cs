using EmployeeModel.EmployeeModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepoImpl : IRepo
    {
        public Employee DeleteEmployee(int empId)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int empId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<int> RegisterEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
