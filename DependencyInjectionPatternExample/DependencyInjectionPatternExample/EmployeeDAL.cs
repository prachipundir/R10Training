using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPatternExample
{
    //dependency Object --Service Class
    public class EmployeeDAL:IEmployeeDAl
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
                // suppose here we will be getting Eployees from db,
                // for learning I have hardcoded the values
                new Employee() { Id = 1, Name = "Manish", Department = "SCO" },
                new Employee() { Id = 2, Name = "Prachi", Department = "R10" },
                new Employee() { Id = 3, Name = "Sahil", Department = "Emerald" }
            };
            return ListEmployees;
        }
    }
}
