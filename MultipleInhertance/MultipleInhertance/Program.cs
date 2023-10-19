namespace MultipleInhertance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultipleInheritanceTest multipleInheritanceTest = new MultipleInheritanceTest();
            multipleInheritanceTest.Test();
            IMultiple1 interface1 = multipleInheritanceTest;
            IMultiple2 interface2 = multipleInheritanceTest;
            interface1.Show();
            interface2.Show();
        }
    }
}