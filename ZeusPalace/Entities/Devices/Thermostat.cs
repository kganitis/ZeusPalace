﻿using System;

namespace ZeusPalace.Entities.Devices
{
    internal class Thermostat
    {
        private double temperature; // in Celsius (°C) scale
        public readonly double MinTemperature = 12.0;
        public readonly double MaxTemperature = 32.0;
        public enum FeelingEnum { VeryCold, Cold, Normal, Hot, VeryHot }
        private FeelingEnum Temperaturefeeling;
        

        public Thermostat (double initialTemperature)
        {
            this.temperature = initialTemperature;
        }

        public double Temperature
        {
            get { return temperature; }
            set
            {
                if (value < MinTemperature || value > MaxTemperature)
                {
                    throw new ArgumentOutOfRangeException("Temperature must be between 12 and 32 degrees.");
                }
                temperature = value;
                UpdateFeeling();
            }
        }
        public string Feeling
        {
            get { return Temperaturefeeling.ToString(); }
        }

        private void UpdateFeeling()
        {
            if (temperature >= MinTemperature && temperature < 15)
            {
                Temperaturefeeling = FeelingEnum.VeryCold;
            }
            else if (temperature >= 15 && temperature < 18)
            {
                Temperaturefeeling = FeelingEnum.Cold;
            }
            else if (temperature >= 18 && temperature < 26)
            {
                Temperaturefeeling = FeelingEnum.Normal;
            }
            else if (temperature >= 26 && temperature < 30)
            {
                Temperaturefeeling = FeelingEnum.Hot;
            }
            else if (temperature >= 30 && temperature <= MaxTemperature)
            {
                Temperaturefeeling = FeelingEnum.VeryHot;
            }
        }

    }

    
}
