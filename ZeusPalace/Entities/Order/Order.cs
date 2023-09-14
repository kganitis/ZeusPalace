using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Order
{
    internal class Order
    {
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public decimal TotalPrice => CalculateTotalPrice();
        public OrderStatus Status { get; set; }
        public Chat Chat { get; set; } = new Chat();

        public Order()
        {
            Status = OrderStatus.Open;
        }

        public void AddOrderItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void UpdateOrderItem(OrderItem item, int quantity)
        {
            item.Quantity = quantity;
        }

        public void removeOrderItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0.0m;
            foreach (var orderItem in OrderItems)
            {
                totalPrice += orderItem.GetTotalPrice();
            }
            return totalPrice;
        }
    }
}
