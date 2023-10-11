namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ABSTRACT CLASSES:
            // cannot be instantiated.
            //works as a blueprint for Derived Classes.
            //can contatin abstract and non-abstract(concrete)methods
            //abstract methods only have declaration in an abstract class and no implementation in abstract class, and must be overridden in Derived class.
            //abstract methods have definition in derived class.
            Circle circle = new Circle { Radius = 5 };
            Rectangle rectangle = new Rectangle { Width = 6, Height = 4 };
            Triangle triangle = new Triangle { Side1 = 3, Side2 = 4, Side3 = 5 };

            Console.WriteLine("Circle Area: " + circle.CalculateArea());
            Console.WriteLine("Circle Perimeter: " + circle.CalculatePerimeter());

            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
            Console.WriteLine("Rectangle Perimeter: " + rectangle.CalculatePerimeter());

            Console.WriteLine("Triangle Area: " + triangle.CalculateArea());
            Console.WriteLine("Triangle Perimeter: " + triangle.CalculatePerimeter());
        }
    }
}