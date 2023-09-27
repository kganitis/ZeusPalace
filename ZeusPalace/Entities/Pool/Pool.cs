using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Pool
{
    public class Pool
    {
        public PoolType Type { get; set; }

        private int waterLevel;
        public readonly int MinWaterLevel = 90;
        public readonly int MaxWaterLevel = 210;
        public int WaterLevel 
        {
            get { return waterLevel; }
            set
            {
                if (value > MaxWaterLevel || value < MinWaterLevel)
                {
                    return;
                }
                waterLevel = value;
            }
        }

        private int temperature;
        public readonly int MinTemperature = 25;
        public readonly int MaxTemperature = 31;
        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (value < MinTemperature || value > MaxTemperature)
                {
                    return;
                }
                temperature = value;
            }
        }

        public bool SensorEnabled { get; set; }
        public bool PersonInPool { get; set; }
        public bool AlarmEnabled { get; set; }
    }
}
