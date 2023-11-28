using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    //CONCRETE PRODUCT
    public class SportsBike: IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Sprts bike Details...");
        }
    }
}
