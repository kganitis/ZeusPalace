using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Entities.Order
{
    internal class Order
    {
        private readonly List<OrderItem> orderItems = new List<OrderItem>();
        public decimal TotalPrice => CalculateTotalPrice();
        public OrderStatus Status { get; set; }
        public Chat Chat { get; set; } = new Chat();

        public Order()
        {
            Status = OrderStatus.Open;
        }

        public void UpdateOrderItem(MenuItem menuItem, int quantity)
        {
            var orderItem = orderItems.FirstOrDefault(item => item.MenuItem == menuItem);

            if (orderItem != null)
            {
                orderItem.Quantity = quantity;
                if (quantity == 0)
                {
                    orderItems.Remove(orderItem);
                }
            }
            else
            {
                orderItems.Add(new OrderItem(menuItem, quantity));
            }
        }

        public OrderItem GetOrderItemByName(string orderItemName)
        {
            return orderItems.FirstOrDefault(item => item.MenuItem.Name == orderItemName);
        }

        public int GetOrderItemQuantity(string orderItemName)
        {
            OrderItem item = GetOrderItemByName(orderItemName);
            if (item != null)
            {
                return item.Quantity;
            }
            else
            {
                return 0;
            }
        }

        public int GetOrderItemsCount()
        {
            return orderItems.Count;
        }

        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0.00m;
            foreach (var orderItem in orderItems)
            {
                totalPrice += orderItem.GetTotalPrice();
            }
            return totalPrice;
        }

        public void CancelOrder()
        {
            orderItems.Clear();
            Status = OrderStatus.Cancelled;
        }
    }
}
