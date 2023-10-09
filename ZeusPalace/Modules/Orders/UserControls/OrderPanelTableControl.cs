using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders.UserControls
{
    public class OrderPanelTableControl : OrderPanelControl
    {
        private void InitializeComponent()
        {
            this.tableItems = new System.Windows.Forms.TableLayoutPanel();
            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableItems);
            // 
            // tableItems
            // 
            this.tableItems.ColumnCount = 3;
            this.tableItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableItems.Location = new System.Drawing.Point(50, 0);
            this.tableItems.Name = "tableItems";
            this.tableItems.RowCount = 13;
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableItems.Size = new System.Drawing.Size(860, 455);
            this.tableItems.TabIndex = 0;
            // 
            // OrderPanelTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "OrderPanelTableControl";
            this.panelMain.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        private TableLayoutPanel tableItems;
        public TableLayoutControlCollection Items => tableItems.Controls;
        private int nextAvailableRow = 0;
        private int nextAvailableCol = 0;

        public OrderPanelTableControl()
        {
            InitializeComponent();
        }

        public OrderPanelTableControl(string title) : this()
        {
            Title = title;
        }

        public void AddItem(Control control)
        {
            if (nextAvailableRow >= tableItems.RowCount)
            {
                nextAvailableCol = 2;
                nextAvailableRow = 0;
            }
            SuspendLayout();
            tableItems.Controls.Add(control, nextAvailableCol, nextAvailableRow);
            ResumeLayout();
            nextAvailableRow++;
        }

        public void AddItems(List<Control> list)
        {

        }

        public void AddItemAt(Control control, int col, int row)
        {
            if (col < tableItems.ColumnCount && col >= 0 && row < tableItems.RowCount && row >= 0)
            {
                Items.Add(control, col, row);
            }
        }

        public void ClearItems()
        {
            Items.Clear();
            nextAvailableCol = 0;
            nextAvailableRow = 0;
        }
    }
}
