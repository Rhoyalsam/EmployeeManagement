using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                    new Employee() { Id= 1, Name = "Mary", Department = "Hr", Email = "mary@wema.com"},
                    new Employee() { Id= 1, Name = "john", Department = "IT", Email = "john@wema.com"},
                    new Employee() { Id= 1, Name = "samy", Department = "IT", Email = "samy@wema.com"}
            };
        }
        public Employee GetEmployee(int Id)

        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
