using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCsharp
{
    public class StringConversion
    {
        public void ConvertString()
        {
            // we can use ToUpper() method
            Console.WriteLine("*****************************BY USING ToUpper() method*************************************");
            Console.WriteLine("Enter the string you want to convert to uppercase:");
            string strng = Console.ReadLine();
            strng = strng.ToUpper();
            Console.WriteLine(strng);



        }
    }
}
