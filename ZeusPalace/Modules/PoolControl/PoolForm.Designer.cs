namespace ZeusPalace.Modules.PoolControl
{
    partial class PoolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTitle = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.trackBarWaterLevel = new System.Windows.Forms.TrackBar();
            this.labelWaterLevel = new System.Windows.Forms.Label();
            this.verticalProgressBarTemperature = new VerticalProgressBar();
            this.verticalProgressBarWaterLevel = new VerticalProgressBar();
            this.trackBarTemperatureLevel = new System.Windows.Forms.TrackBar();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelSensor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAlarm = new System.Windows.Forms.Label();
            this.panelAlarmMode = new System.Windows.Forms.Panel();
            this.radioButtonEnabledUntilTurnoff = new System.Windows.Forms.RadioButton();
            this.timePickerAlarmOff = new System.Windows.Forms.DateTimePicker();
            this.radioButtonEnabledUntil = new System.Windows.Forms.RadioButton();
            this.labelTrackBarWarning = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPoolUsedWarning = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSwimmer = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlarm = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlarmToggle = new System.Windows.Forms.PictureBox();
            this.pictureBoxSensor = new System.Windows.Forms.PictureBox();
            this.pictureBoxSensorToggle = new System.Windows.Forms.PictureBox();
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.panelAlarmTrigger = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatureLevel)).BeginInit();
            this.panelAlarmMode.SuspendLayout();
            this.panelPoolUsedWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwimmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).BeginInit();
            this.panelAlarm.SuspendLayout();
            this.panelAlarmTrigger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1280, 100);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(591, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(108, 37);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Πισίνα";
            // 
            // trackBarWaterLevel
            // 
            this.trackBarWaterLevel.LargeChange = 30;
            this.trackBarWaterLevel.Location = new System.Drawing.Point(489, 313);
            this.trackBarWaterLevel.Maximum = 210;
            this.trackBarWaterLevel.Minimum = 90;
            this.trackBarWaterLevel.Name = "trackBarWaterLevel";
            this.trackBarWaterLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarWaterLevel.Size = new System.Drawing.Size(45, 81);
            this.trackBarWaterLevel.SmallChange = 10;
            this.trackBarWaterLevel.TabIndex = 2;
            this.trackBarWaterLevel.Value = 90;
            this.trackBarWaterLevel.Scroll += new System.EventHandler(this.trackBarWaterLevel_Scroll);
            // 
            // labelWaterLevel
            // 
            this.labelWaterLevel.AutoSize = true;
            this.labelWaterLevel.Location = new System.Drawing.Point(568, 426);
            this.labelWaterLevel.Name = "labelWaterLevel";
            this.labelWaterLevel.Size = new System.Drawing.Size(36, 13);
            this.labelWaterLevel.TabIndex = 3;
            this.labelWaterLevel.Text = "90 cm";
            // 
            // verticalProgressBarTemperature
            // 
            this.verticalProgressBarTemperature.Location = new System.Drawing.Point(736, 294);
            this.verticalProgressBarTemperature.Maximum = 8;
            this.verticalProgressBarTemperature.Name = "verticalProgressBarTemperature";
            this.verticalProgressBarTemperature.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.verticalProgressBarTemperature.Size = new System.Drawing.Size(20, 120);
            this.verticalProgressBarTemperature.TabIndex = 4;
            this.verticalProgressBarTemperature.Value = 4;
            // 
            // verticalProgressBarWaterLevel
            // 
            this.verticalProgressBarWaterLevel.Location = new System.Drawing.Point(540, 294);
            this.verticalProgressBarWaterLevel.Maximum = 270;
            this.verticalProgressBarWaterLevel.Minimum = 90;
            this.verticalProgressBarWaterLevel.Name = "verticalProgressBarWaterLevel";
            this.verticalProgressBarWaterLevel.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.verticalProgressBarWaterLevel.Size = new System.Drawing.Size(90, 120);
            this.verticalProgressBarWaterLevel.TabIndex = 5;
            this.verticalProgressBarWaterLevel.Value = 93;
            // 
            // trackBarTemperatureLevel
            // 
            this.trackBarTemperatureLevel.LargeChange = 1;
            this.trackBarTemperatureLevel.Location = new System.Drawing.Point(685, 302);
            this.trackBarTemperatureLevel.Maximum = 7;
            this.trackBarTemperatureLevel.Minimum = 1;
            this.trackBarTemperatureLevel.Name = "trackBarTemperatureLevel";
            this.trackBarTemperatureLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTemperatureLevel.Size = new System.Drawing.Size(45, 116);
            this.trackBarTemperatureLevel.TabIndex = 6;
            this.trackBarTemperatureLevel.Value = 4;
            this.trackBarTemperatureLevel.Scroll += new System.EventHandler(this.trackBarTemperatureLevel_Scroll);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(729, 426);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(35, 13);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "28 oC";
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.Location = new System.Drawing.Point(441, 116);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(109, 13);
            this.labelSensor.TabIndex = 9;
            this.labelSensor.Text = "Αισθητήρας ατόμων";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Στάθμη";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(712, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Θερμοκρασία";
            // 
            // labelAlarm
            // 
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.Location = new System.Drawing.Point(18, 10);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(69, 13);
            this.labelAlarm.TabIndex = 14;
            this.labelAlarm.Text = "Συναγερμός";
            // 
            // panelAlarmMode
            // 
            this.panelAlarmMode.Controls.Add(this.radioButtonEnabledUntilTurnoff);
            this.panelAlarmMode.Controls.Add(this.timePickerAlarmOff);
            this.panelAlarmMode.Controls.Add(this.radioButtonEnabledUntil);
            this.panelAlarmMode.Location = new System.Drawing.Point(846, 137);
            this.panelAlarmMode.Name = "panelAlarmMode";
            this.panelAlarmMode.Size = new System.Drawing.Size(228, 63);
            this.panelAlarmMode.TabIndex = 16;
            this.panelAlarmMode.Visible = false;
            // 
            // radioButtonEnabledUntilTurnoff
            // 
            this.radioButtonEnabledUntilTurnoff.AutoSize = true;
            this.radioButtonEnabledUntilTurnoff.Location = new System.Drawing.Point(0, 29);
            this.radioButtonEnabledUntilTurnoff.Name = "radioButtonEnabledUntilTurnoff";
            this.radioButtonEnabledUntilTurnoff.Size = new System.Drawing.Size(179, 17);
            this.radioButtonEnabledUntilTurnoff.TabIndex = 2;
            this.radioButtonEnabledUntilTurnoff.Text = "Μέχρι να τον απενεργοποιήσω";
            this.radioButtonEnabledUntilTurnoff.UseVisualStyleBackColor = true;
            this.radioButtonEnabledUntilTurnoff.CheckedChanged += new System.EventHandler(this.radioButtonAlarmMode_CheckedChanged);
            // 
            // timePickerAlarmOff
            // 
            this.timePickerAlarmOff.CustomFormat = "HH:mm";
            this.timePickerAlarmOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerAlarmOff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timePickerAlarmOff.Location = new System.Drawing.Point(97, 2);
            this.timePickerAlarmOff.Name = "timePickerAlarmOff";
            this.timePickerAlarmOff.Size = new System.Drawing.Size(48, 20);
            this.timePickerAlarmOff.TabIndex = 1;
            this.timePickerAlarmOff.Value = new System.DateTime(2023, 9, 28, 7, 0, 0, 0);
            this.timePickerAlarmOff.ValueChanged += new System.EventHandler(this.timePickerAlarmOff_ValueChanged);
            // 
            // radioButtonEnabledUntil
            // 
            this.radioButtonEnabledUntil.AutoSize = true;
            this.radioButtonEnabledUntil.Checked = true;
            this.radioButtonEnabledUntil.Location = new System.Drawing.Point(0, 3);
            this.radioButtonEnabledUntil.Name = "radioButtonEnabledUntil";
            this.radioButtonEnabledUntil.Size = new System.Drawing.Size(97, 17);
            this.radioButtonEnabledUntil.TabIndex = 0;
            this.radioButtonEnabledUntil.TabStop = true;
            this.radioButtonEnabledUntil.Text = "Ενεργός μέχρι";
            this.radioButtonEnabledUntil.UseVisualStyleBackColor = true;
            this.radioButtonEnabledUntil.CheckedChanged += new System.EventHandler(this.radioButtonAlarmMode_CheckedChanged);
            // 
            // labelTrackBarWarning
            // 
            this.labelTrackBarWarning.AutoSize = true;
            this.labelTrackBarWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.labelTrackBarWarning.Location = new System.Drawing.Point(470, 465);
            this.labelTrackBarWarning.Name = "labelTrackBarWarning";
            this.labelTrackBarWarning.Size = new System.Drawing.Size(328, 26);
            this.labelTrackBarWarning.TabIndex = 18;
            this.labelTrackBarWarning.Text = "Για λόγους ασφαλείας, δεν επιτρέπεται η ρύθμιση της στάθμης\r\nκαι της θερμοκασίας " +
    "του νερού όταν η πισίνα χρησιμοποιείται";
            this.labelTrackBarWarning.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(25, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Η πισίνα χρησιμοποιείται";
            // 
            // panelPoolUsedWarning
            // 
            this.panelPoolUsedWarning.Controls.Add(this.pictureBox1);
            this.panelPoolUsedWarning.Controls.Add(this.label3);
            this.panelPoolUsedWarning.Location = new System.Drawing.Point(413, 193);
            this.panelPoolUsedWarning.Name = "panelPoolUsedWarning";
            this.panelPoolUsedWarning.Size = new System.Drawing.Size(158, 22);
            this.panelPoolUsedWarning.TabIndex = 21;
            this.panelPoolUsedWarning.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZeusPalace.Properties.Resources.warning;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSwimmer
            // 
            this.pictureBoxSwimmer.Image = global::ZeusPalace.Properties.Resources.swimmer;
            this.pictureBoxSwimmer.Location = new System.Drawing.Point(560, 376);
            this.pictureBoxSwimmer.Name = "pictureBoxSwimmer";
            this.pictureBoxSwimmer.Size = new System.Drawing.Size(50, 25);
            this.pictureBoxSwimmer.TabIndex = 17;
            this.pictureBoxSwimmer.TabStop = false;
            this.pictureBoxSwimmer.Visible = false;
            // 
            // pictureBoxAlarm
            // 
            this.pictureBoxAlarm.Image = global::ZeusPalace.Properties.Resources.alarm_off;
            this.pictureBoxAlarm.Location = new System.Drawing.Point(12, 31);
            this.pictureBoxAlarm.Name = "pictureBoxAlarm";
            this.pictureBoxAlarm.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAlarm.TabIndex = 15;
            this.pictureBoxAlarm.TabStop = false;
            // 
            // pictureBoxAlarmToggle
            // 
            this.pictureBoxAlarmToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlarmToggle.Image = global::ZeusPalace.Properties.Resources.toggle_switch_off;
            this.pictureBoxAlarmToggle.Location = new System.Drawing.Point(63, 38);
            this.pictureBoxAlarmToggle.Name = "pictureBoxAlarmToggle";
            this.pictureBoxAlarmToggle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAlarmToggle.TabIndex = 13;
            this.pictureBoxAlarmToggle.TabStop = false;
            this.pictureBoxAlarmToggle.Click += new System.EventHandler(this.pictureBoxAlarmToggle_Click);
            // 
            // pictureBoxSensor
            // 
            this.pictureBoxSensor.Image = global::ZeusPalace.Properties.Resources.sensor_off;
            this.pictureBoxSensor.Location = new System.Drawing.Point(453, 141);
            this.pictureBoxSensor.Name = "pictureBoxSensor";
            this.pictureBoxSensor.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxSensor.TabIndex = 10;
            this.pictureBoxSensor.TabStop = false;
            // 
            // pictureBoxSensorToggle
            // 
            this.pictureBoxSensorToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSensorToggle.Image = global::ZeusPalace.Properties.Resources.toggle_switch_off;
            this.pictureBoxSensorToggle.Location = new System.Drawing.Point(508, 144);
            this.pictureBoxSensorToggle.Name = "pictureBoxSensorToggle";
            this.pictureBoxSensorToggle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSensorToggle.TabIndex = 8;
            this.pictureBoxSensorToggle.TabStop = false;
            this.pictureBoxSensorToggle.Click += new System.EventHandler(this.pictureBoxSensorToggle_Click);
            // 
            // panelAlarm
            // 
            this.panelAlarm.Controls.Add(this.pictureBoxAlarm);
            this.panelAlarm.Controls.Add(this.labelAlarm);
            this.panelAlarm.Controls.Add(this.pictureBoxAlarmToggle);
            this.panelAlarm.Location = new System.Drawing.Point(733, 106);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(107, 77);
            this.panelAlarm.TabIndex = 22;
            // 
            // panelAlarmTrigger
            // 
            this.panelAlarmTrigger.Controls.Add(this.pictureBox2);
            this.panelAlarmTrigger.Controls.Add(this.label4);
            this.panelAlarmTrigger.Location = new System.Drawing.Point(736, 193);
            this.panelAlarmTrigger.Name = "panelAlarmTrigger";
            this.panelAlarmTrigger.Size = new System.Drawing.Size(107, 22);
            this.panelAlarmTrigger.TabIndex = 23;
            this.panelAlarmTrigger.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ZeusPalace.Properties.Resources.warning;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(25, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ντριν ντριν!";
            // 
            // PoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.panelAlarmTrigger);
            this.Controls.Add(this.panelAlarm);
            this.Controls.Add(this.panelPoolUsedWarning);
            this.Controls.Add(this.labelTrackBarWarning);
            this.Controls.Add(this.pictureBoxSwimmer);
            this.Controls.Add(this.panelAlarmMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSensor);
            this.Controls.Add(this.labelSensor);
            this.Controls.Add(this.pictureBoxSensorToggle);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.trackBarTemperatureLevel);
            this.Controls.Add(this.verticalProgressBarWaterLevel);
            this.Controls.Add(this.verticalProgressBarTemperature);
            this.Controls.Add(this.labelWaterLevel);
            this.Controls.Add(this.trackBarWaterLevel);
            this.Controls.Add(this.panelTitle);
            this.Name = "PoolForm";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatureLevel)).EndInit();
            this.panelAlarmMode.ResumeLayout(false);
            this.panelAlarmMode.PerformLayout();
            this.panelPoolUsedWarning.ResumeLayout(false);
            this.panelPoolUsedWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwimmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).EndInit();
            this.panelAlarm.ResumeLayout(false);
            this.panelAlarm.PerformLayout();
            this.panelAlarmTrigger.ResumeLayout(false);
            this.panelAlarmTrigger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        protected System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TrackBar trackBarWaterLevel;
        private System.Windows.Forms.Label labelWaterLevel;
        private VerticalProgressBar verticalProgressBarTemperature;
        private VerticalProgressBar verticalProgressBarWaterLevel;
        private System.Windows.Forms.TrackBar trackBarTemperatureLevel;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.PictureBox pictureBoxSensorToggle;
        private System.Windows.Forms.Label labelSensor;
        private System.Windows.Forms.PictureBox pictureBoxSensor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxAlarm;
        private System.Windows.Forms.Label labelAlarm;
        private System.Windows.Forms.PictureBox pictureBoxAlarmToggle;
        private System.Windows.Forms.Panel panelAlarmMode;
        private System.Windows.Forms.DateTimePicker timePickerAlarmOff;
        private System.Windows.Forms.RadioButton radioButtonEnabledUntil;
        private System.Windows.Forms.RadioButton radioButtonEnabledUntilTurnoff;
        private System.Windows.Forms.PictureBox pictureBoxSwimmer;
        private System.Windows.Forms.Label labelTrackBarWarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPoolUsedWarning;
        private System.Windows.Forms.Panel panelAlarm;
        private System.Windows.Forms.Panel panelAlarmTrigger;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}