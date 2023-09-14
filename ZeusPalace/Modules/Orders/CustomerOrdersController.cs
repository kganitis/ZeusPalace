﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeusPalace.Entities.Order;

namespace ZeusPalace.Modules.Orders
{
    internal class CustomerOrdersController
    {
        public Order Order { get; set; } = new Order();
        public Menu Menu { get; set; } = new Menu();

        public CustomerOrdersController()
        {
            Menu.MenuItems = Menu.GetDefaultMenuItems();
        }
    }
}
