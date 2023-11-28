using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MoneyBack : CreditCard
    {
        public string GetCardType()
        {
            return "MoneyBack";
        }
        public int GetCardLimit()
        {
            return 15000;
        }
        public int GetAnnualCharge()
        {
            return 500;
        }
    }
}
