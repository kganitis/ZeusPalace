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

namespace ZeusPalace.Modules.Orders
{
    public partial class CustomerOrdersForm : EmbeddedForm
    {
        private readonly CustomerOrdersController controller = new CustomerOrdersController();
        private OrderPanelControl panelOrderPreview;
        private OrderPanelControl panelOrderPlaced;
        OrderPanelControl activePanel;

        public int Time { get; set; }

        public CustomerOrdersForm()
        {
            InitializeComponent();
            Time = 1559;
            InitializeControls();
            PopulateMenuItems();
            activePanel = panelMenu;
        }

        private void InitializeControls()
        {
            string formattedTime = $"{Time / 100:00}:{Time % 100:00}";
            labelTime.Text = formattedTime;

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
            buttonNextStep.UpdateTextLeft("Συνέχεια");
            buttonNextStep.UpdateTextRight("0.00 €");

            
            
            AlignLabelToCenter(labelTime, panelTime);
        }

        private void PopulateMenuItems()
        {
            MenuItemType currentType = controller.GetMenuItem(0).Type;
            for (int i = 0; i < controller.GetMenuItemsCount(); i++)
            {
                Entities.Order.MenuItem nextMenuItem = controller.GetMenuItem(i);

                // The first item is always a category
                if (i == 0)
                {
                    panelMenu.AddControl(new MenuCategoryControl(nextMenuItem.GetTypeStringValue()));
                }

                // Check if we need to insert new category item
                if (nextMenuItem.Type != currentType)
                {
                    panelMenu.AddControl(new MenuCategoryControl(nextMenuItem.GetTypeStringValue()));
                    currentType = nextMenuItem.Type;
                }

                MenuItemControl menuItemControl = new MenuItemControl(nextMenuItem);
                menuItemControl.QuantityChanged += MenuItemControl_QuantityChanged;
                if (!nextMenuItem.IsAvailable(Time))
                {
                    menuItemControl.Enabled = false;
                }
                panelMenu.AddControl(menuItemControl);
            }
        }

        private void PrepareOrderPreview()
        {
            panelOrderPreview = new OrderPanelControl("Σύνοψη παραγγελίας");
            foreach (Control item in panelMenu.Items.OfType<MenuItemControl>())
            {
                MenuItemControl nextItem = (MenuItemControl)item;
                if (nextItem.Quantity > 0)
                {
                    MenuItemControl menuItemControl = new MenuItemControl(controller.GetMenuItemByName(nextItem.ItemName), nextItem.Quantity);
                    menuItemControl.QuantityChanged += MenuItemControl_QuantityChanged;
                    panelOrderPreview.AddControl(menuItemControl);
                }
            }
        }

        private void MenuItemControl_QuantityChanged(object sender, EventArgs e)
        {
            MenuItemControl menuItemControl = (MenuItemControl)sender;
            controller.UpdateItemQuantity(menuItemControl.ItemName, menuItemControl.Quantity);
            decimal totalPrice = controller.GetTotalPrice();
            buttonNextStep.UpdateTextRight($"{totalPrice} €");
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
                PrepareOrderPreview();
                HidePanel(panelMenu);
                buttonOrderEdit.Visible = true;
                ShowPanel(panelOrderPreview);
            }
            else if (activePanel == panelOrderPreview)
            {
                controller.SetOrderStatus(OrderStatus.Placed);
                string orderPlacedMessage = "Παρακαλούμε περιμένετε μέχρι ο υπάλληλος\nνα επιβεβαιώσει την παραγγελία σας";
                panelOrderPlaced = new OrderPanelControl("", orderPlacedMessage);
                buttonNextStep.Visible = false;
                buttonOrderEdit.Visible = false;
                HidePanel(panelOrderPreview);
                ShowPanel(panelOrderPlaced);
            }
        }

        private void buttonOrderEdit_Click(object sender, EventArgs e)
        {
            DiscardPanel(activePanel);
            ShowPanel(panelMenu);
            buttonOrderEdit.Visible = false;
        }

        private void buttonOrderCancel_Click(object sender, EventArgs e)
        {
            controller.CancelOrder();
            buttonNextStep.UpdateTextRight($"{controller.GetTotalPrice()} €");
            if (activePanel != panelMenu)
            {
                DiscardPanel(activePanel);
            }
            panelMenu.ClearControls();
            buttonNextStep.Visible = false;
            buttonOrderCancel.Visible = false;
            buttonOrderEdit.Visible = false;
            PopulateMenuItems();
            ShowPanel(panelMenu);
        }
    }
}
