namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("****************************This is the example of constructor overLoadiing***************************");
             MySampleClass mySampleClass = new MySampleClass();
             MySampleClass mySampleClass1 = new MySampleClass("prachi");
             MySampleClass mySampleClass2 = new MySampleClass(12, "prachi");
             Console.WriteLine("_______________C# Properties___________________");
             Employee employee=new Employee();
             employee.Name = "prachi";
             Console.WriteLine(employee.Name);
        }
    }
}