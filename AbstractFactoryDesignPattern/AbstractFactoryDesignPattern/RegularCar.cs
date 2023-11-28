using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class RegularCar: ICar
    {
        //CONCRETE PRODUCT
        public void GetDetails()
        {
            Console.WriteLine("Fetching Regular Car  details......");
        }
    }
}
