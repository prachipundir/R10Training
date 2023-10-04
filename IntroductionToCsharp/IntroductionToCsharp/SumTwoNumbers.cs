using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class SumTwoNumbers
    {
        public void SumNumbers() {
            Console.WriteLine("Enter Two numbers:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Sum is:" + (num1 + num2));
        }
        
    }
}
