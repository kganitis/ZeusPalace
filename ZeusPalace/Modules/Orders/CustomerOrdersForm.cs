using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeusPalace.Entities.Accommodation;
using ZeusPalace.Entities.Order;
using ZeusPalace.Modules.Orders.UserControls;
using MenuItem = ZeusPalace.Entities.Order.MenuItem;

namespace ZeusPalace.Modules.Orders
{
    public partial class CustomerOrdersForm : EmbeddedForm
    {
        #region Fields and Properties

        private readonly CustomerOrdersController controller = new CustomerOrdersController();
        private OrderPanelControl activePanel;
        private OrderPanelTableControl panelOrderPreview;
        private OrderPanelMessageControl panelOrderPlaced;
        private OrderPanelPaymentControl panelPayment;
        private OrderPanelCreditCardControl panelCreditCard;
        private OrderPanelMessageControl panelOrderPreparing;
        private CustomerChatForm customerChat;
        private EmployeeOrdersForm employeeOrdersForm;

        private Customer customer = AppController.Instance.Customer;
        private int currentTime = AppController.Instance.TimeAsInt();

        private EmployeeOrdersForm EmployeeOrdersForm
        {
            get
            {
                if (employeeOrdersForm == null)
                {
                    CreateEmployeeOrdersForm();
                    employeeOrdersForm.Show();
                }
                return employeeOrdersForm;
            }
            set { employeeOrdersForm = value; }
        }

        #endregion

        #region Constructor and Initialization

        public CustomerOrdersForm()
        {
            InitializeComponent();
            InitializeControls();
            PopulateMenuItems();
            activePanel = panelMenu;
            AppController.Instance.TimeChanged += Instance_TimeChanged;
        }

        private void InitializeControls()
        {
            // currentTime
            InitializeTimeLabel();

            // Buttons
            buttonOrderCancel.FlatAppearance.MouseDownBackColor = buttonOrderCancel.FlatAppearance.MouseOverBackColor;
            buttonNextStep.DefaultColor = ColorPicker.TurquoiseGreen;
            buttonNextStep.ForeColor = ColorPicker.Charcoal;
            buttonNextStep.TextLeft = "Συνέχεια";
            buttonNextStep.TextRight = "0.00 €";

            // Chat
            customerChat = new CustomerChatForm();
            customerChat.MessageSent += CustomerChat_MessageSent;
            customerChat.TopLevel = false;
            customerChat.Dock = DockStyle.Fill;
            panelChat.Controls.Add(customerChat);
            customerChat.BringToFront();
            customerChat.Show();
        }

        private void InitializeTimeLabel()
        {
            string formattedTime = $"{currentTime / 100:00}:{currentTime % 100:00}";
            labelTime.Text = formattedTime;
            AlignLabelToCenter(labelTime, panelTime);
        }

        private void InitializePanelOrderPlaced()
        {
            string orderPlacedMessage = "Παρακαλούμε περιμένετε μέχρι ο υπάλληλος" +
                                      "\nνα επιβεβαιώσει την παραγγελία σας";
            panelOrderPlaced = new OrderPanelMessageControl(string.Empty, orderPlacedMessage);
        }

        private void InitializePanelOrderPreparing()
        {
            string orderPreparingMessage = "Η παραγγελία σας αυτή τη στιγμή ετοιμάζεται." +
                                   "\nΕυχαριστούμε για την υπομονή σας!";
            panelOrderPreparing = new OrderPanelMessageControl(string.Empty, orderPreparingMessage);
        }

        #endregion

        #region Employee Interaction Methods

        private void CreateEmployeeOrdersForm()
        {
            employeeOrdersForm = new EmployeeOrdersForm(currentTime, customer.Name);
            employeeOrdersForm.MessageSent += EmployeeChat_MessageSent;
            employeeOrdersForm.OrderRejected += EmployeeOrdersForm_OrderRejected;
            employeeOrdersForm.OrderConfirmed += EmployeeOrdersForm_OrderConfirmed;
            employeeOrdersForm.FormClosed += EmployeeOrdersForm_FormClosed;
        }

        private void EmployeeOrdersForm_OrderConfirmed(object sender, EventArgs e)
        {
            controller.SetOrderStatus(OrderStatus.Confirmed);
            HidePanel(panelOrderPlaced);
            buttonNextStep.TextLeft = "Πληρωμή";
            buttonNextStep.Visible = true;
            buttonOrderCancel.Visible = true;
            panelPayment = new OrderPanelPaymentControl(customer.Balance + controller.GetTotalPrice());
            panelPayment.CreditCard_CheckedChanged += PanelPayment_CreditCard_CheckedChanged;
            ShowPanel(panelPayment);
        }

        private void EmployeeOrdersForm_OrderRejected(object sender, EventArgs e)
        {
            buttonOrderEdit_Click(sender, e);
        }

        private void EmployeeOrdersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            EmployeeOrdersForm.Dispose();
            EmployeeOrdersForm = null;
        }

