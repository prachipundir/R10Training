using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Platinum : CreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }
        public int GetCardLimit()
        {
            return 68000;
        }
        public int GetAnnualCharge()
        {
            return 100;
        }
    }
}
