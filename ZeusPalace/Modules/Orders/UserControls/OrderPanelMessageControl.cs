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
        }

        public string Message
        {
            get { return labelMessage.Text;}
            set
            {
                panelMain.Controls.Remove(labelMessage);
                labelMessage = new Label
                {
                    AutoSize = true,
                    Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0),
                    Location = new Point(422, 120),
                    Text = value,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                panelMain.Controls.Add(labelMessage);
                labelMessage.Location = new Point((Width - labelMessage.Width) / 2, labelMessage.Location.Y);
            }
        }

        public bool PictureVisible
        {
            set { pictureBox1.Visible = value; }
        }

        public Image Image
        {
            set { pictureBox1.Image = value; }
        }
    }
}
