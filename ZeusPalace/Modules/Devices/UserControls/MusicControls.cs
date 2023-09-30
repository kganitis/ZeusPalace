using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Devices.UserControls
{
    public partial class MusicControls : UserControl
    {        
        SoundPlayer MyPlayer = new SoundPlayer("..\\..\\Resources\\harp_music.wav");
        public MusicControls()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            MyPlayer.PlayLooping();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            MyPlayer.Stop();
        }
    }
}
