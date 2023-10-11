using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class MyClass
    {
        public int PublicField;         //Accessible from Anywhere
        private int PrivateField;       //Accessible within the class only
        protected int ProtectedField;   //Accessible within the class as well as within the derived Class
        internal int InternalField;     //Accessbile within thesame assembly
        protected internal int ProtectedInternalField; // within the same assembly and by derived classes within the assembly

        public void PublicMethod()
        {
            Console.WriteLine("Public method is accessible from  anywhere");
        }
        private void PrivateMethod() 
        {
            Console.WriteLine("Private method is Accessbile only within the class");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected methid is accessible from within the class as well as  from derived class");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("Internal method is Accessbile only within the same assembly");
        }
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("ProtectedInternal Menthod is accessible  within the same assembly and by derived classes of other assembly");
        }
    }
}
