namespace ZeusPalace.Entities.Devices
{
    internal class Harp
    {
        private int status = 0;//0 is harp music is off, 1 is on

        public int GetStatus()
        {
            return status;
        }

        public void SetStatus(int value)
        {
            status = value;
        }

        public void Play()
        {
            if (GetStatus() == 0)
            {
                SetStatus(1);
            }
        }

        public void Stop()
        {
            if (GetStatus() == 1)
            {
                SetStatus(0);
            }
        }
    }
}
