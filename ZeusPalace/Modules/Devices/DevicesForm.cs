﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeusPalace.Modules.Devices.UserControls;

namespace ZeusPalace.Modules.Devices
{
    public partial class DevicesForm : EmbeddedForm
    {
        public DevicesForm()
        {
            InitializeComponent();
            /*ThermostatControls thermostat = new ThermostatControls();
            panel1.Controls.Add(thermostat);*/
            MusicControls music = new MusicControls();
            panel1.Controls.Add(music);
        }
       

    }

}
