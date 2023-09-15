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
        private readonly Color buttonNextStepDefaultBackColor;
        private Panel panelOrderPreview;
        public int Time { get; set; }

        public CustomerOrdersForm()
        {
            InitializeComponent();
            Time = 1559;

            // Manage controls properties
            string formattedTime = $"{Time / 100:00}:{Time % 100:00}";
            labelTime.Text = formattedTime;
            buttonNextStepDefaultBackColor = buttonOrderNextStep.BackColor;
            foreach (Button btn in tableLayoutPanelOrderControls.Controls.OfType<Button>())
            {
                btn.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.MouseOverBackColor;
            }
            AlignLabelToCenter(labelTime, panelTime);
            AlignLabelToCenter(labelOrderTitle, panelOrderTitle);
            
            PopulateMenuItems();
        }

        private void PopulateMenuItems()
        {
            // Define constants for layout
            const int startingPointX = 50;
            const int startingPointY = 20;
            const int distanceX = 460;
            const int distanceY = 35;
            const int marginY = distanceY;

            int row = 0;
            int col = 0;
            MenuItemType currentType = controller.Menu.GetMenuItem(0).Type;
            for (int i = 0; i < controller.Menu.GetMenuItemsCount(); i++)
            {
                Entities.Order.MenuItem nextMenuItem = controller.Menu.GetMenuItem(i);

                // The first control is always a category
                if (i == 0)
                {
                    AddControl(new MenuCategoryControl(nextMenuItem.GetTypeStringValue()));
                }

                // Check if we need to insert new category control
                if (nextMenuItem.Type != currentType)
                {
                    AddControl(new MenuCategoryControl(nextMenuItem.GetTypeStringValue()));
                    currentType = nextMenuItem.Type;
                }

                MenuItemControl menuItemControl = new MenuItemControl(nextMenuItem);
                menuItemControl.QuantityChanged += MenuItemControl_QuantityChanged;
                if (!nextMenuItem.IsAvailable(Time))
                {
                    menuItemControl.Enabled = false;
                }
                AddControl(menuItemControl);
            }

            Point GetNextPoint(Control control)
            {
                // Calculate the position based on row and column
                int nextPointX = startingPointX + distanceX * col;
                int nextPointY = startingPointY + distanceY * row;

                // Check if the control goes beyond the panel's height
                if (nextPointY + control.Height > panelMenu.Height - marginY)
                {
                    col++;
                    row = 0;
                    nextPointX = startingPointX + distanceX * col;
                    nextPointY = startingPointY + distanceY * row;
                }

                row++;

                return new Point(nextPointX, nextPointY);
            }

            void AddControl(Control control)
            {
                control.Location = GetNextPoint(control);
                panelMenu.Controls.Add(control);
            }
        }

        private Panel ClonePanel(Panel panel)
        {
            return new Panel
            {
                Dock = panel.Dock,
                Location = panel.Location,
                Size = panel.Size
            };
        }

        private MenuItemControl CloneMenuItemControl(MenuItemControl menuItemControl)
        {
            return new MenuItemControl(controller.Menu.GetMenuItemByName(menuItemControl.ItemName), menuItemControl.Quantity);
        }

        private void PopulateOrderPreviewItems()
        {
            panelOrderPreview = ClonePanel(panelMenu);

            // Define constants for layout
            const int startingPointX = 50;
            const int startingPointY = 20;
            const int distanceX = 460;
            const int distanceY = 35;
            const int marginY = distanceY;

            int row = 0;
            int col = 0;
            foreach (Control control in panelMenu.Controls.OfType<MenuItemControl>())
            {
                if (((MenuItemControl)control).Quantity > 0)
                {
                    MenuItemControl menuItemControl = CloneMenuItemControl((MenuItemControl)control);
                    menuItemControl.QuantityChanged += MenuItemControl_QuantityChanged;
                    menuItemControl.Location = GetNextPoint(menuItemControl);
                    panelOrderPreview.Controls.Add(menuItemControl);
                }
            }

            Point GetNextPoint(Control control)
            {
                // Calculate the position based on row and column
                int nextPointX = startingPointX + distanceX * col;
                int nextPointY = startingPointY + distanceY * row;

                // Check if the control goes beyond the panel's height
                if (nextPointY + control.Height > panelOrderPreview.Height - marginY)
                {
                    col++;
                    row = 0;
                    nextPointX = startingPointX + distanceX * col;
                    nextPointY = startingPointY + distanceY * row;
                }

                row++;

                return new Point(nextPointX, nextPointY);
            }
        }

        private void ShowOrderPreview()
        {
            PopulateOrderPreviewItems();
            panelOrder.Controls.Add(panelOrderPreview);
            panelOrderPreview.BringToFront();
            labelOrderTitle.Text = "Σύνοψη παραγγελίας";
            AlignLabelToCenter(labelOrderTitle, panelOrderTitle);
        }

        private void MenuItemControl_QuantityChanged(object sender, EventArgs e)
        {
            MenuItemControl menuItemControl = (MenuItemControl)sender;
            controller.UpdateItemQuantity(menuItemControl.ItemName, menuItemControl.Quantity);
            buttonTotalPrice.Text = controller.Order.TotalPrice.ToString() + " €";
        }

        private void buttonNextStep_MouseEnter(object sender, EventArgs e)
        {
            buttonOrderNextStep.BackColor = buttonOrderNextStep.FlatAppearance.MouseOverBackColor;
            buttonTotalPrice.BackColor = buttonTotalPrice.FlatAppearance.MouseOverBackColor;
        }

        private void buttonNextStep_MouseLeave(object sender, EventArgs e)
        {
            buttonOrderNextStep.BackColor = buttonNextStepDefaultBackColor;
            buttonTotalPrice.BackColor = buttonNextStepDefaultBackColor;
        }

        private void buttonOrderNextStep_Click(object sender, EventArgs e)
        {
            ShowOrderPreview();
        }

        private void buttonTotalPrice_Click(object sender, EventArgs e)
        {
            ShowOrderPreview();
        }
    }
}
