﻿using System;
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

        public MenuItemQuantityControl(int quantity, bool viewOnly=false) : this()
        {
            labelQuantity.Text = quantity.ToString();
            if (viewOnly )
            {
                buttonRemove.Visible = false;
                buttonAdd.Visible = false;
            }
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
