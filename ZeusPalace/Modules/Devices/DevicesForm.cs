using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
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
            
        }

        SoundPlayer MyPlayer = new SoundPlayer("..\\..\\Resources\\harp_music.wav");

        //
        //Lights Controls
        //
        Lights lights = new Lights();

        private void lightSwitchBtn_Click(object sender, EventArgs e)
        {
            if (lights.GetStatus() == 1) 
            {
                TvpictureBox.BackgroundImage = (myTv.GetStatus() == 1) 
                    ? Properties.Resources.Etv_on_lightsOFF : Properties.Resources.Etv_off_lightsOFF;

                MusciBox.BackgroundImage = (myHarp.GetStatus() == 1) 
                    ? Properties.Resources.harp_on_lightsOFF : Properties.Resources.harp_off_lightsOFF;

                lights.TurnOff();
                lightSwitchBtn.BackgroundImage = Properties.Resources.lights_off;
                backPanel.BackgroundImage = Properties.Resources.pre_ancient_suite_lights_off;
            }
            else
            {
                TvpictureBox.BackgroundImage = (myTv.GetStatus() == 1) 
                    ? Properties.Resources.Etv_on_lightsON : Properties.Resources.Etv_off_lightsON;

                MusciBox.BackgroundImage = (myHarp.GetStatus() == 1) 
                    ? Properties.Resources.harp_on_lightsON : Properties.Resources.harp_off_lightsON;
                
                lights.TurnOn();
                lightSwitchBtn.BackgroundImage = Properties.Resources.lights_on;
                backPanel.BackgroundImage = Properties.Resources.pre_ancient_suite;
            }
        }

        //
        //Tv Controls
        //
        Tv myTv = new Tv();

        private void btn_ON_OFF_Click(object sender, EventArgs e)
        {
            if (myTv.GetStatus() == 0)
            {
                TvpictureBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.Etv_on_lightsON : Properties.Resources.Etv_on_lightsOFF;

                myTv.SwitchON();
                btn_ON_OFF.BackgroundImage = Properties.Resources.tvremote_on;
            }
            else 
            {
                TvpictureBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.Etv_off_lightsON : Properties.Resources.Etv_off_lightsOFF;

                myTv.SwitchOFF();
                btn_ON_OFF.BackgroundImage = Properties.Resources.tvremote_off;
            }
        }

        //
        //Music Controls
        //

        Harp myHarp = new Harp();

        private void BtnPlayStop_Click(object sender, EventArgs e)
        {
            if (myHarp.GetStatus() == 0)
            {
                MusciBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.harp_on_lightsON : Properties.Resources.harp_on_lightsOFF;

                myHarp.Play();
                MyPlayer.PlayLooping();
                BtnPlayStop.BackgroundImage = Properties.Resources.stop;
            }
            else
            {
                MusciBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.harp_off_lightsON : Properties.Resources.harp_off_lightsOFF;

                myHarp.Stop();
                MyPlayer.Stop();
                BtnPlayStop.BackgroundImage = Properties.Resources.play;
            }
        }

        //
        //Humidity Controls
        //
        private void trackBarHumidity_Scroll(object sender, EventArgs e)
        {
            if (trackBarHumidity.Value > 0 && trackBarHumidity.Value <= 25)
            {
                humidifierLight.BackColor = Color.Crimson;
                WarningLabel.ForeColor = Color.Crimson;
                WarningLabel.Text = "Κίνδυνος! Πολύ χαμηλή υγρασία!";
            }
            else if (trackBarHumidity.Value > 25 && trackBarHumidity.Value <= 40)
            {
                humidifierLight.BackColor = Color.Yellow;
                WarningLabel.ForeColor = Color.Orange;
                WarningLabel.Text = "Προσοχή! Χαμηλή υγρασία!";
            }
            else if (trackBarHumidity.Value > 40 && trackBarHumidity.Value <= 70)
            {
                humidifierLight.BackColor = Color.Lime;
                WarningLabel.Text = "";
            }
            else if (trackBarHumidity.Value > 70 && trackBarHumidity.Value <= 80)
            {
                humidifierLight.BackColor = Color.Yellow;
                WarningLabel.ForeColor = Color.Orange;
                WarningLabel.Text = "Προσοχή! Υψηλή υγρασία!";
            }
            else
            {
                humidifierLight.BackColor = Color.Crimson;
                WarningLabel.ForeColor = Color.Crimson;
                WarningLabel.Text = "Κίνδυνος! Πολύ υψηλή υγρασία!";

            }
            HumidityLabel.Text = "Υγρασία: " + trackBarHumidity.Value+"%";
        }
        


    }

}
