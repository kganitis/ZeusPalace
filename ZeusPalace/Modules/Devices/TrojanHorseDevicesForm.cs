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
        }

        SoundPlayer MyPlayer = new SoundPlayer("..\\..\\Resources\\harp_music.wav");
        
        //
        //Lights Control
        //
        Lights lights = new Lights();
        private void lightSwitchBtn_Click(object sender, EventArgs e)
        {
            if (lights.GetStatus() == 1)
            {
                MusciBox.BackgroundImage = (myHarp.GetStatus() == 1)
                    ? Properties.Resources.boombox_on_lightsOFF : Properties.Resources.boombox_off_lightsOFF;

                lights.TurnOff();
                //lightSwitchBtn.BackgroundImage = Properties.Resources.lights_off;
                backPanel.BackgroundImage = Properties.Resources.trojan_horse_lights_off;
            }
            else
            {
                MusciBox.BackgroundImage = (myHarp.GetStatus() == 1)
                    ? Properties.Resources.boombox_on_lightsON : Properties.Resources.boombox_off_lightsON;

                lights.TurnOn();
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
                    ? Properties.Resources.boombox_on_lightsON : Properties.Resources.boombox_on_lightsOFF;

                myHarp.Play();
                MyPlayer.PlayLooping();
                BtnPlayStop.BackgroundImage = Properties.Resources.stop_btn;
            }
            else
            {
                MusciBox.BackgroundImage = (lights.GetStatus() == 1)
                    ? Properties.Resources.boombox_off_lightsON : Properties.Resources.boombox_off_lightsOFF;

                myHarp.Stop();
                MyPlayer.Stop();
                BtnPlayStop.BackgroundImage = Properties.Resources.play_btn;
            }
        }

        
    }
}
