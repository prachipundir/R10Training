using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class Prime
    {
       public void CheckPrime()
        {
            Console.WriteLine("Enter The number to check whether its Prime or not:");
            int num=Convert.ToInt32(Console.ReadLine());
            if(num<=1 ) 
            {
                Console.WriteLine("not Prime");
            }
            else
            {
                bool flg = true;
                double sqroot=Math.Sqrt(num);
                for(int i = 2; i <= sqroot; i++)
                {
                    if(num%i==0) {
                        flg = false; break;
                    }
                }
                if (flg)
                {
                    Console.WriteLine("Prime");
                }
                else { Console.WriteLine("Not Prime"); }
            }
            
            
        }
    }
}
