using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Oedering_System
{
    public class DrinkItem:MenuItem
    {
        public DrinkItem(string name, string description,decimal price)
            : base(name, description, price) { }
    }
}
