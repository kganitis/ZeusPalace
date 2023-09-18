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
        public string ItemName => labelName.Text;
        public int Quantity => menuItemQuantityControl.Quantity;

        public MenuItemControl() : this(null, 0) { }

        public MenuItemControl(Entities.Order.MenuItem menuItem) : this(menuItem, 0) { }

        public MenuItemControl(Entities.Order.MenuItem menuItem, int initialQuantity)
        {
            InitializeComponent();

            menuItemQuantityControl = new MenuItemQuantityControl(initialQuantity);
            menuItemQuantityControl.QuantityChanged += MenuItemQuantityControl_QuantityChanged;

            if (menuItem != null)
            {
                labelName.Text = menuItem.Name;
                labelPrice.Text = $"{menuItem.Price} €";
            }

            UpdateControlsVisibility();
        }

        private void UpdateControlsVisibility()
        {
            if (Quantity == 0)
            {
                ShowControl(buttonAdd);
            }
            else
            {
                ShowControl(menuItemQuantityControl);
            }
        }

        private void ShowControl(Control control)
        {
            Control controlToReplace = tableLayoutPanel1.GetControlFromPosition(2, 0);
            if (controlToReplace != control) 
            {
                tableLayoutPanel1.Controls.Remove(controlToReplace);
                tableLayoutPanel1.Controls.Add(control, 2, 0);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            menuItemQuantityControl.Quantity = 1;
            UpdateControlsVisibility();
        }

        private void MenuItemQuantityControl_QuantityChanged(object sender, EventArgs e)
        {
            UpdateControlsVisibility();
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
