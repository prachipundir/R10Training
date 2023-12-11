using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesignPattern
{
    public class DebitCardNotInsertedState : IATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot Eject Debit card, as ther is no Debit card in the ATM Machine!");
        }

        public void EnterPin()
        {
            Console.WriteLine("You Can not enter PIN  as there is no card in the machine!");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("Debit Card Inserted!");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("You cannot Withdraw cash as ther is no ATM card inserted!");
        }
    }
}
