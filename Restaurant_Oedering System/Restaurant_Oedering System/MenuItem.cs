using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Oedering_System
{
    public abstract class MenuItem:IMenuItem
    {
        public string Name { get; }   
        public string Description { get; }
        public decimal Price { get; }

        protected MenuItem(string name, string description ,decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
    }
}
