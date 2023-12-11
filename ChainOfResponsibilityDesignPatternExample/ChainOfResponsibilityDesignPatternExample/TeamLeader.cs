using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternExample
{
    class TeamLeader : EmployeeLeaveHandler
    {
        private readonly int MAX_LEAVE_CAN_APPROVE = 10;
        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            if(NumberOfDaysLeave<=MAX_LEAVE_CAN_APPROVE)
            {
                Console.WriteLine("Team Lead Approved the leave"+NumberOfDaysLeave);
            }
            else
            {
                Supervisor.ApplyLeave(EmployeeName, NumberOfDaysLeave);
            }
            
        }
    }
}
