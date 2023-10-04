using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class TestData
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x,int y,int z)
        {
            return x + y + z;
        }
        public float Add(float x, int y, int z)
        {
            return x + y + z;
        }
    }
}
