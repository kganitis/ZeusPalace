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
using ZeusPalace.Modules.Devices.UserControls;

namespace ZeusPalace.Modules.Devices
{
    public partial class DevicesForm : EmbeddedForm
    {
        public DevicesForm()
        {
            InitializeComponent();
            /*ThermostatControls thermostat = new ThermostatControls();
            backPanel.Controls.Add(thermostat);
            MusicControls music = new MusicControls();
            backPanel.Controls.Add(music);
            TvControls tvControls = new TvControls();
            backPanel.Controls.Add(tvControls);
            LocksControls locks = new LocksControls();
            backPanel.Controls.Add(locks);*/
        }

        //
        //Lights Controls
        //
        Lights lights = new Lights();

        private void lightSwitchBtn_Click(object sender, EventArgs e)
        {
            if (lights.GetStatus() == 1) 
            {
                lights.TurnOff();
                lightBulbBox.BackgroundImage = Properties.Resources.lightBulb_off;
                lightSwitchBtn.BackgroundImage = Properties.Resources.lights_off;
                backPanel.BackgroundImage = Properties.Resources.ancient_suite_dark;
            }
            else
            {
                lights.TurnOn();
                lightBulbBox.BackgroundImage = Properties.Resources.lightBulb_on;
                lightSwitchBtn.BackgroundImage = Properties.Resources.lights_on;
                backPanel.BackgroundImage = Properties.Resources.ancient_suite;
            }
        }//lightSwitchBtn_Click


    }

}
