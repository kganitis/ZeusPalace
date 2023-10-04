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

        //
        //Tv Controls
        //
        Tv myTv = new Tv();

        private void btn_ON_OFF_Click(object sender, EventArgs e)
        {
            if (myTv.GetStatus() == 0)
            {
                myTv.SwitchON();
                btn_ON_OFF.BackgroundImage = Properties.Resources.tvremote_on;
                TvpictureBox.BackgroundImage = Properties.Resources.tv_on;

            }
            else
            {
                myTv.SwitchOFF();
                btn_ON_OFF.BackgroundImage = Properties.Resources.tvremote_off;
                TvpictureBox.BackgroundImage = Properties.Resources.tv_off;
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
                myHarp.Play();
                MyPlayer.PlayLooping();
                BtnPlayStop.BackgroundImage = Properties.Resources.stop;
            }
            else
            {
                myHarp.Stop();
                MyPlayer.Stop();
                BtnPlayStop.BackgroundImage = Properties.Resources.play;
            }
        }
    }

}
