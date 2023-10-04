namespace IntroductionToCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Prime prime = new Prime();
            StringConversion str=new StringConversion();
            SumTwoNumbers sumtwonumbers=new SumTwoNumbers();
            prime.CheckPrime();
            str.ConvertString();
            sumtwonumbers.SumNumbers();
        }
    }
}