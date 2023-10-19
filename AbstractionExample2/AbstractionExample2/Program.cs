namespace AbstractionExample2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hyundai hyundai = new Hyundai();
            Console.WriteLine("***********************Information of Hyundai***********************");
            Console.WriteLine(hyundai.CheckWheels());
            Console.WriteLine(hyundai.CheckAc());
            Console.WriteLine(hyundai.CheckDiscount());
            Console.WriteLine(hyundai.CheckColor());
            Console.WriteLine(hyundai.CheckSeat());
            Console.WriteLine(hyundai.CheckPrice());

            Toyota toyota = new Toyota();
            Console.WriteLine("*********************Information of Toyota************************");
            Console.WriteLine(toyota.CheckWheels());
            Console.WriteLine(toyota.CheckAc());
            Console.WriteLine(toyota.CheckColor());
            Console.WriteLine(toyota.CheckSeat());
            Console.WriteLine(toyota.CheckPrice());
        }
    }
}