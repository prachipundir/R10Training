using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Rectangle:Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return Height * Width;
        }
        public override double CalculatePerimeter()
        {
           return 2*(Height+Width);
        }
    }
}
