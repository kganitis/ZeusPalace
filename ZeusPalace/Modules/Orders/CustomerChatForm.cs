using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders
{
    public partial class CustomerChatForm : ZeusPalace.Modules.Orders.ChatForm
    {
        public CustomerChatForm()
        {
            InitializeComponent();
            labelUsername.Text = AppController.Instance.Employee.Name;
            pictureBoxEmployee.Image = AppController.Instance.Employee.Image;
        }

        public CustomerChatForm(string employeeName) : this()
        {
            labelUsername.Text = employeeName;
        }
    }
}
