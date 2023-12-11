using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternExample
{
    class HR : EmployeeLeaveHandler
    {
        private readonly int MAX_LEAVE_CAN_APPROVE = 30;
        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            if(NumberOfDaysLeave<=MAX_LEAVE_CAN_APPROVE)
            {
                Console.WriteLine("HR Approved the leaves!" + NumberOfDaysLeave);
            }
            else
            {
                Supervisor.ApplyLeave(EmployeeName, NumberOfDaysLeave);
            }
        }
    }
}
