using Microsoft.SqlServer.Server;
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

        public MenuItemQuantityControl()
        {
            InitializeComponent();
            labelQuantity.Text = "0";
        }

        public MenuItemQuantityControl(int quantity)
        {
            InitializeComponent();
            labelQuantity.Text = quantity.ToString();
        }

        public int Quantity
        {
            get { return int.Parse(labelQuantity.Text); }
            set
            {
                if (Quantity != value)
                {
                    labelQuantity.Text = value.ToString();
                    QuantityChanged?.Invoke(this, EventArgs.Empty);
                }
            }
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
