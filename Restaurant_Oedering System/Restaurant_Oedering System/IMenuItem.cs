using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Oedering_System
{
    public interface IMenuItem
    {
        string Name { get; }
        string Description { get; }
        decimal Price { get; }
    }
}
