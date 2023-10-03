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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoolForm));
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBoxAlarmEnabled = new System.Windows.Forms.PictureBox();
            this.pictureBoxSensorDisabled = new System.Windows.Forms.PictureBox();
            this.panelAlarmMode = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonEnabledUntilTurnoff = new System.Windows.Forms.RadioButton();
            this.timePickerAlarmOff = new System.Windows.Forms.DateTimePicker();
            this.radioButtonEnabledUntil = new System.Windows.Forms.RadioButton();
            this.labelTrackBarWarning = new System.Windows.Forms.Label();
            this.verticalProgressBarWaterLevel = new VerticalProgressBar();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarWaterLevel = new System.Windows.Forms.TrackBar();
            this.pictureBoxSensor = new System.Windows.Forms.PictureBox();
            this.trackBarTemperatureLevel = new System.Windows.Forms.TrackBar();
            this.labelSensor = new System.Windows.Forms.Label();
            this.verticalProgressBarTemperature = new VerticalProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxSensorToggle = new System.Windows.Forms.PictureBox();
            this.labelWaterLevel = new System.Windows.Forms.Label();
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.pictureBoxAlarm = new System.Windows.Forms.PictureBox();
            this.labelAlarm = new System.Windows.Forms.Label();
            this.pictureBoxAlarmToggle = new System.Windows.Forms.PictureBox();
            this.pictureBoxPool = new System.Windows.Forms.PictureBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorDisabled)).BeginInit();
            this.panelAlarmMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatureLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).BeginInit();
            this.panelAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPool)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImage = global::ZeusPalace.Properties.Resources.pool;
            this.panelBackground.Controls.Add(this.pictureBoxAlarmEnabled);
            this.panelBackground.Controls.Add(this.pictureBoxSensorDisabled);
            this.panelBackground.Controls.Add(this.panelAlarmMode);
            this.panelBackground.Controls.Add(this.labelTrackBarWarning);
            this.panelBackground.Controls.Add(this.verticalProgressBarWaterLevel);
            this.panelBackground.Controls.Add(this.labelTemperature);
            this.panelBackground.Controls.Add(this.label2);
            this.panelBackground.Controls.Add(this.trackBarWaterLevel);
            this.panelBackground.Controls.Add(this.pictureBoxSensor);
            this.panelBackground.Controls.Add(this.trackBarTemperatureLevel);
            this.panelBackground.Controls.Add(this.labelSensor);
            this.panelBackground.Controls.Add(this.verticalProgressBarTemperature);
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.pictureBoxSensorToggle);
            this.panelBackground.Controls.Add(this.labelWaterLevel);
            this.panelBackground.Controls.Add(this.panelAlarm);
            this.panelBackground.Controls.Add(this.pictureBoxPool);
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1280, 660);
            this.panelBackground.TabIndex = 24;
            // 
            // pictureBoxAlarmEnabled
            // 
            this.pictureBoxAlarmEnabled.Image = global::ZeusPalace.Properties.Resources.alarm_enabled;
            this.pictureBoxAlarmEnabled.Location = new System.Drawing.Point(1088, 167);
            this.pictureBoxAlarmEnabled.Name = "pictureBoxAlarmEnabled";
            this.pictureBoxAlarmEnabled.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxAlarmEnabled.TabIndex = 24;
            this.pictureBoxAlarmEnabled.TabStop = false;
            this.pictureBoxAlarmEnabled.Visible = false;
            // 
            // pictureBoxSensorDisabled
            // 
            this.pictureBoxSensorDisabled.Image = global::ZeusPalace.Properties.Resources.sensor_disabled;
            this.pictureBoxSensorDisabled.Location = new System.Drawing.Point(535, 375);
            this.pictureBoxSensorDisabled.Name = "pictureBoxSensorDisabled";
            this.pictureBoxSensorDisabled.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxSensorDisabled.TabIndex = 23;
            this.pictureBoxSensorDisabled.TabStop = false;
            // 
            // panelAlarmMode
            // 
            this.panelAlarmMode.BackColor = System.Drawing.Color.Transparent;
            this.panelAlarmMode.Controls.Add(this.label5);
            this.panelAlarmMode.Controls.Add(this.radioButtonEnabledUntilTurnoff);
            this.panelAlarmMode.Controls.Add(this.timePickerAlarmOff);
            this.panelAlarmMode.Controls.Add(this.radioButtonEnabledUntil);
            this.panelAlarmMode.Location = new System.Drawing.Point(1047, 363);
            this.panelAlarmMode.Name = "panelAlarmMode";
            this.panelAlarmMode.Size = new System.Drawing.Size(193, 81);
            this.panelAlarmMode.TabIndex = 16;
            this.panelAlarmMode.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ενεργός μέχρι";
            // 
            // radioButtonEnabledUntilTurnoff
            // 
            this.radioButtonEnabledUntilTurnoff.AutoSize = true;
            this.radioButtonEnabledUntilTurnoff.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEnabledUntilTurnoff.Location = new System.Drawing.Point(4, 28);
            this.radioButtonEnabledUntilTurnoff.Name = "radioButtonEnabledUntilTurnoff";
            this.radioButtonEnabledUntilTurnoff.Size = new System.Drawing.Size(185, 22);
            this.radioButtonEnabledUntilTurnoff.TabIndex = 2;
            this.radioButtonEnabledUntilTurnoff.Text = "Nα τον απενεργοποιήσω";
            this.radioButtonEnabledUntilTurnoff.UseVisualStyleBackColor = true;
            this.radioButtonEnabledUntilTurnoff.CheckedChanged += new System.EventHandler(this.radioButtonAlarmMode_CheckedChanged);
            // 
            // timePickerAlarmOff
            // 
            this.timePickerAlarmOff.CalendarFont = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerAlarmOff.CustomFormat = "HH:mm";
            this.timePickerAlarmOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerAlarmOff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timePickerAlarmOff.Location = new System.Drawing.Point(60, 53);
            this.timePickerAlarmOff.Name = "timePickerAlarmOff";
            this.timePickerAlarmOff.Size = new System.Drawing.Size(48, 20);
            this.timePickerAlarmOff.TabIndex = 1;
            this.timePickerAlarmOff.Value = new System.DateTime(2023, 9, 28, 7, 0, 0, 0);
            this.timePickerAlarmOff.ValueChanged += new System.EventHandler(this.timePickerAlarmOff_ValueChanged);
            // 
            // radioButtonEnabledUntil
            // 
            this.radioButtonEnabledUntil.AutoSize = true;
            this.radioButtonEnabledUntil.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonEnabledUntil.Checked = true;
            this.radioButtonEnabledUntil.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEnabledUntil.Location = new System.Drawing.Point(4, 51);
            this.radioButtonEnabledUntil.Name = "radioButtonEnabledUntil";
            this.radioButtonEnabledUntil.Size = new System.Drawing.Size(61, 22);
            this.radioButtonEnabledUntil.TabIndex = 0;
            this.radioButtonEnabledUntil.TabStop = true;
            this.radioButtonEnabledUntil.Text = "Ώρα: ";
            this.radioButtonEnabledUntil.UseVisualStyleBackColor = false;
            this.radioButtonEnabledUntil.CheckedChanged += new System.EventHandler(this.radioButtonAlarmMode_CheckedChanged);
            // 
            // labelTrackBarWarning
            // 
            this.labelTrackBarWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTrackBarWarning.BackColor = System.Drawing.Color.Tomato;
            this.labelTrackBarWarning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrackBarWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackBarWarning.ForeColor = System.Drawing.Color.Snow;
            this.labelTrackBarWarning.Location = new System.Drawing.Point(8, -2663);
            this.labelTrackBarWarning.Name = "labelTrackBarWarning";
            this.labelTrackBarWarning.Size = new System.Drawing.Size(373, 90);
            this.labelTrackBarWarning.TabIndex = 18;
            this.labelTrackBarWarning.Text = "Για λόγους ασφαλείας, δεν επιτρέπεται\r\nη ρύθμιση της στάθμης και της θερμοκασίας\r" +
    "\nτου νερού όταν η πισίνα χρησιμοποιείται";
            this.labelTrackBarWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTrackBarWarning.Visible = false;
            // 
            // verticalProgressBarWaterLevel
            // 
            this.verticalProgressBarWaterLevel.Location = new System.Drawing.Point(160, 506);
            this.verticalProgressBarWaterLevel.Maximum = 270;
            this.verticalProgressBarWaterLevel.Minimum = 90;
            this.verticalProgressBarWaterLevel.Name = "verticalProgressBarWaterLevel";
            this.verticalProgressBarWaterLevel.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.verticalProgressBarWaterLevel.Size = new System.Drawing.Size(90, 120);
            this.verticalProgressBarWaterLevel.TabIndex = 5;
            this.verticalProgressBarWaterLevel.Value = 93;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labelTemperature.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(260, 320);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(62, 26);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "28 oC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 52);
            this.label2.TabIndex = 12;
            this.label2.Text = "Θερμοκρασία\r\nνερού";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarWaterLevel
            // 
            this.trackBarWaterLevel.LargeChange = 30;
            this.trackBarWaterLevel.Location = new System.Drawing.Point(109, 523);
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
            // pictureBoxSensor
            // 
            this.pictureBoxSensor.Image = global::ZeusPalace.Properties.Resources.sensor_off;
            this.pictureBoxSensor.Location = new System.Drawing.Point(620, 245);
            this.pictureBoxSensor.Name = "pictureBoxSensor";
            this.pictureBoxSensor.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxSensor.TabIndex = 10;
            this.pictureBoxSensor.TabStop = false;
            // 
            // trackBarTemperatureLevel
            // 
            this.trackBarTemperatureLevel.LargeChange = 1;
            this.trackBarTemperatureLevel.Location = new System.Drawing.Point(265, 201);
            this.trackBarTemperatureLevel.Maximum = 7;
            this.trackBarTemperatureLevel.Minimum = 1;
            this.trackBarTemperatureLevel.Name = "trackBarTemperatureLevel";
            this.trackBarTemperatureLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTemperatureLevel.Size = new System.Drawing.Size(45, 116);
            this.trackBarTemperatureLevel.TabIndex = 6;
            this.trackBarTemperatureLevel.Value = 4;
            this.trackBarTemperatureLevel.Scroll += new System.EventHandler(this.trackBarTemperatureLevel_Scroll);
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.BackColor = System.Drawing.Color.Transparent;
            this.labelSensor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensor.Location = new System.Drawing.Point(565, 208);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(204, 26);
            this.labelSensor.TabIndex = 9;
            this.labelSensor.Text = "Αισθητήρας χρήσης";
            // 
            // verticalProgressBarTemperature
            // 
            this.verticalProgressBarTemperature.Location = new System.Drawing.Point(316, 194);
            this.verticalProgressBarTemperature.Maximum = 8;
            this.verticalProgressBarTemperature.Name = "verticalProgressBarTemperature";
            this.verticalProgressBarTemperature.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.verticalProgressBarTemperature.Size = new System.Drawing.Size(20, 120);
            this.verticalProgressBarTemperature.TabIndex = 4;
            this.verticalProgressBarTemperature.Value = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Στάθμη πισίνας";
            // 
            // pictureBoxSensorToggle
            // 
            this.pictureBoxSensorToggle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSensorToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSensorToggle.Image = global::ZeusPalace.Properties.Resources.toggle_switch_off;
            this.pictureBoxSensorToggle.Location = new System.Drawing.Point(670, 248);
            this.pictureBoxSensorToggle.Name = "pictureBoxSensorToggle";
            this.pictureBoxSensorToggle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSensorToggle.TabIndex = 8;
            this.pictureBoxSensorToggle.TabStop = false;
            this.pictureBoxSensorToggle.Click += new System.EventHandler(this.pictureBoxSensorToggle_Click);
            // 
            // labelWaterLevel
            // 
            this.labelWaterLevel.AutoSize = true;
            this.labelWaterLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelWaterLevel.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterLevel.Location = new System.Drawing.Point(101, 605);
            this.labelWaterLevel.Name = "labelWaterLevel";
            this.labelWaterLevel.Size = new System.Drawing.Size(63, 26);
            this.labelWaterLevel.TabIndex = 3;
            this.labelWaterLevel.Text = "90 cm";
            // 
            // panelAlarm
            // 
            this.panelAlarm.BackColor = System.Drawing.Color.Transparent;
            this.panelAlarm.Controls.Add(this.pictureBoxAlarm);
            this.panelAlarm.Controls.Add(this.labelAlarm);
            this.panelAlarm.Controls.Add(this.pictureBoxAlarmToggle);
            this.panelAlarm.Location = new System.Drawing.Point(1062, 253);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(153, 109);
            this.panelAlarm.TabIndex = 22;
            // 
            // pictureBoxAlarm
            // 
            this.pictureBoxAlarm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlarm.Image = global::ZeusPalace.Properties.Resources.alarm_off;
            this.pictureBoxAlarm.Location = new System.Drawing.Point(26, 13);
            this.pictureBoxAlarm.Name = "pictureBoxAlarm";
            this.pictureBoxAlarm.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAlarm.TabIndex = 15;
            this.pictureBoxAlarm.TabStop = false;
            // 
            // labelAlarm
            // 
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.BackColor = System.Drawing.Color.Transparent;
            this.labelAlarm.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarm.Location = new System.Drawing.Point(3, 80);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(126, 26);
            this.labelAlarm.TabIndex = 14;
            this.labelAlarm.Text = "Συναγερμός";
            // 
            // pictureBoxAlarmToggle
            // 
            this.pictureBoxAlarmToggle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlarmToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlarmToggle.Image = global::ZeusPalace.Properties.Resources.toggle_switch_off;
            this.pictureBoxAlarmToggle.Location = new System.Drawing.Point(69, 20);
            this.pictureBoxAlarmToggle.Name = "pictureBoxAlarmToggle";
            this.pictureBoxAlarmToggle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAlarmToggle.TabIndex = 13;
            this.pictureBoxAlarmToggle.TabStop = false;
            this.pictureBoxAlarmToggle.Click += new System.EventHandler(this.pictureBoxAlarmToggle_Click);
            // 
            // pictureBoxPool
            // 
            this.pictureBoxPool.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPool.Image")));
            this.pictureBoxPool.Location = new System.Drawing.Point(339, 366);
            this.pictureBoxPool.Name = "pictureBoxPool";
            this.pictureBoxPool.Size = new System.Drawing.Size(658, 294);
            this.pictureBoxPool.TabIndex = 25;
            this.pictureBoxPool.TabStop = false;
            // 
            // PoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.panelBackground);
            this.Name = "PoolForm";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorDisabled)).EndInit();
            this.panelAlarmMode.ResumeLayout(false);
            this.panelAlarmMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatureLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).EndInit();
            this.panelAlarm.ResumeLayout(false);
            this.panelAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPool)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWaterLevel;
        private System.Windows.Forms.PictureBox pictureBoxSensorToggle;
        private System.Windows.Forms.Label label1;
        private VerticalProgressBar verticalProgressBarTemperature;
        private System.Windows.Forms.Label labelSensor;
        private System.Windows.Forms.TrackBar trackBarTemperatureLevel;
        private System.Windows.Forms.PictureBox pictureBoxSensor;
        private System.Windows.Forms.TrackBar trackBarWaterLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTemperature;
        private VerticalProgressBar verticalProgressBarWaterLevel;
        private System.Windows.Forms.Label labelTrackBarWarning;
        private System.Windows.Forms.Panel panelAlarm;
        private System.Windows.Forms.PictureBox pictureBoxAlarm;
        private System.Windows.Forms.Label labelAlarm;
        private System.Windows.Forms.PictureBox pictureBoxAlarmToggle;
        private System.Windows.Forms.Panel panelAlarmMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonEnabledUntilTurnoff;
        private System.Windows.Forms.DateTimePicker timePickerAlarmOff;
        private System.Windows.Forms.RadioButton radioButtonEnabledUntil;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.PictureBox pictureBoxSensorDisabled;
        private System.Windows.Forms.PictureBox pictureBoxAlarmEnabled;
        private System.Windows.Forms.PictureBox pictureBoxPool;
    }
}