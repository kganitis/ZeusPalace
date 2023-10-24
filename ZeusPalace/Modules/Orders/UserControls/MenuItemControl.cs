using System;
using System.Windows.Forms;
using MenuItem = ZeusPalace.Entities.Order.MenuItem;

namespace ZeusPalace.Modules.Orders
{
    public partial class MenuItemControl : UserControl
    {
        private readonly MenuItemQuantityControl menuItemQuantityControl;
        public event EventHandler QuantityChanged;
        public string ItemName => labelName.Text;
        public int Quantity
        {
            get { return menuItemQuantityControl.Quantity; }
            set { menuItemQuantityControl.Quantity = value; }
        }

        public MenuItemControl() : this(null, 0) { }

        public MenuItemControl(MenuItem menuItem) : this(menuItem, 0) { }

        public MenuItemControl(MenuItem menuItem, int initialQuantity, bool viewOnly=false)
        {
            InitializeComponent();

            menuItemQuantityControl = new MenuItemQuantityControl(initialQuantity, viewOnly);
            menuItemQuantityControl.QuantityChanged += MenuItemQuantityControl_QuantityChanged;

            if (menuItem != null)
            {
                labelName.Text = menuItem.Name;
                labelPrice.Text = $"{menuItem.Price} €";
            }

            UpdateControlsVisibility();

            if (viewOnly)
            {
                labelPrice.Visible = false;
            }
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

        public MenuItemControl Clone()
        {
            MenuItemControl clonedControl = new MenuItemControl(null, Quantity, true);
            clonedControl.labelName.Text = labelName.Text;
            return clonedControl;
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
