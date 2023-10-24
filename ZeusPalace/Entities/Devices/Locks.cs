using System;

namespace ZeusPalace.Entities.Devices
{
    internal class Locks
    {
        private int status;

        public Locks(int initialStatus)
        {
            if (initialStatus != 0 && initialStatus != 1)
            {
                throw new ArgumentException("Initial status must be 0 or 1");
            }
            status = initialStatus;
        }

        public int Status
        {
            get { return status; }
            set
            {
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Status must be 0 or 1");
                }
                status = value;
            }
        }

        public void LockDoors()
        {
            Status = 1;
        }

        public void UnlockDoors()
        {
            Status = 0;
        }
    }
}
