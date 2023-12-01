﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    // Aggregate Interface
    interface IAbstractCollection
    {
        // The following Method is going to Return an Iterator object.
        // Later, we will Implement the Iterator class
        Iterator CreateIterator();
    }
}
