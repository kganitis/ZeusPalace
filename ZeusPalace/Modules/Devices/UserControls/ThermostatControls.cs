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
            temperature_label.Text = "22,0";
        }

        public int Quantity
        {
            get { return int.Parse(temperature_label.Text); }
            set
            {
                if (Quantity != value)
                {
                    temperature_label.Text = value.ToString();
                }
            }
        }

        private void btn_icr_temp_Click(object sender, EventArgs e)
        {
            Quantity++;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Quantity--;
        }
    }
}
