using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeModel.EmployeeModel
{
    public class Employee
    {
        private int empId;
        private string firstName;
        private string lastName;
        private string password;
        private string address;

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int EmpId { get => empId; set => empId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
    }
}
