using System.Collections.Generic;
using System.Linq;

namespace testProject2.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;
        
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "abhi", Department = Dept.Application_Developer, Email = "abhi@gmail.com"},
                new Employee() {Id = 2, Name = "adi", Department = Dept.Application_Developer, Email = "adi@gmail.com"},
                new Employee() {Id = 3, Name = "appy", Department = Dept.Application_Developer, Email = "appy@gmail.com"},
            };
        }
        public Employee GetEmployee(int id)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == id);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(employee => employeeChanges.Id == employee.Id);

            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(employee => employee.Id == id);

            if (employee != null)
            {
                _employeeList.Remove(employee);   
            }
            
            return employee;
        }
    }
}