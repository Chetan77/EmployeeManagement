﻿using EmployeeModel.EmployeeModel;
using Repository.DBContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepoImpl : IRepo
    {
        private readonly UserDBContext userDBContext;

        public RepoImpl(UserDBContext userDBContext)
        {
            this.userDBContext = userDBContext;
        }
        public Task<int> RegisterEmployee(Employee employee)
        {
            userDBContext.Employees.Add(employee);
            var result = userDBContext.SaveChangesAsync();
            return result;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = userDBContext.Employees.Find(id);
            if (employee != null)
            {
                userDBContext.Employees.Remove(employee);
                userDBContext.SaveChanges();
            }
            return employee;

        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return userDBContext.Employees;
        }

        public Employee GetEmployee(int id)
        {
            return userDBContext.Employees.Find(id);
        }

        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            var employee = userDBContext.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            var result = userDBContext.SaveChangesAsync();
            return result;
        }
    }
}
