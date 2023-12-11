using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class DebitCardInsertedState : IATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("Debit Card Ejected!");
        }

        public void EnterPin()
        {
            Console.WriteLine("Enter you PIN!");
            
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("Debit card is already Inserted!");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("Enter the Amout you want to Withdraw!");
            
        }
    }
}
