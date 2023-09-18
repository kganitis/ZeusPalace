﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeusPalace.Entities.Order;
using Menu = ZeusPalace.Entities.Order.Menu;
using MenuItem = ZeusPalace.Entities.Order.MenuItem;

namespace ZeusPalace.Modules.Orders
{
    internal class CustomerOrdersController
    {
        private Order order = new Order();
        private Menu menu = new Menu();

        public CustomerOrdersController()
        {
            SetOrderStatus(OrderStatus.Open);
        }

        public void SetOrderStatus(OrderStatus orderStatus)
        {
            order.Status = orderStatus;
        }

        public void UpdateItemQuantity(string itemName, int quantity)
        {
            order.UpdateOrderItem(menu.GetMenuItemByName(itemName), quantity);
        }

        public MenuItem GetMenuItem(int index)
        {
            return menu.GetMenuItem(index);
        }

        public MenuItem GetMenuItemByName(string menuItemName)
        {
            return menu.GetMenuItemByName(menuItemName);
        }

        public int GetMenuItemsCount()
        {
            return menu.GetMenuItemsCount();
        }

        public bool ItemIsAvailabe(string itemName, int currentTime)
        {
            return menu.GetMenuItemByName(itemName).IsAvailable(currentTime);
        }

        public decimal GetTotalPrice()
        {
            return order.TotalPrice;
        }

        public void CancelOrder()
        {
            order.CancelOrder();
        }
    }
}
