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
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.panelAlarmTrigger = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlarm = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlarmToggle = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSensor = new System.Windows.Forms.PictureBox();
            this.pictureBoxSensorToggle = new System.Windows.Forms.PictureBox();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatureLevel)).BeginInit();
            this.panelAlarmMode.SuspendLayout();
            this.panelPoolUsedWarning.SuspendLayout();
            this.panelAlarm.SuspendLayout();
            this.panelAlarmTrigger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).BeginInit();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarWaterLevel
            // 
            this.trackBarWaterLevel.LargeChange = 30;
            this.trackBarWaterLevel.Location = new System.Drawing.Point(204, 489);
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
            this.labelWaterLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelWaterLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWaterLevel.Location = new System.Drawing.Point(204, 579);
            this.labelWaterLevel.Name = "labelWaterLevel";
            this.labelWaterLevel.Size = new System.Drawing.Size(41, 13);
            this.labelWaterLevel.TabIndex = 3;
            this.labelWaterLevel.Text = "90 cm";
            // 
            // verticalProgressBarTemperature
            // 
            this.verticalProgressBarTemperature.Location = new System.Drawing.Point(305, 187);
            this.verticalProgressBarTemperature.Maximum = 8;
            this.verticalProgressBarTemperature.Name = "verticalProgressBarTemperature";
            this.verticalProgressBarTemperature.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(51)))));
            this.verticalProgressBarTemperature.Size = new System.Drawing.Size(20, 120);
            this.verticalProgressBarTemperature.TabIndex = 4;
            this.verticalProgressBarTemperature.Value = 4;
            // 
            // verticalProgressBarWaterLevel
            // 
            this.verticalProgressBarWaterLevel.Location = new System.Drawing.Point(108, 472);
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
            this.trackBarTemperatureLevel.Location = new System.Drawing.Point(254, 194);
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
            this.labelTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labelTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemperature.Location = new System.Drawing.Point(254, 313);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(40, 13);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "28 oC";
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.BackColor = System.Drawing.Color.Transparent;
            this.labelSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSensor.Location = new System.Drawing.Point(586, 195);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(126, 13);
            this.labelSensor.TabIndex = 9;
            this.labelSensor.Text = "Αισθητήρας ατόμων";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Στάθμη πισίνας";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Θερμοκρασία νερού";
            // 
            // labelAlarm
            // 
            this.labelAlarm.AutoSize = true;
            this.labelAlarm.BackColor = System.Drawing.Color.Transparent;
            this.labelAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarm.Location = new System.Drawing.Point(18, 5);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(79, 13);
            this.labelAlarm.TabIndex = 14;
            this.labelAlarm.Text = "Συναγερμός";
            // 
            // panelAlarmMode
            // 
            this.panelAlarmMode.BackColor = System.Drawing.Color.Transparent;
            this.panelAlarmMode.Controls.Add(this.label5);
            this.panelAlarmMode.Controls.Add(this.radioButtonEnabledUntilTurnoff);
            this.panelAlarmMode.Controls.Add(this.timePickerAlarmOff);
            this.panelAlarmMode.Controls.Add(this.radioButtonEnabledUntil);
            this.panelAlarmMode.Location = new System.Drawing.Point(1058, 343);
            this.panelAlarmMode.Name = "panelAlarmMode";
            this.panelAlarmMode.Size = new System.Drawing.Size(176, 75);
            this.panelAlarmMode.TabIndex = 16;
            this.panelAlarmMode.Visible = false;
            // 
            // radioButtonEnabledUntilTurnoff
            // 
            this.radioButtonEnabledUntilTurnoff.AutoSize = true;
            this.radioButtonEnabledUntilTurnoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEnabledUntilTurnoff.Location = new System.Drawing.Point(4, 28);
            this.radioButtonEnabledUntilTurnoff.Name = "radioButtonEnabledUntilTurnoff";
            this.radioButtonEnabledUntilTurnoff.Size = new System.Drawing.Size(170, 17);
            this.radioButtonEnabledUntilTurnoff.TabIndex = 2;
            this.radioButtonEnabledUntilTurnoff.Text = "Nα τον απενεργοποιήσω";
            this.radioButtonEnabledUntilTurnoff.UseVisualStyleBackColor = true;
            this.radioButtonEnabledUntilTurnoff.CheckedChanged += new System.EventHandler(this.radioButtonAlarmMode_CheckedChanged);
            // 
            // timePickerAlarmOff
            // 
            this.timePickerAlarmOff.CustomFormat = "HH:mm";
            this.timePickerAlarmOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerAlarmOff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timePickerAlarmOff.Location = new System.Drawing.Point(60, 50);
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
            this.radioButtonEnabledUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEnabledUntil.Location = new System.Drawing.Point(4, 51);
            this.radioButtonEnabledUntil.Name = "radioButtonEnabledUntil";
            this.radioButtonEnabledUntil.Size = new System.Drawing.Size(59, 17);
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
            this.labelTrackBarWarning.Location = new System.Drawing.Point(460, 10);
            this.labelTrackBarWarning.Name = "labelTrackBarWarning";
            this.labelTrackBarWarning.Size = new System.Drawing.Size(397, 90);
            this.labelTrackBarWarning.TabIndex = 18;
            this.labelTrackBarWarning.Text = "Για λόγους ασφαλείας, δεν επιτρέπεται\r\nη ρύθμιση της στάθμης και της θερμοκασίας\r" +
    "\nτου νερού όταν η πισίνα χρησιμοποιείται";
            this.labelTrackBarWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTrackBarWarning.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(23, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Η πισίνα χρησιμοποιείται";
            // 
            // panelPoolUsedWarning
            // 
            this.panelPoolUsedWarning.BackColor = System.Drawing.Color.Transparent;
            this.panelPoolUsedWarning.Controls.Add(this.pictureBox1);
            this.panelPoolUsedWarning.Controls.Add(this.label3);
            this.panelPoolUsedWarning.Location = new System.Drawing.Point(552, 259);
            this.panelPoolUsedWarning.Name = "panelPoolUsedWarning";
            this.panelPoolUsedWarning.Size = new System.Drawing.Size(180, 22);
            this.panelPoolUsedWarning.TabIndex = 21;
            this.panelPoolUsedWarning.Visible = false;
            // 
            // panelAlarm
            // 
            this.panelAlarm.BackColor = System.Drawing.Color.Transparent;
            this.panelAlarm.Controls.Add(this.pictureBoxAlarm);
            this.panelAlarm.Controls.Add(this.labelAlarm);
            this.panelAlarm.Controls.Add(this.pictureBoxAlarmToggle);
            this.panelAlarm.Location = new System.Drawing.Point(958, 343);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(107, 77);
            this.panelAlarm.TabIndex = 22;
            // 
            // panelAlarmTrigger
            // 
            this.panelAlarmTrigger.BackColor = System.Drawing.Color.Transparent;
            this.panelAlarmTrigger.Controls.Add(this.pictureBox2);
            this.panelAlarmTrigger.Controls.Add(this.label4);
            this.panelAlarmTrigger.Location = new System.Drawing.Point(970, 315);
            this.panelAlarmTrigger.Name = "panelAlarmTrigger";
            this.panelAlarmTrigger.Size = new System.Drawing.Size(107, 22);
            this.panelAlarmTrigger.TabIndex = 23;
            this.panelAlarmTrigger.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(25, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ντριν ντριν!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ZeusPalace.Properties.Resources.warning;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxAlarm
            // 
            this.pictureBoxAlarm.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlarm.Image = global::ZeusPalace.Properties.Resources.alarm_off;
            this.pictureBoxAlarm.Location = new System.Drawing.Point(12, 31);
            this.pictureBoxAlarm.Name = "pictureBoxAlarm";
            this.pictureBoxAlarm.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAlarm.TabIndex = 15;
            this.pictureBoxAlarm.TabStop = false;
            // 
            // pictureBoxAlarmToggle
            // 
            this.pictureBoxAlarmToggle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlarmToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlarmToggle.Image = global::ZeusPalace.Properties.Resources.toggle_switch_off;
            this.pictureBoxAlarmToggle.Location = new System.Drawing.Point(60, 38);
            this.pictureBoxAlarmToggle.Name = "pictureBoxAlarmToggle";
            this.pictureBoxAlarmToggle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAlarmToggle.TabIndex = 13;
            this.pictureBoxAlarmToggle.TabStop = false;
            this.pictureBoxAlarmToggle.Click += new System.EventHandler(this.pictureBoxAlarmToggle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ZeusPalace.Properties.Resources.warning;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxSensor
            // 
            this.pictureBoxSensor.Image = global::ZeusPalace.Properties.Resources.sensor_off;
            this.pictureBoxSensor.Location = new System.Drawing.Point(604, 219);
            this.pictureBoxSensor.Name = "pictureBoxSensor";
            this.pictureBoxSensor.Size = new System.Drawing.Size(36, 36);
            this.pictureBoxSensor.TabIndex = 10;
            this.pictureBoxSensor.TabStop = false;
            // 
            // pictureBoxSensorToggle
            // 
            this.pictureBoxSensorToggle.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSensorToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSensorToggle.Image = global::ZeusPalace.Properties.Resources.toggle_switch_off;
            this.pictureBoxSensorToggle.Location = new System.Drawing.Point(654, 222);
            this.pictureBoxSensorToggle.Name = "pictureBoxSensorToggle";
            this.pictureBoxSensorToggle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSensorToggle.TabIndex = 8;
            this.pictureBoxSensorToggle.TabStop = false;
            this.pictureBoxSensorToggle.Click += new System.EventHandler(this.pictureBoxSensorToggle_Click);
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.panelAlarmTrigger);
            this.panelBackground.Controls.Add(this.panelAlarmMode);
            this.panelBackground.Controls.Add(this.panelPoolUsedWarning);
            this.panelBackground.Controls.Add(this.panelAlarm);
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
            this.panelBackground.Location = new System.Drawing.Point(0, 20);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(1280, 6660);
            this.panelBackground.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ενεργός μέχρι";
            // 
            // PoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.panelBackground);
            this.Name = "PoolForm";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatureLevel)).EndInit();
            this.panelAlarmMode.ResumeLayout(false);
            this.panelAlarmMode.PerformLayout();
            this.panelPoolUsedWarning.ResumeLayout(false);
            this.panelPoolUsedWarning.PerformLayout();
            this.panelAlarm.ResumeLayout(false);
            this.panelAlarm.PerformLayout();
            this.panelAlarmTrigger.ResumeLayout(false);
            this.panelAlarmTrigger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Label labelTrackBarWarning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelPoolUsedWarning;
        private System.Windows.Forms.Panel panelAlarm;
        private System.Windows.Forms.Panel panelAlarmTrigger;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label label5;
    }
}