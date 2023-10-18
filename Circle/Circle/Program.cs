namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0);
            Console.WriteLine($"Circle- Radius{circle._radius},Area:{circle.CalculateArea()}");

        }
    }
}