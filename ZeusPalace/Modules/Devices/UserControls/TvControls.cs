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
    public partial class TvControls : UserControl
    {
        public TvControls()
        {
            InitializeComponent();
        }

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
    }
}
