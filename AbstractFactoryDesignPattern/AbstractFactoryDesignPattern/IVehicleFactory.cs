﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    //Abstract Factory
    public interface IVehicleFactory
    {
        IBike CreateBike();// abstract Product 1
        ICar CreateCar();// abstract Product 2
    }
}
