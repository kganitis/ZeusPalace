using System;
using System.Windows.Forms;
using System.Drawing;
using ZeusPalace.Entities.Pool;
using ZeusPalace.Properties;
using System.Media;
using System.Resources;
using System.Xml.Linq;

namespace ZeusPalace.Modules.PoolControl
{
    public partial class PoolForm : EmbeddedForm
    {
        private Pool pool = new Pool();
        private SoundPlayer soundPlayer = new SoundPlayer();
        private string currentPoolImageName = "";

        public PoolForm()
        {
            InitializeComponent();
            AppController.Instance.TimeChanged += Instance_TimeChanged;
            AppController.Instance.PersonInPoolChanged += Instance_PersonInPoolChanged;
            InitializeUI();
        }

        private void Instance_PersonInPoolChanged(object sender, EventArgs e)
        {
            pool.PersonInPool = AppController.Instance.PersonInPool;
            UpdateUI();
        }

        private void Instance_TimeChanged(object sender, EventArgs e)
        {
            if (pool.AlarmEnabled)
            {
                if (AppController.Instance.DateTime >= pool.AlarmDeactivationTime)
                {
                    pool.AlarmEnabled = false;
                    UpdateUI();
                }
            }
        }

        private void InitializeUI()
        {
            //
            // TrackBars
            //
            trackBarWaterLevel.Value = pool.WaterLevel;
            trackBarTemperatureLevel.Value = pool.TemperatureLevel;

            //
            // Update timerPickerAlarmOff to next occurrence of 7am by default
            //
            timePickerAlarmOff.Value = NextOccurrenceOfTime(7, 0);

            UpdateUI();
        }

        private DateTime NextOccurrenceOfTime(int hours, int minutes)
        {
            hours = Math.Max(0, Math.Min(23, hours));
            minutes = Math.Max(0, Math.Min(59, minutes));

            DateTime now = AppController.Instance.DateTime;
            DateTime nextOccurrence = new DateTime(now.Year, now.Month, now.Day, hours, minutes, 0);
            if (now >= nextOccurrence)
            {
                nextOccurrence = nextOccurrence.AddDays(1);
            }
            return nextOccurrence;
        }

        private void UpdateUI()
        {
            //
            // Background Image (depending on water level and person in pool)
            //
            int waterLevelRange = (pool.MaxWaterLevel - pool.MinWaterLevel) / 3;
            int waterLevel = 1;
            if (pool.WaterLevel > pool.MinWaterLevel + waterLevelRange)
            {
                waterLevel = 2;
            }
            if (pool.WaterLevel > pool.MinWaterLevel + 2 * waterLevelRange)
            {
                waterLevel = 3;
            }
            string poolImageName = $"pool_{waterLevel}";
            if (pool.SensorEnabled && pool.PersonInPool)
            {
                poolImageName += "_people";
            }
            if (!currentPoolImageName.Equals(poolImageName))
            {
                pictureBoxPool.Image = (Image)Resources.ResourceManager.GetObject(poolImageName);
            }
            
            //
            // Water Level
            //
            trackBarWaterLevel.Enabled = !(pool.SensorEnabled && pool.PersonInPool);
            verticalProgressBarWaterLevel.Value = pool.WaterLevel;
            labelWaterLevel.Text = $"{pool.WaterLevel} cm";

            //
            // TemperatureLevel
            //
            trackBarTemperatureLevel.Enabled = !(pool.SensorEnabled && pool.PersonInPool);
            verticalProgressBarTemperature.Value = pool.TemperatureLevel;
            verticalProgressBarTemperature.ProgressBarColor = ColorPicker.TemperatureColor[pool.TemperatureLevel - 1];
            labelTemperature.Text = $"{pool.Temperature} oC";

            //
            // Sensor
            //
            pictureBoxSensor.Image = pool.SensorEnabled ? Resources.sensor_on : Resources.sensor_off;
            pictureBoxSensorToggle.Image = pool.SensorEnabled ? Resources.toggle_switch_on : Resources.toggle_switch_off;
            pictureBoxSensorDisabled.Visible = !pool.SensorEnabled;

            //
            // Alarm
            //
            panelAlarm.Visible = pool.SensorEnabled;
            pictureBoxAlarm.Image = pool.AlarmEnabled ? Resources.alarm_on : Resources.alarm_off;
            pictureBoxAlarmToggle.Image = pool.AlarmEnabled ? Resources.toggle_switch_on : Resources.toggle_switch_off;
            pictureBoxAlarmEnabled.Visible = pool.AlarmEnabled;
            panelAlarmMode.Visible = pool.AlarmEnabled;
            timePickerAlarmOff.Enabled = pool.AlarmEnabled && radioButtonEnabledUntil.Checked;
            if (timePickerAlarmOff.Enabled)
            {
                timePickerAlarmOff.Value = pool.AlarmDeactivationTime;
            }

            //
            // Alarm Triggering
            //
            if (pool.AlarmTriggered)
            {
                soundPlayer.Stream = Resources.alarm_sound;
                soundPlayer.PlayLooping();
            }
            else
            {
                soundPlayer.Stop();
            }
        }

        private void trackBarWaterLevel_Scroll(object sender, EventArgs e)
        {
            pool.WaterLevel = trackBarWaterLevel.Value;
            UpdateUI();
        }

        private void trackBarTemperatureLevel_Scroll(object sender, EventArgs e)
        {
            pool.TemperatureLevel = trackBarTemperatureLevel.Value;
            UpdateUI();
        }

        private void pictureBoxSensorToggle_Click(object sender, EventArgs e)
        {
            pool.SensorEnabled = !pool.SensorEnabled;
            if (pool.AlarmEnabled) pool.AlarmEnabled = false;
            UpdateUI();
        }

        private void pictureBoxAlarmToggle_Click(object sender, EventArgs e)
        {
            pool.AlarmEnabled = !pool.AlarmEnabled;
            UpdateAlarmDeactivationTime();
            UpdateUI();
        }

        private void radioButtonAlarmMode_CheckedChanged(object sender, EventArgs e)
        {
            if (pool.AlarmEnabled)
            {
                if (radioButtonEnabledUntil.Checked)
                {
                    UpdateAlarmDeactivationTime();
                }
                else
                {
                    pool.AlarmDeactivationTime = DateTime.MaxValue;
                }
            }
            UpdateUI();
        }

        private void timePickerAlarmOff_ValueChanged(object sender, EventArgs e)
        {
            UpdateAlarmDeactivationTime();
            UpdateUI();
        }

        private void UpdateAlarmDeactivationTime()
        {
            int hours = timePickerAlarmOff.Value.Hour;
            int minutes = timePickerAlarmOff.Value.Minute;
            pool.AlarmDeactivationTime = NextOccurrenceOfTime(hours, minutes);
        }

        private void PlaySound(System.IO.UnmanagedMemoryStream soundResource)
        {
            soundPlayer.Stream = soundResource;
            soundPlayer.Play();
        }
    }
}
