using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders.UserControls
{
    public partial class OrderPanelControl : UserControl
    {
        private int nextAvailableRow = 0;
        private int nextAvailableCol = 0;

        public OrderPanelControl()
        {
            InitializeComponent();
            labelTitle.Text = "Μενού ημέρας";
        }

        public OrderPanelControl(string title) : this()
        {
            labelTitle.Text = title;
        }

        public OrderPanelControl(string title, string message) : this(title)
        {
            labelMessage.Text = message;
            labelMessage.Visible = true;
            Table = false;
        }

        public bool Table
        {
            get
            {
                return tableItems.Visible;
            }
            set
            {
                tableItems.Visible = value;
            }
        }

        public void AddControl(Control control)
        {
            if (nextAvailableRow >= tableItems.RowCount)
            {
                nextAvailableCol = 2;
                nextAvailableRow = 0;
            }
            tableItems.Controls.Add(control, nextAvailableCol, nextAvailableRow);
            nextAvailableRow++;
        }

        public void AddControlAt(Control control, int col, int row)
        {
            if (col >= tableItems.ColumnCount || col < 0 || row >= tableItems.RowCount || row < 0)
            {
                return;
            }
            else
            {
                tableItems.Controls.Add(control, col, row);
            }
        }

        public void ClearControls()
        {
            tableItems.Controls.Clear();
            nextAvailableCol = 0;
            nextAvailableRow = 0;
        }

        public TableLayoutControlCollection Items => tableItems.Controls;

        public void AlignLabelToCenter(Label label, Panel parentPanel)
        {
            int labelX = (parentPanel.Width - label.Width) / 2;
            int labelY = (parentPanel.Height - label.Height) / 2;
            label.Location = new Point(labelX, labelY);
        }

        public void AlignLabelToCenter(Label label)
        {
            int labelX = (Width - label.Width) / 2;
            int labelY = (Height - label.Height) / 2;
            label.Location = new Point(labelX, labelY);
        }

        private void labelTitle_TextChanged(object sender, EventArgs e)
        {
            AlignLabelToCenter(labelTitle, panelTitle);
        }

        private void labelMessage_TextChanged(object sender, EventArgs e)
        {
            labelMessage.Location = new Point((Width - labelMessage.Width) / 2, labelMessage.Location.Y);
        }
    }
}
