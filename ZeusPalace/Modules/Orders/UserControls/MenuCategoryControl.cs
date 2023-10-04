using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeusPalace.Entities.Order;

namespace ZeusPalace.Modules.Orders.UserControls
{
    public partial class MenuCategoryControl : UserControl
    {
        public MenuCategoryControl(string categoryName)
        {
            InitializeComponent();
            labelCategory.Text = categoryName;
        }

        public MenuCategoryControl(string categoryName, int startTime, int endTime)
        {
            InitializeComponent();
            labelCategory.Text = $"{categoryName} ({ConvertToTimeString(startTime)} - {ConvertToTimeString(endTime)})";
        }

        private string ConvertToTimeString(int timeValue)
        {
            int hours = timeValue / 100;
            int minutes = timeValue % 100;
            string formattedTime = hours.ToString("D2") + ":" + minutes.ToString("D2");
            return formattedTime;
        }
    }
}
