using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class DieselCarDecorator: CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }
        public void AddEngine(ICar car)
        {
            if (car is BMWCar BMWCar)
            {
                BMWCar.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Deisel Engine to the Car : " + car);
            }
        }
    }
}
