using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class DerivedClass: MyClass
    {
        public void AccessProtectedField()
        {
            ProtectedField = 10; // we are accessing the protected field from the Derived class
        }
    }
}
