using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders
{
    public partial class MenuItemControl : UserControl
    {
        private int quantity;
        public event EventHandler QuantityChanged;
        private MenuItemQuantityControl menuItemQuantityControl;

        public MenuItemControl()
        {
            InitializeComponent();
            Quantity = 0;
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (quantity != value)
                {
                    quantity = value;
                    OnQuantityChanged();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(buttonAdd);
            this.menuItemQuantityControl = new MenuItemQuantityControl();
            this.menuItemQuantityControl.QuantityChanged += MenuItemQuantityControl_QuantityChanged;
            tableLayoutPanel1.Controls.Add(this.menuItemQuantityControl, 2, 0);
            MenuItemQuantityControl menuItemQuantityControl = new MenuItemQuantityControl();
            Quantity++;
        }

        private void OnQuantityChanged()
        {
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void MenuItemQuantityControl_QuantityChanged(object sender, EventArgs e)
        {
            if (sender is MenuItemQuantityControl menuItemQuantityControl)
            {
                Quantity = menuItemQuantityControl.Quantity;
                if (Quantity == 0)
                {
                    tableLayoutPanel1.Controls.Remove(menuItemQuantityControl);
                    tableLayoutPanel1.Controls.Add(buttonAdd, 2, 0);
                }
            }
        }
    }
}
