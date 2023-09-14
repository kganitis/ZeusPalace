using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ZeusPalace.Entities.Order
{
    internal class MenuItem
    {
        public string Name { get; set; }
        public MenuItemType Type { get; set; }
        public decimal Price { get; set; }

        public MenuItem(string name, MenuItemType type, decimal price)
        {
            Name = name;
            Type = type;
            Price = price;
        }
    }
}
