using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInhertance
{
    internal class MultipleInheritanceTest : IMultiple1, IMultiple2
    {
        public void Test()
        {
            Console.WriteLine("Test method is implemented in child Class");
        }
         void IMultiple1.Show()
        {
            Console.WriteLine("Imultiple1's Show method implemented in chid class");
        }
        void IMultiple2.Show()
        {
            Console.WriteLine("Imultiple2's Show method implemented in chid class");
        }
    }
}
