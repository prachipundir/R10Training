namespace AsynchronousProgrammimg
{
    internal class Program
    {
        async static void SomeMethod()
        {
            Console.WriteLine(" Some method Started!");
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("/n");
            Console.WriteLine("Some method Exiting!");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started!");
            SomeMethod();
            Console.WriteLine("Main method exiting!");
            Console.ReadLine();


        }
    }
}