using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeusPalace.Entities.Order;

namespace ZeusPalace.Modules.Orders
{
    public partial class MenuItemControl : UserControl
    {
        private readonly MenuItemQuantityControl menuItemQuantityControl;
        public event EventHandler QuantityChanged;

        public string ItemName { get { return labelName.Text; } }

        public int Quantity
        {
            get { return menuItemQuantityControl.Quantity; }
        }

        public MenuItemControl()
        {
            InitializeComponent();
            menuItemQuantityControl = new MenuItemQuantityControl();
        }

        public MenuItemControl(Entities.Order.MenuItem menuItem)
        {
            InitializeComponent();
            menuItemQuantityControl = new MenuItemQuantityControl();
            menuItemQuantityControl.QuantityChanged += MenuItemQuantityControl_QuantityChanged;
            labelName.Text = menuItem.Name;
            labelPrice.Text = menuItem.Price.ToString() + " €";
        }

        public MenuItemControl(Entities.Order.MenuItem menuItem, int quantity)
        {
            InitializeComponent();
            menuItemQuantityControl = new MenuItemQuantityControl(quantity);
            menuItemQuantityControl.QuantityChanged += MenuItemQuantityControl_QuantityChanged;
            labelName.Text = menuItem.Name;
            labelPrice.Text = menuItem.Price.ToString() + " €";
            tableLayoutPanel1.Controls.Remove(buttonAdd);
            tableLayoutPanel1.Controls.Add(menuItemQuantityControl, 2, 0);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            menuItemQuantityControl.Quantity = 1;
            tableLayoutPanel1.Controls.Remove(buttonAdd);
            tableLayoutPanel1.Controls.Add(menuItemQuantityControl, 2, 0);
        }

        private void MenuItemQuantityControl_QuantityChanged(object sender, EventArgs e)
        {
            if (Quantity == 0)
            {
                tableLayoutPanel1.Controls.Remove(menuItemQuantityControl);
                tableLayoutPanel1.Controls.Add(buttonAdd, 2, 0);
            }
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void MenuItemControl_EnabledChanged(object sender, EventArgs e)
        {
            if (!Enabled)
            {
                tableLayoutPanel1.Controls.Remove(buttonAdd);
            }
            else
            {
                tableLayoutPanel1.Controls.Add(buttonAdd, 2, 0);
            }
        }
    }
}
