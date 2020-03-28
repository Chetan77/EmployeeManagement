using EmployeeModel.EmployeeModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DBContext
{
    public class UserDBContext: DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> dbContextOptions) : base (dbContextOptions)
        {
        }
        public DbSet<Employee> Employees
        {
            get; set;
        }
    }
}
