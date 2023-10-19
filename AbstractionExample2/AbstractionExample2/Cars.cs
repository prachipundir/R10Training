using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample2
{
    public abstract class Cars
    {
        public abstract string CheckPrice();
        public abstract string CheckSeat();
        public abstract string CheckColor();

        public string CheckWheels()
        {
            return "having 4 wheels";
        }
        public string CheckAc()
        {
            return "Having AC!";
        }
        public string CheckcallFunction()
        {
            return "Having call function";
        }
    }
}
