using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    //FACADE CLASS
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Placing the Order");
            Product product=new Product();
            product.GetProductDetails();

            Payment payment=new Payment();
            payment.MakePayment();

            Invoice invoice=new Invoice();
            invoice.SendInvoice();

            Console.WriteLine("Order Placed Successfully");
        }
    }
}
