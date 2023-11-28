﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorDesignPattern
{
    //ADAPTEE CLASS
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach(Employee employee in listEmployee) 
            {
                Console.WriteLine("Rs."+employee.Salary+"Salary Credited to"+employee.Name);
            }
        }
    }
}
