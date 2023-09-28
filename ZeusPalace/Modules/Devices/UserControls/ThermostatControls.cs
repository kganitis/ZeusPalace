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
    public partial class ThermostatControls : UserControl
    {
        public ThermostatControls()
        {
            InitializeComponent();
            temperature_label.Text = "22,0 C";
        }

        public double Quantity = 22;
        


        private void btn_decr_temp_Click(object sender, EventArgs e)
        {
            Quantity -= 0.5;
            temperature_label.Text = Quantity.ToString()+" C";
        }

        private void btn_icr_temp_Click(object sender, EventArgs e)
        {
            Quantity += 0.5;
            temperature_label.Text = Quantity.ToString() + " C";
        }
    }
}
