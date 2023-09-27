using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders.UserControls.ChatUserControls
{
    public partial class CustomerMessageControl : UserControl
    {
        public CustomerMessageControl()
        {
            InitializeComponent();
            Dock = DockStyle.Bottom;
        }

        public CustomerMessageControl(string message) : this()
        {
            int bottomMargin = Height - panelMessage.Height;
            Label labelMessage = new Label
            {
                AutoSize = true,
                BackColor = Color.Linen,
                Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(80, 0),
                MaximumSize = new Size(200, 300),
                Text = message,
                TextAlign = ContentAlignment.MiddleRight,
                Dock = DockStyle.Right
            };
            panelMessage.Controls.Add(labelMessage);
            panelMessage.Height = labelMessage.Height;
            Height = panelMessage.Height + bottomMargin;
        }
    }
}