        private void EmployeeChat_MessageSent(object sender, EventArgs e)
        {
            customerChat.ReceiveMessage(EmployeeOrdersForm.LastMessageSent);
        }

        private void CustomerChat_MessageSent(object sender, EventArgs e)
        {
            EmployeeOrdersForm.ReceiveMessage(customerChat.LastMessageSent);
        }

        #endregion

        #region Event Handlers

        private void MenuItemControl_QuantityChanged(object sender, EventArgs e)
        {
            MenuItemControl menuItemControl = (MenuItemControl)sender;
            controller.UpdateItemQuantity(menuItemControl.ItemName, menuItemControl.Quantity);
            decimal totalPrice = controller.GetTotalPrice();
            buttonNextStep.TextRight = $"{totalPrice} €";
            if (totalPrice == 0.00m)
            {
                buttonOrderCancel.Visible = false;
                buttonNextStep.Visible = false;
            }
            else
            {
                buttonOrderCancel.Visible = true;
                buttonNextStep.Visible = true;
                controller.SetOrderStatus(OrderStatus.Open);
            }
        }

        private void PanelCreditCard_PaymentSuccessful(object sender, EventArgs e)
        {
            timerPaymentSuccessful.Start();
        }

        private void PanelCreditCard_FieldsChanged(object sender, EventArgs e)
        {
            buttonNextStep.Enabled = panelCreditCard.FieldsAreFilled;
        }

        private void PanelPayment_CreditCard_CheckedChanged(object sender, EventArgs e)
        {
            buttonNextStep.TextLeft = ((RadioButton)sender).Checked ? "Πληρωμή" : "Ολοκλήρωση";
        }

        private void Instance_TimeChanged(object sender, EventArgs e)
        {
            currentTime = AppController.Instance.TimeAsInt();
            InitializeTimeLabel();
            if (activePanel == panelMenu)
            {
                PopulateMenuItems();
            }
        }

        #endregion

        #region Panel Display Methods

        private void PopulateMenuItems()
        {
            panelMenu.ClearItems();
            MenuItemType currentType = controller.GetMenuItem(0).Type;
            for (int i = 0; i < controller.GetMenuItemsCount(); i++)
            {
                MenuItem nextMenuItem = controller.GetMenuItem(i);

                // The first item is always a category
                if (i == 0)
                {
                    panelMenu.AddItem(new MenuCategoryControl(nextMenuItem.GetTypeStringValue(), nextMenuItem.GetStartTime(), nextMenuItem.GetEndTime()));
                }

                // Check if we need to insert new category item
                if (nextMenuItem.Type != currentType)
                {
                    panelMenu.AddItem(new MenuCategoryControl(nextMenuItem.GetTypeStringValue(), nextMenuItem.GetStartTime(), nextMenuItem.GetEndTime()));
                    currentType = nextMenuItem.Type;
                }

                int quantity = controller.GetItemQuantity(nextMenuItem.Name);
                MenuItemControl menuItemControl = new MenuItemControl(nextMenuItem, quantity);
                menuItemControl.QuantityChanged += MenuItemControl_QuantityChanged;
                if (!nextMenuItem.IsAvailable(currentTime))
                {
                    menuItemControl.Enabled = false;
                }
                panelMenu.AddItem(menuItemControl);
            }
        }

        private void CreateOrderPreview()
        {
            panelOrderPreview = new OrderPanelTableControl("Σύνοψη παραγγελίας");
            foreach (Control item in panelMenu.Items.OfType<MenuItemControl>())
            {
                MenuItemControl nextItem = (MenuItemControl)item;
                if (nextItem.Quantity > 0)
                {
                    MenuItemControl menuItemControl = new MenuItemControl(controller.GetMenuItemByName(nextItem.ItemName), nextItem.Quantity);
                    menuItemControl.QuantityChanged += MenuItemControl_QuantityChanged;
                    panelOrderPreview.AddItem(menuItemControl);
                }
            }
        }

        private void ShowPanel(OrderPanelControl panel)
        {
            panel.Dock = DockStyle.Top;
            panel.Visible = true;
            if (!panelOrder.Controls.Contains(panel))
            {
                panelOrder.Controls.Add(panel);
            }
            activePanel = panel;
        }

        private void HidePanel(OrderPanelControl panel)
        {
            panel.Visible = false;
        }

        private void DiscardPanel(OrderPanelControl panel)
        {
            panelOrder.Controls.Remove(panel);
            panel.Dispose();
        }

        #endregion

        #region Button Click Handlers

