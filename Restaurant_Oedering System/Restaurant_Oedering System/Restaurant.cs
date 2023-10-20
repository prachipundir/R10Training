using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Oedering_System
{
    public class Restaurant
    {
        public List<Order> Orders { get; } = new List<Order>();

        public void CreateOrder(Order order)
        {
            Orders.Add(order);
        }
        public decimal CalculateTotalEarnings()
        {
            decimal totalEarnings = 0;
            foreach(var order in Orders)
            {
                totalEarnings += order.CalculateTotal();
            }
            return totalEarnings;
        }
    }
}
