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
using ZeusPalace.Entities.Order;
using ZeusPalace.Modules.Orders.UserControls;
using MenuItem = ZeusPalace.Entities.Order.MenuItem;

namespace ZeusPalace.Modules.Orders
{
    public partial class CustomerOrdersForm : EmbeddedForm
    {
        private readonly CustomerOrdersController controller = new CustomerOrdersController();
        private OrderPanelControl activePanel;
        private OrderPanelTableControl panelOrderPreview;
        private OrderPanelMessageControl panelOrderPlaced;
        private OrderPanelPaymentControl panelPayment;

        public int Time { get; set; }

        public CustomerOrdersForm()
        {
            InitializeComponent();
            InitializeControls();
            PopulateMenuItems();
            activePanel = panelMenu;
        }

        private void InitializeControls()
        {
            // Time
            Time = 1559;
            string formattedTime = $"{Time / 100:00}:{Time % 100:00}";
            labelTime.Text = formattedTime;
            AlignLabelToCenter(labelTime, panelTime);

            string orderPlacedMessage = "Παρακαλούμε περιμένετε μέχρι ο υπάλληλος\nνα επιβεβαιώσει την παραγγελία σας";
            panelOrderPlaced = new OrderPanelMessageControl(string.Empty, orderPlacedMessage);
            panelPayment = new OrderPanelPaymentControl();

            // Buttons
            foreach (Button btn in tableLayoutPanelOrderControls.Controls.OfType<Button>())
            {
                btn.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.MouseOverBackColor;
            }
            //
            // buttonNextStep
            //
            buttonNextStep.DefaultColor = ColorPicker.TurquoiseGreen;
            buttonNextStep.ForeColor = ColorPicker.Charcoal;
            buttonNextStep.TextLeft = "Συνέχεια";
            buttonNextStep.TextRight = "0.00 €";
        }

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
                    panelMenu.AddItem(new MenuCategoryControl(nextMenuItem.GetTypeStringValue()));
                }

                // Check if we need to insert new category item
                if (nextMenuItem.Type != currentType)
                {
                    panelMenu.AddItem(new MenuCategoryControl(nextMenuItem.GetTypeStringValue()));
                    currentType = nextMenuItem.Type;
                }

                int quantity = controller.GetItemQuantity(nextMenuItem.Name);
                MenuItemControl menuItemControl = new MenuItemControl(nextMenuItem, quantity);
                menuItemControl.QuantityChanged += MenuItemControl_QuantityChanged;
                if (!nextMenuItem.IsAvailable(Time))
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
                controller.SetOrderStatus(OrderStatus.Placed);
                buttonNextStep.Visible = false;
                buttonOrderCancel.Visible = false;
                buttonOrderEdit.Visible = false;
                DiscardPanel(panelOrderPreview);
                ShowPanel(panelOrderPlaced);
                timerOrderConfirmation.Start();
            }
        }

        private void buttonOrderEdit_Click(object sender, EventArgs e)
        {
            PopulateMenuItems();
            DiscardPanel(activePanel);
            ShowPanel(panelMenu);
            buttonOrderEdit.Visible = false;
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
            buttonNextStep.Visible = false;
            buttonOrderCancel.Visible = false;
            buttonOrderEdit.Visible = false;
            PopulateMenuItems();
            ShowPanel(panelMenu);
        }

        private void timerOrderConfirmation_Tick(object sender, EventArgs e)
        {
            timerOrderConfirmation.Stop();
            HidePanel(panelOrderPlaced);
            buttonNextStep.Visible = true;
            buttonOrderCancel.Visible = true;
            ShowPanel(panelPayment);
        }
    }
}
