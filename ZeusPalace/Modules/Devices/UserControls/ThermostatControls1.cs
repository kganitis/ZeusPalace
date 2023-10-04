using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Devices.UserControls
{
    public partial class ThermostatControls1 : UserControl
    {
        public ThermostatControls1()
        {
            InitializeComponent();
            temperature_label.Text = "22,0 C";
        }

        public double Quantity = 22;
        


        private void btn_decr_temp_Click(object sender, EventArgs e)
        {
            if (Quantity <= 16)
            {
                Quantity = 16;
            }
            else
            {
                Quantity -= 0.5;
            }
            temperature_label.Text = Quantity.ToString() + " C";
        }

        private void btn_icr_temp_Click(object sender, EventArgs e)
        {
            if (Quantity >= 30)
            {
                Quantity = 30;
            }
            else
            {
                Quantity += 0.5;
            }
            temperature_label.Text = Quantity.ToString() + " C";
        }
    }
}
