using EmployeeModel.EmployeeModel;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeManagerImpl : IEmployeeManager
    {
        private readonly IRepo repo;

        public EmployeeManagerImpl(IRepo repo)
        {
            this.repo = repo;
        }
        public Task<int> AddEmployee(Employee employee)
        {
            return this.repo.RegisterEmployee(employee);
        }

        public Employee DeleteEmployee(int empId)
        {
            return this.repo.DeleteEmployee(empId);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return this.repo.GetAllEmployees();
        }

        public Employee GetEmployee(int empId)
        {
            return this.repo.GetEmployee(empId);
        }

        public Task<int> UpdateEmployee(Employee changes)
        {
            return this.repo.UpdateEmployee(changes);
        }
    }
}
