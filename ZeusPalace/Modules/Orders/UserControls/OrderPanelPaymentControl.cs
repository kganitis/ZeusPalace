using System;
using ZeusPalace.Entities.Accommodation;
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
            if (AppController.Instance.Customer.Accommodation.Type == AccommodationType.TrojanHorse)
            {
                radioButtonAppartment.Text = "Παράδοση στον δούρειο ίππο";
            }
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
