using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPatternExample
{
    //dependent Object --Client class
    public class EmployeeBL
    {
        public IEmployeeDAl employeeDAL;
        public EmployeeBL(IEmployeeDAl employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }
        public List<Employee> GetAllEmployees()
        {
            //employeeDAL = new EmployeeDAL();
            return employeeDAL.SelectAllEmployees();
        }
    }
}
