using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Order
{
    internal class Order
    {
        public int OrderNumber { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public decimal TotalPrice => CalculateTotalPrice();
        public OrderStatus Status { get; set; }
        public Chat Chat { get; set; } = new Chat();

        public Order(int orderNumber)
        {
            OrderNumber = orderNumber;
            Status = OrderStatus.Open;
        }

        public void AddOrderItem(OrderItem item)
        {
            OrderItems.Add(item);
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
