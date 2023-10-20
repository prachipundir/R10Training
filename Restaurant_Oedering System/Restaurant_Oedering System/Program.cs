namespace Restaurant_Oedering_System
{
    public class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            //creating some menu items
            var pasta = new FoodItem("White Sauce Pasta","delicious pasta dish", 12.99m);
            var salad = new FoodItem("healthy salad","Fresh and crisp salad", 7.99m);
            var Coke = new FoodItem("coke","refreshing Beverage", 1.99m);

            //  creating an Order
            Order order = new Order();
            order.AddItem(pasta);
            order.AddItem(salad);
            order.AddItem(Coke);

            // creating order number 2
            Order order2=new Order();
            order2.AddItem(pasta);
            order2.AddItem(Coke);

            //sending orders to the Restaurants
            restaurant.CreateOrder(order);
            restaurant.CreateOrder(order2);

            // calculating  and display total earnings
            decimal totalEarnings=restaurant.CalculateTotalEarnings();
            Console.WriteLine($"Total Earnings:{totalEarnings}");


        }
    }
}