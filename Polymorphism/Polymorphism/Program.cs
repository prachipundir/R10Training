namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Method Overloading!----------------");
            TestData testData = new TestData();
            Console.WriteLine(testData.Add(1,2));
            Console.WriteLine(testData.Add(3,4,5));
           Console.WriteLine(testData.Add(6.7f,7,8));
            Console.WriteLine("_______________Method Overriding________________");
            Dog dog = new Dog();
            dog.Eat();
        }
    }
}