using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders
{
    public partial class EmployeeChatForm : ZeusPalace.Modules.Orders.ChatForm
    {
        public EmployeeChatForm()
        {
            InitializeComponent();
        }

        public EmployeeChatForm(string customerName) : this()
        {
            labelUsername.Text = customerName;
        }
    }
}
