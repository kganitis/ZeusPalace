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
    public partial class LocksControls : UserControl
    {
        public LocksControls()
        {
            InitializeComponent();
        }

        Locks myLocks = new Locks();

        private void btn_lock_unlock_Click(object sender, EventArgs e)
        {
            if (myLocks.GetStatus() == 0)
            {
                myLocks.Lock();
                btn_lock_unlock.BackgroundImage = Properties.Resources.btn_unlocked;
                LocksPictureBox.BackgroundImage = Properties.Resources.door_locked;

            }
            else
            {
                myLocks.UnLock();
                btn_lock_unlock.BackgroundImage = Properties.Resources.btn_locked;
                LocksPictureBox.BackgroundImage = Properties.Resources.door_unlocked;
            }
        }
    }
}
