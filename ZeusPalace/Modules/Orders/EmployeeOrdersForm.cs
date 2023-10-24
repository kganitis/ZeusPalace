using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ZeusPalace.Modules.Orders.UserControls;

namespace ZeusPalace.Modules.Orders
{
    public partial class EmployeeOrdersForm : ZeusPalace.Modules.EmbeddedForm
    {
        public event EventHandler MessageSent;
        public event EventHandler OrderConfirmed;
        public event EventHandler OrderRejected;

        private int currentTime;
        private EmployeeChatForm employeeChat;
        private OrderPanelTableControl panelOrderPreview;

        public string LastMessageSent => employeeChat.LastMessageSent;

        public EmployeeOrdersForm()
        {
            InitializeComponent();
        }

        public EmployeeOrdersForm(int currentTime, string customerName) : this()
        {
            this.currentTime = currentTime;
            InitializeControls(customerName);
        }

        private void InitializeControls(string customerName)
        {
            // currentTime
            string formattedTime = $"{currentTime / 100:00}:{currentTime % 100:00}";
            labelTime.Text = formattedTime;
            AlignLabelToCenter(labelTime, panelTime);

            // Buttons
            buttonReject.FlatAppearance.MouseDownBackColor = buttonReject.FlatAppearance.MouseOverBackColor;
            buttonConfirm.BackColor = ColorPicker.TurquoiseGreen;
            buttonConfirm.FlatAppearance.MouseOverBackColor = ColorPicker.GetShade(buttonConfirm.BackColor, 10);
            buttonConfirm.FlatAppearance.MouseDownBackColor= buttonConfirm.FlatAppearance.MouseOverBackColor;

            // Chat
            employeeChat = new EmployeeChatForm(customerName);
            employeeChat.MessageSent += EmployeeChat_MessageSent;
            employeeChat.TopLevel = false;
            employeeChat.Dock = DockStyle.Fill;
            panelChat.Controls.Add(employeeChat);
            employeeChat.BringToFront();
            employeeChat.Show();
        }

        private void EmployeeChat_MessageSent(object sender, EventArgs e)
        {
            MessageSent?.Invoke(this, EventArgs.Empty);
        }

        public void ReceiveMessage(string message)
        {
            employeeChat.ReceiveMessage(message);
        }

        internal void ReceiveOrder(IEnumerable<MenuItemControl> orderItems)
        {
            if (panelOrder.Controls.Contains(panelOrderPreview))
            {
                panelOrder.Controls.Remove(panelOrderPreview);
            }
            panelOrderPreview = new OrderPanelTableControl("Εισερχόμενη παραγγελία");
            foreach (var nextItem in orderItems)
            {
                MenuItemControl menuItemControl = nextItem.Clone();
                panelOrderPreview.AddItem(menuItemControl);
            }
            panelOrderPreview.Dock = DockStyle.Top;
            panelOrder.Controls.Add(panelOrderPreview);
            buttonConfirm.Text = "Επιβεβαίωση παραγγελίας";
            buttonConfirm.Visible = true;
            buttonReject.Visible = true;
            buttonConfirm.Enabled = true;
            buttonReject.Enabled = true;
        }

        internal void CancelOrder()
        {
            if (panelOrder.Controls.Contains(panelOrderPreview))
            {
                panelOrder.Controls.Remove(panelOrderPreview);
                panelOrderPreview.Dispose();
                panelOrderPreview = null;
            }
            buttonConfirm.Text = "Επιβεβαίωση παραγγελίας";
            buttonConfirm.Visible = false;
            buttonReject.Visible = false;
            buttonConfirm.Enabled = false;
            buttonReject.Enabled = false;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            OrderConfirmed?.Invoke(this, EventArgs.Empty);
            buttonConfirm.Text = "Επιβεβαιώθηκε";
            buttonConfirm.Enabled = false;
            buttonReject.Visible = false;
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            OrderRejected?.Invoke(this, EventArgs.Empty);
        }
    }
}
