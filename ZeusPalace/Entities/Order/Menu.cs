using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Order
{
    internal class Menu
    {
        private List<MenuItem> menuItems = new List<MenuItem>();

        public void AddMenuItem(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

        public List<MenuItem> GenerateMenuForTime(int currentTime)
        {
            // Filter menu items based on the current time
            return menuItems
                .Where(item => currentTime >= item.StartTime && currentTime <= item.EndTime)
                .ToList();
        }
    }
}
