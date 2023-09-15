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

    public enum MenuItemType
    {
        [MenuItem("Καφέδες", startTime: 600, endTime: 1600)]
        Coffee,

        [MenuItem("Ροφήματα", startTime: 600, endTime: 2400)]
        Beverage,

        [MenuItem("Πρωινό", startTime: 600, endTime: 1000)]
        Breakfast,

        [MenuItem("Γεύματα", startTime: 1200, endTime: 1600)]
        Meal,

        [MenuItem("Ποτά", startTime: 1800, endTime: 200)]
        Alcohol,

        [MenuItem("Επιδόρπια", startTime: 1200, endTime: 2400)]
        Dessert
    }

}
