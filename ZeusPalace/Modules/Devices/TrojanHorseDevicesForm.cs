using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using ZeusPalace.Entities.Devices;

namespace ZeusPalace.Modules.Devices
{
    public partial class TrojanHorseDevicesForm : ZeusPalace.Modules.Devices.DevicesForm
    {
        public TrojanHorseDevicesForm()
        {
            InitializeComponent();
            if (AppController.Instance.ComputerType != ComputerType.Private)
            {
                WheelPictureBox.Enabled = false;
            }
        }

        SoundPlayer MyPlayer = new SoundPlayer("..\\..\\Resources\\Shire_Theme.wav");
        
        //
        //Lights Control
        //
        Lights lights = new Lights();
        private void lightSwitchBtn_Click(object sender, EventArgs e)
        {
            if (lights.GetStatus() == 1)
            {
                MusciBox.BackgroundImage = (myHarp.GetStatus() == 1)
                    ? Properties.Resources.boombox_on_lightsOff : Properties.Resources.boombox_off_lightsOff;

                lights.TurnOff();
                WheelPictureBox.BackgroundImage = Properties.Resources.driving_off_lightsOFF;
                //lightSwitchBtn.BackgroundImage = Properties.Resources.lights_off;
                backPanel.BackgroundImage = Properties.Resources.trojan_horse_lights_Off;
            }
            else
            {
                MusciBox.BackgroundImage = (myHarp.GetStatus() == 1)
                    ? Properties.Resources.boombox_on_lightsOn : Properties.Resources.boombox_off_lightsOn;

                lights.TurnOn();
                WheelPictureBox.BackgroundImage = Properties.Resources.driving_off_lightsON;
                //lightSwitchBtn.BackgroundImage = Properties.Resources.lights_on;
                backPanel.BackgroundImage = Properties.Resources.trojan_horse_lights_on;
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
                    ? Properties.Resources.boombox_on_lightsOn : Properties.Resources.boombox_on_lightsOff;

                myHarp.Play();
                MyPlayer.PlayLooping();
                BtnPlayStop.BackgroundImage = Properties.Resources.stop_btn;
            }
            else
            {
                MusciBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.boombox_off_lightsOn : Properties.Resources.boombox_off_lightsOff;

                myHarp.Stop();
                MyPlayer.Stop();
                BtnPlayStop.BackgroundImage = Properties.Resources.play_btn;
            }
        }

        private void WheelPictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (lights.GetStatus() == 1) 
            {
                WheelPictureBox.BackgroundImage = Properties.Resources.driving_on_lightsON;
            }
            else
            {
                WheelPictureBox.BackgroundImage = Properties.Resources.driving_on_lightsOFF;
            }
            toolTip1.SetToolTip(WheelPictureBox, "Πάμε μια βόλτα!!");
        }

        private void WheelPictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (lights.GetStatus() == 1)
            {
                WheelPictureBox.BackgroundImage = Properties.Resources.driving_off_lightsON;
            }
            else
            {
                WheelPictureBox.BackgroundImage = Properties.Resources.driving_off_lightsOFF;
            }
        }
    }
}
