﻿using System;

namespace ZeusPalace.Entities.Pool
{
    public class Pool
    {
        private int waterLevel = 150;
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

        public readonly int MinTemperature = 25;
        public readonly int MaxTemperature = 31;
        public int TemperatureLevel { get; set; } = 4;
        public int Temperature => TemperatureLevel + MinTemperature - 1;

        public bool SensorEnabled { get; set; } = false;
        public bool PersonInPool { get; set; } = false;

        private bool alarmEnabled = false;
        public bool AlarmEnabled
        {
            get { return SensorEnabled && alarmEnabled; }
            set { alarmEnabled = SensorEnabled && value; }
        }
        public bool AlarmTriggered => AlarmEnabled && PersonInPool;

        private DateTime alarmDeactivationTime = DateTime.MinValue;
        public DateTime AlarmDeactivationTime
        {
            get { return alarmDeactivationTime; }
            set { alarmDeactivationTime = AlarmEnabled ? value : new DateTime(2099, 12, 31, 0, 0, 0); }
        }
    }
}
