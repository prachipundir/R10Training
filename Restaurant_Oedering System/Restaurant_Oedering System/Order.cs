using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Restaurant_Oedering_System
{
    public class Order
    {
        public List<IMenuItem> Items { get; }=new List<IMenuItem>();

        public void AddItem(IMenuItem item)
        {
            Items.Add(item);
        }
        public decimal CalculateTotal()
        { 
            decimal total = 0;
            foreach(var item in Items)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
