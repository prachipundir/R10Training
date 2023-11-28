namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null )
            {
                Console.WriteLine("Card Type: "+creditCard.GetCardType());
                Console.WriteLine("Card Limit:" + creditCard.GetCardLimit());
                Console.WriteLine("Annual Charge:"+ creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type!");
            }
            Console.WriteLine("____________________________");
        }
    }
}