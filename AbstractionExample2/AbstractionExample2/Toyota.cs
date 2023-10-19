using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample2
{
    internal class Toyota : Cars
    {
        public override string CheckColor()
        {
            return "Toyota is in blue color";
        }

        public override string CheckPrice()
        {
            return "Toyoya is for more than 12 lakhs!";
        }

        public override string CheckSeat()
        {
            return " 5 seater!";
        }
    }
}
