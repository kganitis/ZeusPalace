using System;

namespace ZeusPalace.Entities.Order
{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    sealed class MenuItemAttribute : Attribute
    {
        public string StringValue { get; }
        public int StartTime { get; }
        public int EndTime { get; }

        public MenuItemAttribute(string stringValue, int startTime, int endTime)
        {
            StringValue = stringValue;
            StartTime = startTime;
            EndTime = endTime;
        }
    }

    internal enum MenuItemType
    {
        [MenuItem("Καφέδες", startTime: 6, endTime: 16)]
        Coffee,

        [MenuItem("Ροφήματα", startTime: 6, endTime: 24)]
        Beverage,

        [MenuItem("Πρωινό", startTime: 6, endTime: 10)]
        Breakfast,

        [MenuItem("Γεύματα", startTime: 12, endTime: 16)]
        Meal,

        [MenuItem("Ποτά", startTime: 18, endTime: 2)]
        Alcohol,

        [MenuItem("Επιδόρπια", startTime: 12, endTime: 24)]
        Dessert
    }

}
