namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var myClass= new MyClass();
            myClass.PublicField = 1;
            //myClass.PrivateField=2;// not accessible
            //myClass.ProtectedField=10; // not accessible
            myClass.InternalField = 2;// Accessible within the same assembly
            myClass.ProtectedInternalField = 3;// Accessible within the same assembly

            myClass.PublicMethod();
            //myclass.PrivateMethod():
            //myclass.ProtectedMethod():
            myClass.InternalMethod();
            myClass.ProtectedInternalMethod();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.AccessProtectedField();
        }
    }
}