using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders.UserControls
{
    public partial class OrderPanelControl : UserControl
    {
        public OrderPanelControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }

        protected void AlignLabelToCenter(Label label, Panel parentPanel)
        {
            int labelX = (parentPanel.Width - label.Width) / 2;
            int labelY = (parentPanel.Height - label.Height) / 2;
            label.Location = new Point(labelX, labelY);
        }

        protected void AlignLabelToCenter(Label label)
        {
            int labelX = (Width - label.Width) / 2;
            int labelY = (Height - label.Height) / 2;
            label.Location = new Point(labelX, labelY);
        }

        private void labelTitle_TextChanged(object sender, EventArgs e)
        {
            AlignLabelToCenter(labelTitle, panelTitle);
        }
    }
}
