namespace MethodHiding
{
    class A
    {
        public void Test()
        {
            Console.WriteLine("A::Test()");
        }

    }
    class B:A 
    {
        public new void Test()
        {
            Console.WriteLine("B::Test()");
        }
    
    }
    class C:B
    {
        public new void Test()
        {
            Console.WriteLine("C::Test()");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           A a = new A();
           B b = new B();
           C c = new C();
            a.Test();
            b.Test();
            c.Test();

            a = new B();
            a.Test();
        }
    }
}