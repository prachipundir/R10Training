using System.ComponentModel;

namespace LambdaExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for(int i=0;i<10; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                list.Add(num);

            }
            Console.WriteLine("original list");
            foreach(var number in list)
            {
                Console.WriteLine(number);
            }

            var evenNumbers = list.Where(x => x % 2 == 0);
            Console.WriteLine("Even numbers in the list");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}