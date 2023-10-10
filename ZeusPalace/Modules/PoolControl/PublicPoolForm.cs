using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZeusPalace.Modules.PoolControl
{
    public partial class PublicPoolForm : PoolForm
    {
        public PublicPoolForm()
        {
            InitializeComponent();

            if (AppController.Instance.User.Role == UserRole.Customer)
            {
                foreach (Control control in Controls)
                {
                    if (control != null)
                    {
                        control.Enabled = false;
                    }
                }
            }
        }
    }
}
