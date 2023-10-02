using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Devices
{
    internal class Locks
    {
        private int status = 0;//0 is unlocked, 1 is locked

        public int GetStatus()
        {
            return status;
        }

        public void SetStatus(int value)
        {
            status = value;
        }

        public void Lock()
        {
            if (GetStatus() == 0)
            {
                SetStatus(1);
            }
        }

        public void UnLock()
        {
            if (GetStatus() == 1)
            {
                SetStatus(0);
            }
        }
    }
}
