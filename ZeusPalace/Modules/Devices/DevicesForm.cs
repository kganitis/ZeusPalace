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

                DoorPictureBox.BackgroundImage = (myLocks.Status == 1)
                    ? Properties.Resources.door_shut_lightsOFF : Properties.Resources.door_open_lightsOFF;

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

                DoorPictureBox.BackgroundImage = (myLocks.Status == 1)
                    ? Properties.Resources.door_shut_lightsON : Properties.Resources.door_open_lightsON;

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
                btn_ON_OFF.BackgroundImage = Properties.Resources.TVremoteON;
            }
            else 
            {
                TvpictureBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.Etv_off_lightsON : Properties.Resources.Etv_off_lightsOFF;

                myTv.SwitchOFF();
                btn_ON_OFF.BackgroundImage = Properties.Resources.TVremoteOFF;
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
            if (trackBarHumidity.Value >= 0 && trackBarHumidity.Value <= 25)
            {
                humidifierLight.BackColor = Color.OrangeRed;
                HumWarningLabel.ForeColor = Color.OrangeRed;
                HumWarningLabel.Text = "Πολύ χαμηλή υγρασία!";
            }
            else if (trackBarHumidity.Value > 25 && trackBarHumidity.Value <= 40)
            {
                humidifierLight.BackColor = Color.Orange;
                HumWarningLabel.ForeColor = Color.Orange;
                HumWarningLabel.Text = "Χαμηλή υγρασία!";
            }
            else if (trackBarHumidity.Value > 40 && trackBarHumidity.Value <= 70)
            {
                humidifierLight.BackColor = Color.Lime;
                HumWarningLabel.Text = "";
            }
            else if (trackBarHumidity.Value > 70 && trackBarHumidity.Value <= 80)
            {
                humidifierLight.BackColor = Color.Orange;
                HumWarningLabel.ForeColor = Color.Orange;
                HumWarningLabel.Text = "Υψηλή υγρασία!";
            }
            else
            {
                humidifierLight.BackColor = Color.OrangeRed;
                HumWarningLabel.ForeColor = Color.OrangeRed;
                HumWarningLabel.Text = "Πολύ υψηλή υγρασία!";
            }
            HumidityLabel.Text = "Υγρασία: " + trackBarHumidity.Value+"%";
        }

        //
        //Temperature Controls
        //
        Thermostat myThermostat = new Thermostat(22.0);

        private void inc_temp_btn_Click(object sender, EventArgs e)
        {
            if (myThermostat.Temperature >= 32)
            {
                myThermostat.Temperature = 32;
            }
            else
            {
                myThermostat.Temperature += 0.5;
            }
            UpdateWarningSign();
            TemperatureLabel.Text = myThermostat.Temperature.ToString() + " C";
        }

        private void dec_temp_button_Click(object sender, EventArgs e)
        {
            if (myThermostat.Temperature <= 12)
            {
                myThermostat.Temperature = 12;
            }
            else
            {
                myThermostat.Temperature -= 0.5;
            }
            UpdateWarningSign();
            TemperatureLabel.Text = myThermostat.Temperature.ToString() + " C";
        }

        private void UpdateWarningSign()//Update warning sign of temperature
        {
            if (myThermostat.Feeling.Equals("VeryCold"))
            {
                if (TempWarningSign.Visible == false)
                {
                    TempWarningSign.Visible = true;
                }
                TempWarningLabel.Text = "Παγώνω!";
                TempWarningSign.BackgroundImage = Properties.Resources.VeryCold_icon;
            }
            else if (myThermostat.Feeling.Equals("Cold"))
            {
                if (TempWarningSign.Visible == false)
                {
                    TempWarningSign.Visible = true;
                }
                TempWarningLabel.Text = "Κρυώνω!";
                TempWarningSign.BackgroundImage = Properties.Resources.cold_person_icon_color;
            }           
            else if (myThermostat.Feeling.Equals("Normal"))
            {
                TempWarningSign.Visible = false;
                TempWarningLabel.Text = "";
            }             
            else if (myThermostat.Feeling.Equals("Hot"))
            {
                if (TempWarningSign.Visible == false)
                {
                    TempWarningSign.Visible = true;
                }
                TempWarningLabel.Text = "Ζεστένομαι!";
                TempWarningSign.BackgroundImage = Properties.Resources.hot_icon;
            }              
            else
            {
                if (TempWarningSign.Visible == false)
                {
                    TempWarningSign.Visible = true;
                }
                TempWarningLabel.Text = "Βράζω!";
                TempWarningSign.BackgroundImage = Properties.Resources.VeryHot_icon;
            }
                
        }

        //
        //Locks Controls
        //
        Locks myLocks = new Locks(0);

        private void LocksPictureBox_Click(object sender, EventArgs e)
        {
            if (myLocks.Status == 0)
            {
                DoorPictureBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.door_shut_lightsON : Properties.Resources.door_shut_lightsOFF;

                myLocks.LockDoors();
                LocksPictureBox.BackgroundImage = Properties.Resources.locked_icon;
            }
            else
            {
                DoorPictureBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.door_open_lightsON : Properties.Resources.door_open_lightsOFF;

                myLocks.UnlockDoors();
                LocksPictureBox.BackgroundImage = Properties.Resources.unlocked_icon;
            }
        }
    }

}
