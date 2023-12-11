using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternExample
{
    class ProjectManager : EmployeeLeaveHandler
    {
        private readonly int MAX_LAEVE_CAN_APPROVE = 20;
        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            if(NumberOfDaysLeave<=MAX_LAEVE_CAN_APPROVE)
            {
                Console.WriteLine("PROJECT MANAGER APPROVED THE LEAVES!" + NumberOfDaysLeave);
            }
            else
            {
                Supervisor.ApplyLeave(EmployeeName, NumberOfDaysLeave);
            }
        }
    }
}
