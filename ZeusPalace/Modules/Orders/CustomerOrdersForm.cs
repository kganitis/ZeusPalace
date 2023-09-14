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
    public partial class CustomerOrdersForm : EmbeddedForm
    {
        private CustomerOrdersController controller = new CustomerOrdersController();
        private Color buttonNextStepDefaultBackColor;
        public CustomerOrdersForm()
        {
            InitializeComponent();
            buttonNextStepDefaultBackColor = buttonOrderNextStep.BackColor;
            foreach (Button btn in tableLayoutPanelOrderControls.Controls.OfType<Button>())
            {
                btn.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.MouseOverBackColor;
            }
            AlignLabelToCenter(labelTime, panelTime);
            System.Collections.IList menuItems = controller.Menu.MenuItems;
            for (int i = 0; i < menuItems.Count; i++)
            {
                MenuItem item = (MenuItem)menuItems[i];
            }
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

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
