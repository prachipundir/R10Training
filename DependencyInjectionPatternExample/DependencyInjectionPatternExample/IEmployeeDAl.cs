using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPatternExample
{
    public interface IEmployeeDAl
    {
        public List<Employee> SelectAllEmployees();
    }
}
