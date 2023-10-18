using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle: ICalculateArea
    {
        public double _radius {  get; private set; }
        public Circle(double radius) 
        {
            SetRadius(radius);
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius,2);
        }

        public void SetRadius(double radius)
        {
            if(radius <= 0)
            {
                throw new ArgumentException("should be greater thn zero");
            }
            _radius = radius;
        }

    }
}
