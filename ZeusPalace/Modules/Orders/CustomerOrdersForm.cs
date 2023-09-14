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
        private Color buttonNextStepDefaultBackColor;
        public CustomerOrdersForm()
        {
            InitializeComponent();
            buttonNextStepDefaultBackColor = buttonOrderNextStep.BackColor;
            foreach (Button btn in tableLayoutPanelOrderControls.Controls.OfType<Button>())
            {
                btn.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.MouseOverBackColor;
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
    }
}
