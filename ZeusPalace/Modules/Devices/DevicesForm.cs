using System;
using System.Drawing;
using System.Media;
using ZeusPalace.Entities.Devices;

namespace ZeusPalace.Modules.Devices
{
    public partial class DevicesForm : EmbeddedForm
    {
        public DevicesForm()
        {
            InitializeComponent();
            OnlineHelpSection = "#toc-Επισκόπηση%20εργαλείων%20ελέγχου%20συσκευών";
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
                lightSwitchBtn.BackgroundImage = Properties.Resources.light_switch_color_inverted;
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
                lightSwitchBtn.BackgroundImage = Properties.Resources.light_switch_color;
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
                BtnPlayStop.BackgroundImage = Properties.Resources.stop_btn;
            }
            else
            {
                MusciBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.harp_off_lightsON : Properties.Resources.harp_off_lightsOFF;

                myHarp.Stop();
                MyPlayer.Stop();
                BtnPlayStop.BackgroundImage = Properties.Resources.play_btn;
            }
        }

        //
        //Humidity Controls
        //
        private void trackBarHumidity_Scroll(object sender, EventArgs e)
        {
            if (trackBarHumidity.Value >= 0 && trackBarHumidity.Value <= 25)
            {
                if (HumWarningSign.Visible == false)
                {
                    HumWarningSign.Visible = true;
                }
                humidifierLight.BackColor = Color.OrangeRed;
                HumWarningSign.BackgroundImage = Properties.Resources.VerylowHum_icon;
                HumWarningLabel.Text = "Πολύ χαμηλή υγρασία!";
            }
            else if (trackBarHumidity.Value > 25 && trackBarHumidity.Value <= 40)
            {
                if (HumWarningSign.Visible == false)
                {
                    HumWarningSign.Visible = true;
                }
                humidifierLight.BackColor = Color.Orange;
                HumWarningSign.BackgroundImage = Properties.Resources.lowHum_icon;
                HumWarningLabel.Text = "Χαμηλή υγρασία!";
            }
            else if (trackBarHumidity.Value > 40 && trackBarHumidity.Value <= 70)
            {
                humidifierLight.BackColor = Color.OliveDrab;
                HumWarningSign.Visible = false;
                HumWarningLabel.Text = "";
            }
            else if (trackBarHumidity.Value > 70 && trackBarHumidity.Value <= 80)
            {
                if (HumWarningSign.Visible == false)
                {
                    HumWarningSign.Visible = true;
                }
                humidifierLight.BackColor = Color.Orange;
                HumWarningSign.BackgroundImage = Properties.Resources.highHum_icon;
                HumWarningLabel.Text = "Υψηλή υγρασία!";
            }
            else
            {
                if (HumWarningSign.Visible == false)
                {
                    HumWarningSign.Visible = true;
                }
                humidifierLight.BackColor = Color.OrangeRed;
                HumWarningSign.BackgroundImage = Properties.Resources.VeryhighHum_icon;
                HumWarningLabel.Text = "Πολύ υψηλή υγρασία!";
            }
            HumidityLabel.Text = "Υγρασία: " + trackBarHumidity.Value + "%";
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
            TemperatureLabel.Text = "Θερμοκρασία: " + myThermostat.Temperature.ToString() + " C";
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
            TemperatureLabel.Text = "Θερμοκρασία: " + myThermostat.Temperature.ToString() + " C";
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
