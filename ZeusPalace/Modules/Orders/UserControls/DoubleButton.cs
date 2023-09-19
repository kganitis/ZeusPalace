using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders.UserControls
{
    public partial class DoubleButton : UserControl
    {
        private Color defaultBackColor;
        public DoubleButton()
        {
            InitializeComponent();
        }

        public DoubleButton(string label1Text, string label2Text) : this()
        {
            Label1 = CreateLabel(label1Text);
            Label2 = CreateLabel(label2Text);
        }

        public Color DefaultColor
        {
            get { return defaultBackColor; }
            set
            {
                BackColor = value;
                defaultBackColor = value;
            }
        }

        public string TextLeft
        {
            get { return Label1.Text; }
            set { Label1 = CreateLabel(value); }
        }

        public string TextRight
        {
            get { return Label2.Text; }
            set { Label2 = CreateLabel(value); }
        }

        private Label Label1
        {
            get
            {
                return (Label)tableLayoutPanel1.GetControlFromPosition(0, 0);
            }
            set
            {
                tableLayoutPanel1.Controls.Remove(Label1);
                tableLayoutPanel1.Controls.Add(value, 0, 0);
            }
        }

        private Label Label2
        {
            get
            {
                return (Label)tableLayoutPanel1.GetControlFromPosition(1, 0);
            }
            set
            {
                tableLayoutPanel1.Controls.Remove(Label2);
                tableLayoutPanel1.Controls.Add(value, 1, 0);
            }
        }

        private Label CreateLabel(string label)
        {
            Label newLabel = new Label
            {
                Anchor = AnchorStyles.None,
                AutoSize = true,
                Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                Text = label
            };
            newLabel.Click += (sender, e) => OnClick(e);
            newLabel.MouseEnter += (sender, e) => OnMouseEnter(e);
            newLabel.MouseLeave += (sender, e) => OnMouseLeave(e);
            return newLabel;
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void tableLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void tableLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void DoubleButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = ColorPicker.GetShade(defaultBackColor, 10);
        }

        private void DoubleButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = defaultBackColor;
        }
    }
}
