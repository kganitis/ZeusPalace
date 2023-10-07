using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeusPalace.Entities.Devices;

namespace ZeusPalace.Modules.Devices.UserControls
{
    public partial class ThermostatControls1 : UserControl
    {
        public ThermostatControls1()
        {
            InitializeComponent();
            temperature_label.Text = "22,0 C";
        }

        Thermostat myThermostat = new Thermostat(22);
        //string currentFeeling = myThermostat.Feeling;

        private void btn_decr_temp_Click(object sender, EventArgs e)
        {
            if (myThermostat.Temperature <= 12)
            {
                myThermostat.Temperature = 12;
            }
            else
            {
                myThermostat.Temperature -= 0.5;
            }
            UpdateColor();
            temperature_label.Text = myThermostat.Temperature.ToString() + " C";
        }

        private void btn_icr_temp_Click(object sender, EventArgs e)
        {
            if (myThermostat.Temperature >= 32)
            {
                myThermostat.Temperature = 32;
            }
            else
            {
                myThermostat.Temperature += 0.5;
            }
            UpdateColor();
            temperature_label.Text = myThermostat.Temperature.ToString() + " C";
        }

        private void UpdateColor()//Update color of thermostat
        {
            if(myThermostat.Feeling.Equals("VeryCold"))
                tableLayoutPanel1.BackColor = Color.LightSkyBlue;
            else if(myThermostat.Feeling.Equals("Cold"))
                tableLayoutPanel1.BackColor = Color.DeepSkyBlue;
            else if (myThermostat.Feeling.Equals("Normal"))
                tableLayoutPanel1.BackColor = Color.OliveDrab;
            else if (myThermostat.Feeling.Equals("Hot"))
                tableLayoutPanel1.BackColor = Color.Orange;
            else
                tableLayoutPanel1.BackColor = Color.OrangeRed;
        }

        
    }
}
