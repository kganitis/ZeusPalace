using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Entities.Order
{
    internal class OrderItem
    {
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }

        public OrderItem(MenuItem menuItem, int quantity)
        {
            MenuItem = menuItem;
            Quantity = quantity;
        }

        public decimal GetTotalPrice()
        {
            return MenuItem.Price * Quantity;
        }
    }
}
