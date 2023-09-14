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
    public partial class MenuItemQuantityControl : UserControl
    {
        public event EventHandler QuantityChanged;
        private int quantity;

        public MenuItemQuantityControl()
        {
            InitializeComponent();
            Quantity = 1;
            labelQuantity.Text = Quantity.ToString();
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

        private void OnQuantityChanged()
        {
            QuantityChanged?.Invoke(this, EventArgs.Empty);
            labelQuantity.Text = Quantity.ToString();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Quantity--;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Quantity++;
        }
    }
}
