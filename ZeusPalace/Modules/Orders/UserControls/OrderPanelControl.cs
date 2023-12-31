﻿using System;
using System.Drawing;
using System.Windows.Forms;
using ZeusPalace.Properties;

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
            set 
            {
                labelTitle.Text = value;
                AlignLabelToCenter(labelTitle, panelTitle);
            }
        }

        public void PaintBackground()
        {
            BackgroundImage = Resources.background;
        }

        public void RemoveBackground()
        {
            BackgroundImage = null;
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
