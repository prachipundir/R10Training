using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class TestInheritance
    {
        static void Main()
        {
            BabyDog dog = new BabyDog();
            dog.eat();
           // dog.bark();
            dog.weep();
            Dog dog2 = new Dog();   
            dog2.eat();
            dog2.bark();
        }
    }
}
