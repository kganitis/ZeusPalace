using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Order
{
    internal class Menu
    {
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

        public void AddMenuItem(MenuItem menuItem)
        {
            MenuItems.Add(menuItem);
        }

        public List<MenuItem> GenerateMenuForTime(int currentTime)
        {
            // Filter menu items based on the current time
            return MenuItems
                .Where(item => currentTime >= GetStartTime(item.Type) && currentTime <= GetEndTime(item.Type))
                .ToList();
        }

        // Helper method to get the StartTime attribute value for a MenuItemType
        private int GetStartTime(MenuItemType menuItemType)
        {
            FieldInfo fieldInfo = menuItemType.GetType().GetField(menuItemType.ToString());
            MenuItemAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(MenuItemAttribute), false) as MenuItemAttribute[];

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].StartTime;
            }

            // Default value if attribute not found
            return 0;
        }

        // Helper method to get the EndTime attribute value for a MenuItemType
        private int GetEndTime(MenuItemType menuItemType)
        {
            FieldInfo fieldInfo = menuItemType.GetType().GetField(menuItemType.ToString());
            MenuItemAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(MenuItemAttribute), false) as MenuItemAttribute[];

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].EndTime;
            }

            // Default value if attribute not found
            return 24; // Assuming the default end time is 23:59
        }

        // Helper method to get the StringValue attribute value for a MenuItemType
        private string GetStringValue(MenuItemType menuItemType)
        {
            FieldInfo fieldInfo = menuItemType.GetType().GetField(menuItemType.ToString());
            MenuItemAttribute[] attributes = fieldInfo.GetCustomAttributes(typeof(MenuItemAttribute), false) as MenuItemAttribute[];

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].StringValue;
            }

            // Default value if attribute not found
            return string.Empty;
        }


        public static List<MenuItem> GetDefaultMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>
            {
                // Coffee
                new MenuItem("Ελληνικός Καφές", MenuItemType.Coffee, 2),
                new MenuItem("Εσπρέσο Ηλυσίων", MenuItemType.Coffee, 4),
                new MenuItem("Μόκα Ολύμπου", MenuItemType.Coffee, 3),

                // Beverage
                new MenuItem("Πράσινο Τσάι Δελφών", MenuItemType.Beverage, 3),
                new MenuItem("Τριαντάφυλλο Αφροδίτης", MenuItemType.Beverage, 5),
                new MenuItem("Νέκταρ των Ναϊάδων", MenuItemType.Beverage, 6),
                new MenuItem("Ποσειδώνια Σόδα", MenuItemType.Beverage, 3),

                // Breakfast
                new MenuItem("Ομελέτα Σπάρτης", MenuItemType.Breakfast, 8),
                new MenuItem("Θεσσαλικό Γιαούρτι", MenuItemType.Breakfast, 6),
                new MenuItem("Άκρατος με Σύκα και Ελιές", MenuItemType.Breakfast, 5),

                // Meal
                new MenuItem("Θαλασσινά Αιγαίου", MenuItemType.Meal, 20),
                new MenuItem("Ψητά Λαχανικά Αρτέμιδος", MenuItemType.Meal, 10),
                new MenuItem("Αρνί Ξενίου Ζευς", MenuItemType.Meal, 15),
                new MenuItem("Ζυμαρικά Δήμητρας", MenuItemType.Meal, 12),

                // Dessert
                new MenuItem("Μελιττούτα", MenuItemType.Dessert, 5),
                new MenuItem("Τηγανίτες", MenuItemType.Dessert, 4),

                // Alcohol
                new MenuItem("Οίνος Ερυθρός", MenuItemType.Alcohol, 5),
                new MenuItem("Οίνος Λευκός", MenuItemType.Alcohol, 5),
                new MenuItem("Μπίρα", MenuItemType.Alcohol, 4),
                new MenuItem("Υδρόμελο", MenuItemType.Alcohol, 3)
            };

            return menuItems;
        }
    }
}