        private void buttonNextStep_Click(object sender, EventArgs e)
        {
            if (activePanel == panelMenu)
            {
                CreateOrderPreview();
                HidePanel(panelMenu);
                buttonOrderEdit.Visible = true;
                buttonNextStep.TextLeft = "Αποστολή";
                ShowPanel(panelOrderPreview);
            }
            else if (activePanel == panelOrderPreview)
            {
                InitializePanelOrderPlaced();
                controller.SetOrderStatus(OrderStatus.Placed);
                buttonNextStep.Visible = false;
                buttonOrderCancel.Visible = false;
                buttonOrderEdit.Visible = false;
                EmployeeOrdersForm.ReceiveOrder(panelOrderPreview.Items.OfType<MenuItemControl>());
                DiscardPanel(panelOrderPreview);
                ShowPanel(panelOrderPlaced);
            }
            else if (activePanel == panelPayment)
            {
                controller.SetPaymentMethod(panelPayment.PaymentMethod);
                controller.SetDeliveryMethod(panelPayment.DeliveryMethod);
                if (panelPayment.PaymentMethod == PaymentMethod.CreditCard)
                {
                    panelCreditCard = new OrderPanelCreditCardControl();
                    panelCreditCard.FieldsChanged += PanelCreditCard_FieldsChanged;
                    panelCreditCard.PaymentSuccessful += PanelCreditCard_PaymentSuccessful;
                    buttonNextStep.Enabled = panelCreditCard.FieldsAreFilled;
                    DiscardPanel(panelPayment);
                    ShowPanel(panelCreditCard);
                }
                else
                {
                    if (panelPayment.PaymentMethod == PaymentMethod.AddToAccount)
                    {
                        AppController.Instance.Customer.Balance += controller.GetTotalPrice();
                    }
                    InitializePanelOrderPreparing();
                    controller.SetOrderStatus(OrderStatus.Preparing);
                    buttonNextStep.Visible = false;
                    buttonOrderCancel.Visible = false;
                    DiscardPanel(panelPayment);
                    ShowPanel(panelOrderPreparing);
                    timerOrderPreparing.Start();
                }
            }
            else if (activePanel == panelCreditCard)
            {
                panelCreditCard.ExecutePayment();
                buttonNextStep.Enabled = false;
                buttonOrderCancel.Enabled = false;
            }
        }

        private void buttonOrderEdit_Click(object sender, EventArgs e)
        {
            PopulateMenuItems();
            DiscardPanel(activePanel);
            ShowPanel(panelMenu);
            buttonOrderEdit.Visible = false;
            if (employeeOrdersForm != null)
            {
                EmployeeOrdersForm.CancelOrder();
            }
        }

        private void buttonOrderCancel_Click(object sender, EventArgs e)
        {
            controller.CancelOrder();
            buttonNextStep.TextRight = $"{controller.GetTotalPrice()} €";
            if (activePanel != panelMenu)
            {
                DiscardPanel(activePanel);
            }
            buttonNextStep.TextLeft = "Συνέχεια";
            buttonNextStep.Enabled = true;
            buttonNextStep.Visible = false;
            buttonOrderCancel.Visible = false;
            buttonOrderEdit.Visible = false;
            PopulateMenuItems();
            ShowPanel(panelMenu);
            if (employeeOrdersForm != null)
            {
                EmployeeOrdersForm.CancelOrder();
            }
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            controller.NewOrder();
            buttonNextStep.TextLeft = "Συνέχεια";
            buttonNextStep.TextRight = $"{controller.GetTotalPrice()} €";
            buttonNextStep.Enabled = true;
            buttonOrderCancel.Enabled = true;
            buttonNewOrder.Visible = false;
            DiscardPanel(activePanel);
            PopulateMenuItems();
            ShowPanel(panelMenu);
        }

        #endregion

        #region Timer Tick Handlers

        private void timerOrderPreparing_Tick(object sender, EventArgs e)
        {
            timerOrderPreparing.Stop();
            if (controller.GetDeliveryMethod() == DeliveryMethod.TakeAway)
            {
                controller.SetOrderStatus(OrderStatus.Ready);
                panelOrderPreparing.Message = "Η παραγγελία σας είναι έτοιμη και μπορείτε να" +
                                            "\nπεράσετε από το εστιατόριο να την παραλάβετε!";
                panelOrderPreparing.PictureVisible = false;
                buttonNewOrder.Visible = true;
            }
            else
            {
                controller.SetOrderStatus(OrderStatus.Delivery);
                panelOrderPreparing.Message = "Η παραγγελία σας ετοιμάστηκε και" +
                                            "\nβρίσκεται σε διαδικασία παράδοσης!";
                timerOrderDelivering.Start();
            }
        }

        private void timerOrderDelivering_Tick(object sender, EventArgs e)
        {
            timerOrderDelivering.Stop();
            controller.SetOrderStatus(OrderStatus.Completed);
            panelOrderPreparing.Message = "Η παραγγελία σας έχει ολοκληρωθεί";
            panelOrderPreparing.PictureVisible = false;
            buttonNewOrder.Visible = true;
        }

        private void timerPaymentSuccessful_Tick(object sender, EventArgs e)
        {
            InitializePanelOrderPreparing();
            timerPaymentSuccessful.Stop();
            controller.SetOrderStatus(OrderStatus.Preparing);
            buttonNextStep.Visible = false;
            buttonOrderCancel.Visible = false;
            DiscardPanel(panelCreditCard);
            ShowPanel(panelOrderPreparing);
            timerOrderPreparing.Start();
        }

        #endregion
    }
}
