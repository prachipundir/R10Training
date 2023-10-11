using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
