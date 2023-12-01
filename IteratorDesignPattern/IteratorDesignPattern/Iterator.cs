using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    class Iterator : IAbstractIterator
    {
        //ConcreteAggregate variable to hold the collection elements
        private ConcreteCollection Collection;
        private int Current = 0;
        private readonly int Step = 1;
        // Constructor
        public Iterator(ConcreteCollection Collection)
        {
            //Initializing the ConcreteAggregate variable using Constructor
            this.Collection = Collection;
        }
        // Gets First Item from the Collection
        public Elempoyee First()
        {
            //Setting Current as 0 to access the First Element of the Sequence
            Current = 0;
            return Collection.GetEmployee(Current);
        }
        // Gets Next Item from the Collection
        public Elempoyee Next()
        {
            //Increase the Current Index Position by step (Step = 1), 
            //to access the Next Element from the collection
            Current += Step;
            if (!IsCompleted)
            {
                return Collection.GetEmployee(Current);
            }
            else
            {
                return null;
            }
        }
        // Check whether the iteration is complete
        public bool IsCompleted
        {
       
            get { return Current >= Collection.Count; }
        }
    }
}
