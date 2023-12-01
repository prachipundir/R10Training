namespace SingletonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance;
            singleton.PrinrDetails(" This is from another class");
            Singleton singleton2 = Singleton.GetInstance;
            singleton2.PrinrDetails("This is from some other class");
        }
    }
}