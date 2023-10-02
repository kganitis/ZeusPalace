﻿using System;
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
            labelUsername.Text = "Περσεφόνη";
        }

        public CustomerChatForm(string employeeName) : this()
        {
            labelUsername.Text = employeeName;
        }
    }
}
