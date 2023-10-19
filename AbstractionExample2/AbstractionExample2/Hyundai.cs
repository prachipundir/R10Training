using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample2
{
    internal class Hyundai:Cars
    {
        public override string CheckColor()
        {
            return "Hyundai Having Brown Color!";
        }
       


        public string CheckDiscount()
        {
            return " having 20% off ";
        }

        public override string CheckPrice()
        {
            return "Hyundai is for less than 8Lakhs";
        }

        public override string CheckSeat()
        {
            return "7 Seater";
        }
    }
}
