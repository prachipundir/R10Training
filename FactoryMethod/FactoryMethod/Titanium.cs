using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Titanium :CreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }
        public int GetCardLimit()
        {
            return 60000;
        }
        public int GetAnnualCharge()
        {
            return 300;
        }
    }
}
