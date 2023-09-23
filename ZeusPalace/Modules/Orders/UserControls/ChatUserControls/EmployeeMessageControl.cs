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
    public partial class EmployeeMessageControl : UserControl
    {
        public EmployeeMessageControl()
        {
            InitializeComponent();
            Dock = DockStyle.Bottom;
        }

        public EmployeeMessageControl(string message) : this()
        {
            int bottomMargin = Height - pictureBoxEmployee.Height;
            Label labelMessage = new Label
            {
                AutoSize = true,
                BackColor = Color.Honeydew,
                Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
                Location = new Point(0, 0),
                MaximumSize = new Size(200, 400),
                Text = message,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Left
            };
            panelMessage.Controls.Add(labelMessage);
            panelMessage.Height = labelMessage.Height;
            Height = Math.Max(panelMessage.Height, pictureBoxEmployee.Height) + bottomMargin;
        }
    }
}
