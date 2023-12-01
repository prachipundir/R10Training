using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public abstract class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            //Store that existing car object in the car variable
            this.car = car;
        }
        public virtual ICar ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }
}
