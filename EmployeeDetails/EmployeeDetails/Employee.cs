using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class Employee:IDisplayDetails
    {
        public string _Name { get; private set; }
        public int _Age { get; private set; }  
        public double _Salary {  get; private set; }

        public Employee(string name,int age,double salary) 
        {
            SetName(name);
            SetAge(age);
            SetSalary(salary);
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Showing Employee's details");
            Console.WriteLine($"Name:{_Name}");
            Console.WriteLine($"Age:{_Age}");
            Console.WriteLine($"Salary:{_Salary}");

        }
        private void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)) 
            {
                throw new ArgumentNullException("name should not be null or empty!");
            }
            _Name = name;
        }

        private void SetAge(int  age) 
        {
            if(age<=0) { throw new ArgumentOutOfRangeException("cannot be zero or negative"); }
            _Age = age;
        }
        private void SetSalary(double salary)
        {
            if (salary<=0) { throw new ArgumentException("cannot be negative or zero"); }
            _Salary = salary;
        }
    }
}
