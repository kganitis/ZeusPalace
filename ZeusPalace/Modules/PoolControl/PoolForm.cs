using System;
using System.Windows.Forms;
using System.Drawing;
using ZeusPalace.Entities.Pool;
using ZeusPalace.Properties;

namespace ZeusPalace.Modules.PoolControl
{
    public partial class PoolForm : EmbeddedForm
    {
        private Pool pool = new Pool();

        public PoolForm()
        {
            InitializeComponent();

            // Update timerPickerAlarmOff to next occurrence of 7am by default
            DateTime dt = AppController.Instance.DateTime;
            DateTime next7am = new DateTime(dt.Year, dt.Month, dt.Day, 7, 0, 0);
            if (dt >= next7am)
            {
                next7am = next7am.AddDays(1);
            }
            timePickerAlarmOff.Value = next7am;
            pool.WaterLevel = verticalProgressBarWaterLevel.Value;

            UpdatePersonInPoolLocation();
        }

        public PoolForm(Pool pool) : this()
        {
            this.pool = pool;
            labelTitle.Text = pool.Type == PoolType.Private ? "Ιδιωτική πισίνα" : "Κεντρική πισίνα";
            AlignLabelToCenter(labelTitle, panelTitle);
        }

        private void trackBarWaterLevel_Scroll(object sender, EventArgs e)
        {
            verticalProgressBarWaterLevel.Value = trackBarWaterLevel.Value;
            labelWaterLevel.Text = trackBarWaterLevel.Value + " cm";
            pool.WaterLevel = verticalProgressBarWaterLevel.Value;
        }

        private void trackBarTemperature_Scroll(object sender, EventArgs e)
        {
            verticalProgressBarTemperature.Value = trackBarTemperature.Value;
            verticalProgressBarTemperature.ProgressBarColor = ColorPicker.TemperatureColor[verticalProgressBarTemperature.Value - 1];
            labelTemperature.Text = trackBarTemperature.Value + pool.MinTemperature - 1 + " oC";
            pool.Temperature = verticalProgressBarTemperature.Value + pool.MinTemperature - 1;
        }

        private void pictureBoxSensorToggle_Click(object sender, EventArgs e)
        {
            if (pool.SensorEnabled)
            {
                pictureBoxSensorToggle.Image = Resources.toggle_switch_off;
                pictureBoxSensor.Image = Resources.sensor_off;
            }
            else
            {
                pictureBoxSensorToggle.Image = Resources.toggle_switch_on;
                pictureBoxSensor.Image = Resources.sensor_on;
            }
            pool.SensorEnabled = !pool.SensorEnabled;
            pictureBoxAlarm.Visible = pool.SensorEnabled;
            pictureBoxAlarmToggle.Visible = pool.SensorEnabled;
            labelAlarm.Visible = pool.SensorEnabled;
            if (pool.AlarmEnabled && !pool.SensorEnabled)
            {
                pool.AlarmEnabled = false;
                pictureBoxAlarmToggle.Image = Resources.toggle_switch_off;
                pictureBoxAlarm.Image = Resources.alarm_off;
                panelAlarmMode.Visible = false;
            }
            pictureBoxSwimmer.Visible = pool.SensorEnabled && pool.PersonInPool;
        }

        private void pictureBoxAlarmToggle_Click(object sender, EventArgs e)
        {
            if (pool.AlarmEnabled)
            {
                pictureBoxAlarmToggle.Image = Resources.toggle_switch_off;
                pictureBoxAlarm.Image = Resources.alarm_off;
            }
            else
            {
                pictureBoxAlarmToggle.Image = Resources.toggle_switch_on;
                pictureBoxAlarm.Image= Resources.alarm_on;
            }
            pool.AlarmEnabled = !pool.AlarmEnabled;
            panelAlarmMode.Visible = pool.AlarmEnabled;
            if (pool.AlarmEnabled)
            {
                UpdateAlarmDeactivationtime();
            }
            if (pool.AlarmEnabled && pool.PersonInPool)
            {
                RingTheAlarm();
            }
        }

        public void UpdateAlarmDeactivationtime()
        {
            if (radioButtonEnabledUntil.Checked)
            {
                pool.AlarmDeactivationTime = timePickerAlarmOff.Value;
            }
            else
            {
                pool.AlarmDeactivationTime = DateTime.MaxValue;
            }
        }

        public void SetPersonInPool(bool personInPool)
        {
            pool.PersonInPool = personInPool;
            UpdatePersonInPoolLocation();
            pictureBoxSwimmer.Visible = personInPool && pool.SensorEnabled;
            trackBarWaterLevel.Enabled = !personInPool;
            trackBarTemperature.Enabled = !personInPool;
            labelTrackBarWarning.Visible = personInPool;
            if (pool.AlarmEnabled && personInPool)
            {
                RingTheAlarm();
            }
        }

        public void RingTheAlarm()
        {
            // play sound
        }

        private void UpdatePersonInPoolLocation()
        {
            int filledHeight = (int)(verticalProgressBarWaterLevel.Height * ((double)verticalProgressBarWaterLevel.Value / verticalProgressBarWaterLevel.Maximum));
            int progressBarY = verticalProgressBarWaterLevel.Location.Y + (verticalProgressBarWaterLevel.Height - filledHeight);
            int swimmerX = verticalProgressBarWaterLevel.Location.X + (verticalProgressBarWaterLevel.Width - pictureBoxSwimmer.Width) / 2;
            int swimmerY = progressBarY - 15;
            pictureBoxSwimmer.Location = new Point(swimmerX, swimmerY);
        }

        private void radioButtonAlarmEnabled_CheckedChanged(object sender, EventArgs e)
        {
            UpdateAlarmDeactivationtime();
        }
    }
}
