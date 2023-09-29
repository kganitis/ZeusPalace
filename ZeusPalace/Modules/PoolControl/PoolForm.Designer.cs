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
            this.trackBarTemperature = new System.Windows.Forms.TrackBar();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelSensor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAlarm = new System.Windows.Forms.Label();
            this.panelAlarmMode = new System.Windows.Forms.Panel();
            this.radioButtonEnabledUntilTurnoff = new System.Windows.Forms.RadioButton();
            this.timePickerAlarmOff = new System.Windows.Forms.DateTimePicker();
            this.radioButtonEnabledUntil = new System.Windows.Forms.RadioButton();
            this.pictureBoxAlarm = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlarmToggle = new System.Windows.Forms.PictureBox();
            this.pictureBoxSensor = new System.Windows.Forms.PictureBox();
            this.pictureBoxSensorToggle = new System.Windows.Forms.PictureBox();
            this.pictureBoxSwimmer = new System.Windows.Forms.PictureBox();
            this.labelTrackBarWarning = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
            this.panelAlarmMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwimmer)).BeginInit();
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
            this.labelWaterLevel.Location = new System.Drawing.Point(568, 421);
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
            // trackBarTemperature
            // 
            this.trackBarTemperature.LargeChange = 1;
            this.trackBarTemperature.Location = new System.Drawing.Point(685, 302);
            this.trackBarTemperature.Maximum = 7;
            this.trackBarTemperature.Minimum = 1;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTemperature.Size = new System.Drawing.Size(45, 116);
            this.trackBarTemperature.TabIndex = 6;
            this.trackBarTemperature.Value = 4;
            this.trackBarTemperature.Scroll += new System.EventHandler(this.trackBarTemperature_Scroll);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(729, 421);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(35, 13);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "31 oC";
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.Location = new System.Drawing.Point(443, 189);
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
            this.labelAlarm.Location = new System.Drawing.Point(753, 189);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(69, 13);
            this.labelAlarm.TabIndex = 14;
            this.labelAlarm.Text = "Συναγερμός";
            this.labelAlarm.Visible = false;
            // 
            // panelAlarmMode
            // 
            this.panelAlarmMode.Controls.Add(this.radioButtonEnabledUntilTurnoff);
            this.panelAlarmMode.Controls.Add(this.timePickerAlarmOff);
            this.panelAlarmMode.Controls.Add(this.radioButtonEnabledUntil);
            this.panelAlarmMode.Location = new System.Drawing.Point(856, 139);
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
            this.radioButtonEnabledUntilTurnoff.CheckedChanged += new System.EventHandler(this.radioButtonAlarmEnabled_CheckedChanged);
            // 
            // timePickerAlarmOff
            // 
            this.timePickerAlarmOff.CustomFormat = "HH:mm";
            this.timePickerAlarmOff.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerAlarmOff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timePickerAlarmOff.Location = new System.Drawing.Point(94, 3);
            this.timePickerAlarmOff.Name = "timePickerAlarmOff";
            this.timePickerAlarmOff.Size = new System.Drawing.Size(51, 20);
            this.timePickerAlarmOff.TabIndex = 1;
            this.timePickerAlarmOff.Value = new System.DateTime(2023, 9, 28, 7, 0, 0, 0);
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
            this.radioButtonEnabledUntil.CheckedChanged += new System.EventHandler(this.radioButtonAlarmEnabled_CheckedChanged);
            // 
            // pictureBoxAlarm
            // 
            this.pictureBoxAlarm.Image = global::ZeusPalace.Properties.Resources.alarm_off;
            this.pictureBoxAlarm.Location = new System.Drawing.Point(745, 139);
            this.pictureBoxAlarm.Name = "pictureBoxAlarm";
            this.pictureBoxAlarm.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAlarm.TabIndex = 15;
            this.pictureBoxAlarm.TabStop = false;
            this.pictureBoxAlarm.Visible = false;
            // 
            // pictureBoxAlarmToggle
            // 
            this.pictureBoxAlarmToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlarmToggle.Image = global::ZeusPalace.Properties.Resources.toggle_switch_off;
            this.pictureBoxAlarmToggle.Location = new System.Drawing.Point(800, 144);
            this.pictureBoxAlarmToggle.Name = "pictureBoxAlarmToggle";
            this.pictureBoxAlarmToggle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAlarmToggle.TabIndex = 13;
            this.pictureBoxAlarmToggle.TabStop = false;
            this.pictureBoxAlarmToggle.Visible = false;
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
            // labelTrackBarWarning
            // 
            this.labelTrackBarWarning.AutoSize = true;
            this.labelTrackBarWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.labelTrackBarWarning.Location = new System.Drawing.Point(326, 453);
            this.labelTrackBarWarning.Name = "labelTrackBarWarning";
            this.labelTrackBarWarning.Size = new System.Drawing.Size(644, 13);
            this.labelTrackBarWarning.TabIndex = 18;
            this.labelTrackBarWarning.Text = "Για λόγους ασφαλείας, δεν επιτρέπεται η ρύθμιση της στάθμης και της θερμοκασίας τ" +
    "ου νερού όταν η πισίνα χρησιμοποιείται";
            this.labelTrackBarWarning.Visible = false;
            // 
            // PoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.labelTrackBarWarning);
            this.Controls.Add(this.pictureBoxSwimmer);
            this.Controls.Add(this.panelAlarmMode);
            this.Controls.Add(this.pictureBoxAlarm);
            this.Controls.Add(this.labelAlarm);
            this.Controls.Add(this.pictureBoxAlarmToggle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxSensor);
            this.Controls.Add(this.labelSensor);
            this.Controls.Add(this.pictureBoxSensorToggle);
            this.Controls.Add(this.labelTemperature);
            this.Controls.Add(this.trackBarTemperature);
            this.Controls.Add(this.verticalProgressBarWaterLevel);
            this.Controls.Add(this.verticalProgressBarTemperature);
            this.Controls.Add(this.labelWaterLevel);
            this.Controls.Add(this.trackBarWaterLevel);
            this.Controls.Add(this.panelTitle);
            this.Name = "PoolForm";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).EndInit();
            this.panelAlarmMode.ResumeLayout(false);
            this.panelAlarmMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwimmer)).EndInit();
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
        private System.Windows.Forms.TrackBar trackBarTemperature;
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
    }
}