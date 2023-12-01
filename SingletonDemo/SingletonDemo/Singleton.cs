using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int CountObject=0;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if(instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton() {
            CountObject++;
            Console.WriteLine(CountObject);
        }
        public void PrinrDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
