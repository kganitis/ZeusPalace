using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Devices
{
    internal class Tv
    {
        private int status = 0;//0 is OFF, 1 is ON

        public int GetStatus()
        {
            return status;
        }

        public void SetStatus(int value)
        {
            status = value;
        }

        public void SwitchON()
        {
            if (GetStatus() == 0)
            {
                SetStatus(1);
            }
        }

        public void SwitchOFF()
        {
            if (GetStatus() == 1)
            {
                SetStatus(0);
            }
        }
    }
}
