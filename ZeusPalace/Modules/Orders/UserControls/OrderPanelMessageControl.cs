using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders.UserControls
{
    public partial class OrderPanelMessageControl : OrderPanelControl
    {
        public OrderPanelMessageControl()
        {
            InitializeComponent();
        }

        public OrderPanelMessageControl(string title, string message) : this()
        {
            Title = title;
            Message = message;
            labelMessage_TextChanged(this, new EventArgs());
        }

        public string Message
        {
            get { return labelMessage.Text;}
            set { labelMessage.Text = value; }
        }

        public bool PictureVisible
        {
            set { pictureBox1.Visible = value; }
        }

        public Image Image
        {
            set { pictureBox1.Image = value; }
        }

        private void labelMessage_TextChanged(object sender, EventArgs e)
        {
            labelMessage.Location = new Point((Width - labelMessage.Width) / 2, labelMessage.Location.Y);
        }
    }
}
