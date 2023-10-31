namespace DelegateExample
{
    delegate int MathOperation(int a, int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation addition=(x,y)=>x + y;
            MathOperation subtract=(x,y)=>x - y;
            MathOperation multiply=(x,y)=>x*y;

            int fisrtNumber = 10;
            int secondNumber = 5;

            int sum= addition(fisrtNumber, secondNumber);
            Console.WriteLine(sum);
            int difference= subtract(fisrtNumber, secondNumber);
            Console.WriteLine(difference);
            int product=multiply(fisrtNumber, secondNumber);
            Console.WriteLine(product);

        }
    }
}