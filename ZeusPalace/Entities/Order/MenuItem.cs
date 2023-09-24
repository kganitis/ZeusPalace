using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ZeusPalace.Entities.Order
{
    public class MenuItem
    {
        public string Name { get; set; }
        public MenuItemType Type { get; set; }
        public decimal Price { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public MenuItem(string name, MenuItemType type, decimal price)
        {
            Name = name;
            Type = type;
            Price = price;
            StartTime = GetStartTime();
            EndTime = GetEndTime();
        }

        public bool IsAvailable(int currentTime)
        {
            int adjustedStartTime = StartTime;
            int adjustedEndTime = EndTime;
            if (StartTime > EndTime)
            {
                if (currentTime > StartTime)
                {
                    adjustedEndTime += 2400;
                }
                else
                {
                    adjustedStartTime -= 2400;
                }
            }
            return currentTime >= adjustedStartTime && currentTime < adjustedEndTime;
        }

        // Helper method to get the StartTime attribute value
        public int GetStartTime()
        {
            FieldInfo fieldInfo = Type.GetType().GetField(Type.ToString());
            MenuItemAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(MenuItemAttribute), false) as MenuItemAttribute[];

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].StartTime;
            }

            // Default value if attribute not found
            return 0;
        }

        // Helper method to get the EndTime attribute value
        public int GetEndTime()
        {
            FieldInfo fieldInfo = Type.GetType().GetField(Type.ToString());
            MenuItemAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(MenuItemAttribute), false) as MenuItemAttribute[];

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].EndTime;
            }

            // Default value if attribute not found
            return 2400;
        }

        // Helper method to get the StringValue attribute value
        public string GetTypeStringValue()
        {
            FieldInfo fieldInfo = Type.GetType().GetField(Type.ToString());
            MenuItemAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(MenuItemAttribute), false) as MenuItemAttribute[];

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].StringValue;
            }

            // Default value if attribute not found
            return string.Empty;
        }
    }
}
