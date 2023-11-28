using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //this class declares the Factory method  that is going to return an object of the product class (CreditCard.cs)
    public abstract class CreditCardFactory
    {
        protected abstract CreditCard MakeProduct();
        public CreditCard CreateProduct()
        {
            CreditCard creditCard=this.MakeProduct();
            return creditCard;
        }
    }
}
