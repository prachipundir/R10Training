using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class MySampleClass
    {
        //consrtuctors can be public and private
        public MySampleClass() 
        {
            Console.WriteLine("Constructor 1 called");
        }
        public MySampleClass(string name)
        {
            Console.WriteLine("Constrictor 2 called");
        }
        public MySampleClass(int id, string name)
        {
            Console.WriteLine("Constructor 3 called");
        }
        ~MySampleClass() 
        { 
            Console.WriteLine("Destroying the Object!");
        }
    }
}
