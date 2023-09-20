using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeusPalace.Entities.Order;

namespace ZeusPalace.Modules.Orders.UserControls
{
    public partial class OrderPanelPaymentControl : OrderPanelControl
    {
        public event EventHandler CreditCard_CheckedChanged;
        public PaymentMethod PaymentMethod
        {
            get
            {
                PaymentMethod method = PaymentMethod.CreditCard;
                if (radioButtonCash.Checked) { method = PaymentMethod.Cash; }
                else if (radioButtonAddToAccount.Checked) { method = PaymentMethod.AddToAccount; }
                return method;
            }
        }

        public DeliveryMethod DeliveryMethod
        {
            get
            {
                DeliveryMethod method = DeliveryMethod.TakeAway;
                if (radioButtonAppartment.Checked) { method = DeliveryMethod.Appartment; }
                else if (radioButtonPool.Checked) { method = DeliveryMethod.Pool; }
                return method;
            }
        }

        public OrderPanelPaymentControl(decimal balance)
        {
            InitializeComponent();
            AlignLabelToCenter(labelTitle, panelTitle);
            Balance = balance;
        }

        public decimal Balance
        {
            set { labelBalance.Text = $"Νέο υπόλοιπο: {value} €"; }
        }

        private void radioButtonAddToAccount_CheckedChanged(object sender, EventArgs e)
        {
            labelBalance.Visible = radioButtonAddToAccount.Checked;
        }

        private void radioButtonCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            CreditCard_CheckedChanged?.Invoke(radioButtonCreditCard, EventArgs.Empty);
        }
    }
}
