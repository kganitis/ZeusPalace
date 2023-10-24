namespace ZeusPalace.Entities.Devices
{
    internal class Lights
    {
        private int status = 1;//0 is lights are off, 1 is lights are on

        public int GetStatus()
        {
            return status;
        }

        public void SetStatus(int value)
        {
            status = value;
        }

        public void TurnOn()
        {
            if (GetStatus() == 0)
            {
                SetStatus(1);
            }
        }

        public void TurnOff()
        {
            if (GetStatus() == 1)
            {
                SetStatus(0);
            }
        }
    }
}
