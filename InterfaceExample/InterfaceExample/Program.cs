namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INTERFACE
            //Blueprint of a class
            //all methods which are declared inside an instance are abstract method
            //it is used to implement Multiple inheritance
            //It is used to achieve fully abstraction because it cannot have method body.
            //the class or struct which implements the interface must provide the implementation of all the methods declared in the  interface.
            // Interface cannot contain constructors
            // A class can implement more than one interfaces--> solves Diamond Problem.
            Drawlable drawable;
            drawable = new Rectangle();
            drawable.Draw();
            drawable=new Circle();
            drawable.Draw();
        }
    }
}