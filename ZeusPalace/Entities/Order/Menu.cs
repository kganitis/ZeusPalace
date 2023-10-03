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
        private List<MenuItem> menuItems;

        public Menu()
        {
            menuItems = GetDefaultMenuItems();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

        public MenuItem GetMenuItem(int index)
        {
            return menuItems[index];
        }

        public MenuItem GetMenuItemByName(string menuItemName)
        {
            return menuItems.FirstOrDefault(item => item.Name == menuItemName);
        }

        public int GetMenuItemsCount()
        {
            return menuItems.Count;
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
