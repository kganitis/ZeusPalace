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
    public partial class EmployeeMessageControl : UserControl
    {
        public EmployeeMessageControl()
        {
            InitializeComponent();
        }

        public EmployeeMessageControl(string message) : this()
        {
            Message = message;
        }

        public string Message
        {
            get => labelMessage.Text;
            set => labelMessage.Text = value;
        }
    }
}
