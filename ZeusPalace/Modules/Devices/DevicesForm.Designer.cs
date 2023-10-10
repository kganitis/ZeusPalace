namespace ZeusPalace.Modules.Devices
{
    partial class DevicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevicesForm));
            this.backPanel = new System.Windows.Forms.Panel();
            this.lightsLabel = new System.Windows.Forms.Label();
            this.HumWarningSign = new System.Windows.Forms.PictureBox();
            this.LocksPictureBox = new System.Windows.Forms.PictureBox();
            this.DoorPictureBox = new System.Windows.Forms.PictureBox();
            this.TempWarningLabel = new System.Windows.Forms.Label();
            this.TempWarningSign = new System.Windows.Forms.PictureBox();
            this.dec_temp_button = new System.Windows.Forms.Button();
            this.inc_temp_btn = new System.Windows.Forms.Button();
            this.ThermometerBox = new System.Windows.Forms.PictureBox();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.humidifierLight = new System.Windows.Forms.PictureBox();
            this.HumWarningLabel = new System.Windows.Forms.Label();
            this.trackBarHumidity = new System.Windows.Forms.TrackBar();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.BtnPlayStop = new System.Windows.Forms.Button();
            this.MusciBox = new System.Windows.Forms.PictureBox();
            this.btn_ON_OFF = new System.Windows.Forms.Button();
            this.TvpictureBox = new System.Windows.Forms.PictureBox();
            this.lightSwitchBtn = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HumWarningSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocksPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempWarningSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidifierLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusciBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackgroundImage = global::ZeusPalace.Properties.Resources.pre_ancient_suite;
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Controls.Add(this.lightsLabel);
            this.backPanel.Controls.Add(this.HumWarningSign);
            this.backPanel.Controls.Add(this.LocksPictureBox);
            this.backPanel.Controls.Add(this.DoorPictureBox);
            this.backPanel.Controls.Add(this.TempWarningLabel);
            this.backPanel.Controls.Add(this.TempWarningSign);
            this.backPanel.Controls.Add(this.dec_temp_button);
            this.backPanel.Controls.Add(this.inc_temp_btn);
            this.backPanel.Controls.Add(this.ThermometerBox);
            this.backPanel.Controls.Add(this.TemperatureLabel);
            this.backPanel.Controls.Add(this.humidifierLight);
            this.backPanel.Controls.Add(this.HumWarningLabel);
            this.backPanel.Controls.Add(this.trackBarHumidity);
            this.backPanel.Controls.Add(this.HumidityLabel);
            this.backPanel.Controls.Add(this.BtnPlayStop);
            this.backPanel.Controls.Add(this.MusciBox);
            this.backPanel.Controls.Add(this.btn_ON_OFF);
            this.backPanel.Controls.Add(this.TvpictureBox);
            this.backPanel.Controls.Add(this.lightSwitchBtn);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1280, 660);
            this.backPanel.TabIndex = 4;
            // 
            // lightsLabel
            // 
            this.lightsLabel.BackColor = System.Drawing.Color.Transparent;
            this.lightsLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lightsLabel.ForeColor = System.Drawing.Color.Snow;
            this.lightsLabel.Location = new System.Drawing.Point(127, 185);
            this.lightsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lightsLabel.Name = "lightsLabel";
            this.lightsLabel.Size = new System.Drawing.Size(112, 37);
            this.lightsLabel.TabIndex = 21;
            this.lightsLabel.Text = "Φωτισμός";
            this.lightsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HumWarningSign
            // 
            this.HumWarningSign.BackColor = System.Drawing.Color.Transparent;
            this.HumWarningSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HumWarningSign.Location = new System.Drawing.Point(142, 61);
            this.HumWarningSign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HumWarningSign.Name = "HumWarningSign";
            this.HumWarningSign.Size = new System.Drawing.Size(75, 54);
            this.HumWarningSign.TabIndex = 20;
            this.HumWarningSign.TabStop = false;
            // 
            // LocksPictureBox
            // 
            this.LocksPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LocksPictureBox.BackgroundImage = global::ZeusPalace.Properties.Resources.unlocked_icon;
            this.LocksPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LocksPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocksPictureBox.Location = new System.Drawing.Point(763, 173);
            this.LocksPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LocksPictureBox.Name = "LocksPictureBox";
            this.LocksPictureBox.Size = new System.Drawing.Size(34, 32);
            this.LocksPictureBox.TabIndex = 19;
            this.LocksPictureBox.TabStop = false;
            this.LocksPictureBox.Click += new System.EventHandler(this.LocksPictureBox_Click);
            // 
            // DoorPictureBox
            // 
            this.DoorPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.DoorPictureBox.BackgroundImage = global::ZeusPalace.Properties.Resources.door_open_lightsON;
            this.DoorPictureBox.Location = new System.Drawing.Point(763, 247);
            this.DoorPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoorPictureBox.Name = "DoorPictureBox";
            this.DoorPictureBox.Size = new System.Drawing.Size(37, 172);
            this.DoorPictureBox.TabIndex = 18;
            this.DoorPictureBox.TabStop = false;
            // 
            // TempWarningLabel
            // 
            this.TempWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.TempWarningLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TempWarningLabel.ForeColor = System.Drawing.Color.Snow;
            this.TempWarningLabel.Location = new System.Drawing.Point(1112, 7);
            this.TempWarningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TempWarningLabel.Name = "TempWarningLabel";
            this.TempWarningLabel.Size = new System.Drawing.Size(125, 23);
            this.TempWarningLabel.TabIndex = 17;
            this.TempWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempWarningSign
            // 
            this.TempWarningSign.BackColor = System.Drawing.Color.Transparent;
            this.TempWarningSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TempWarningSign.Location = new System.Drawing.Point(1146, 38);
            this.TempWarningSign.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TempWarningSign.Name = "TempWarningSign";
            this.TempWarningSign.Size = new System.Drawing.Size(72, 57);
            this.TempWarningSign.TabIndex = 16;
            this.TempWarningSign.TabStop = false;
            this.TempWarningSign.Visible = false;
            // 
            // dec_temp_button
            // 
            this.dec_temp_button.BackColor = System.Drawing.Color.Transparent;
            this.dec_temp_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dec_temp_button.FlatAppearance.BorderSize = 0;
            this.dec_temp_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dec_temp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dec_temp_button.Location = new System.Drawing.Point(1071, 127);
            this.dec_temp_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dec_temp_button.Name = "dec_temp_button";
            this.dec_temp_button.Size = new System.Drawing.Size(38, 19);
            this.dec_temp_button.TabIndex = 15;
            this.dec_temp_button.Text = "-";
            this.dec_temp_button.UseVisualStyleBackColor = false;
            this.dec_temp_button.Click += new System.EventHandler(this.dec_temp_button_Click);
            // 
            // inc_temp_btn
            // 
            this.inc_temp_btn.BackColor = System.Drawing.Color.Transparent;
            this.inc_temp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inc_temp_btn.FlatAppearance.BorderSize = 0;
            this.inc_temp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inc_temp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.inc_temp_btn.Location = new System.Drawing.Point(1071, 103);
            this.inc_temp_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inc_temp_btn.Name = "inc_temp_btn";
            this.inc_temp_btn.Size = new System.Drawing.Size(38, 19);
            this.inc_temp_btn.TabIndex = 14;
            this.inc_temp_btn.Text = "+";
            this.inc_temp_btn.UseVisualStyleBackColor = false;
            this.inc_temp_btn.Click += new System.EventHandler(this.inc_temp_btn_Click);
            // 
            // ThermometerBox
            // 
            this.ThermometerBox.BackColor = System.Drawing.Color.Transparent;
            this.ThermometerBox.BackgroundImage = global::ZeusPalace.Properties.Resources.thermometer_color;
            this.ThermometerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ThermometerBox.Location = new System.Drawing.Point(1004, 103);
            this.ThermometerBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ThermometerBox.Name = "ThermometerBox";
            this.ThermometerBox.Size = new System.Drawing.Size(64, 41);
            this.ThermometerBox.TabIndex = 13;
            this.ThermometerBox.TabStop = false;
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TemperatureLabel.ForeColor = System.Drawing.Color.Snow;
            this.TemperatureLabel.Location = new System.Drawing.Point(964, 36);
            this.TemperatureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(155, 65);
            this.TemperatureLabel.TabIndex = 12;
            this.TemperatureLabel.Text = "Θερμοκρασία: 22,0 C";
            this.TemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humidifierLight
            // 
            this.humidifierLight.BackColor = System.Drawing.Color.Lime;
            this.humidifierLight.Location = new System.Drawing.Point(708, 373);
            this.humidifierLight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.humidifierLight.Name = "humidifierLight";
            this.humidifierLight.Size = new System.Drawing.Size(6, 6);
            this.humidifierLight.TabIndex = 11;
            this.humidifierLight.TabStop = false;
            // 
            // HumWarningLabel
            // 
            this.HumWarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumWarningLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HumWarningLabel.ForeColor = System.Drawing.Color.Snow;
            this.HumWarningLabel.Location = new System.Drawing.Point(56, 7);
            this.HumWarningLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HumWarningLabel.Name = "HumWarningLabel";
            this.HumWarningLabel.Size = new System.Drawing.Size(249, 35);
            this.HumWarningLabel.TabIndex = 10;
            this.HumWarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarHumidity
            // 
            this.trackBarHumidity.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarHumidity.Location = new System.Drawing.Point(635, 307);
            this.trackBarHumidity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarHumidity.Maximum = 100;
            this.trackBarHumidity.Name = "trackBarHumidity";
            this.trackBarHumidity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarHumidity.Size = new System.Drawing.Size(45, 60);
            this.trackBarHumidity.TabIndex = 9;
            this.trackBarHumidity.Value = 50;
            this.trackBarHumidity.Scroll += new System.EventHandler(this.trackBarHumidity_Scroll);
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumidityLabel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HumidityLabel.ForeColor = System.Drawing.Color.Snow;
            this.HumidityLabel.Location = new System.Drawing.Point(610, 244);
            this.HumidityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(104, 56);
            this.HumidityLabel.TabIndex = 8;
            this.HumidityLabel.Text = "Υγρασία: 50%";
            this.HumidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPlayStop
            // 
            this.BtnPlayStop.BackColor = System.Drawing.Color.Transparent;
            this.BtnPlayStop.BackgroundImage = global::ZeusPalace.Properties.Resources.play_btn;
            this.BtnPlayStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlayStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPlayStop.FlatAppearance.BorderSize = 0;
            this.BtnPlayStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlayStop.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPlayStop.Location = new System.Drawing.Point(1032, 176);
            this.BtnPlayStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPlayStop.Name = "BtnPlayStop";
            this.BtnPlayStop.Size = new System.Drawing.Size(37, 29);
            this.BtnPlayStop.TabIndex = 5;
            this.BtnPlayStop.UseVisualStyleBackColor = false;
            this.BtnPlayStop.Click += new System.EventHandler(this.BtnPlayStop_Click);
            // 
            // MusciBox
            // 
            this.MusciBox.BackColor = System.Drawing.Color.Transparent;
            this.MusciBox.BackgroundImage = global::ZeusPalace.Properties.Resources.harp_off_lightsON;
            this.MusciBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MusciBox.Location = new System.Drawing.Point(1004, 243);
            this.MusciBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MusciBox.Name = "MusciBox";
            this.MusciBox.Size = new System.Drawing.Size(90, 162);
            this.MusciBox.TabIndex = 4;
            this.MusciBox.TabStop = false;
            // 
            // btn_ON_OFF
            // 
            this.btn_ON_OFF.BackColor = System.Drawing.Color.Transparent;
            this.btn_ON_OFF.BackgroundImage = global::ZeusPalace.Properties.Resources.tvremote_off;
            this.btn_ON_OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ON_OFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ON_OFF.FlatAppearance.BorderSize = 0;
            this.btn_ON_OFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ON_OFF.Location = new System.Drawing.Point(899, 176);
            this.btn_ON_OFF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ON_OFF.Name = "btn_ON_OFF";
            this.btn_ON_OFF.Size = new System.Drawing.Size(37, 29);
            this.btn_ON_OFF.TabIndex = 3;
            this.btn_ON_OFF.UseVisualStyleBackColor = false;
            this.btn_ON_OFF.Click += new System.EventHandler(this.btn_ON_OFF_Click);
            // 
            // TvpictureBox
            // 
            this.TvpictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TvpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TvpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TvpictureBox.BackgroundImage")));
            this.TvpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TvpictureBox.Location = new System.Drawing.Point(857, 232);
            this.TvpictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TvpictureBox.Name = "TvpictureBox";
            this.TvpictureBox.Size = new System.Drawing.Size(134, 113);
            this.TvpictureBox.TabIndex = 2;
            this.TvpictureBox.TabStop = false;
            // 
            // lightSwitchBtn
            // 
            this.lightSwitchBtn.BackColor = System.Drawing.Color.Transparent;
            this.lightSwitchBtn.BackgroundImage = global::ZeusPalace.Properties.Resources.light_switch_color;
            this.lightSwitchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lightSwitchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightSwitchBtn.FlatAppearance.BorderSize = 0;
            this.lightSwitchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lightSwitchBtn.Location = new System.Drawing.Point(154, 226);
            this.lightSwitchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lightSwitchBtn.Name = "lightSwitchBtn";
            this.lightSwitchBtn.Size = new System.Drawing.Size(45, 50);
            this.lightSwitchBtn.TabIndex = 1;
            this.lightSwitchBtn.UseVisualStyleBackColor = false;
            this.lightSwitchBtn.Click += new System.EventHandler(this.lightSwitchBtn_Click);
            // 
            // DevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.backPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DevicesForm";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HumWarningSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocksPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempWarningSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidifierLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusciBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lightsLabel;
        protected System.Windows.Forms.Button lightSwitchBtn;
        protected System.Windows.Forms.PictureBox TvpictureBox;
        protected System.Windows.Forms.Button btn_ON_OFF;
        protected System.Windows.Forms.Button BtnPlayStop;
        protected System.Windows.Forms.TrackBar trackBarHumidity;
        protected System.Windows.Forms.Label HumidityLabel;
        protected System.Windows.Forms.Label HumWarningLabel;
        protected System.Windows.Forms.PictureBox MusciBox;
        protected System.Windows.Forms.PictureBox humidifierLight;
        protected System.Windows.Forms.PictureBox DoorPictureBox;
        protected System.Windows.Forms.PictureBox LocksPictureBox;
        protected System.Windows.Forms.PictureBox HumWarningSign;
        protected System.Windows.Forms.PictureBox ThermometerBox;
        protected System.Windows.Forms.Label TemperatureLabel;
        protected System.Windows.Forms.Button inc_temp_btn;
        protected System.Windows.Forms.Button dec_temp_button;
        protected System.Windows.Forms.PictureBox TempWarningSign;
        protected System.Windows.Forms.Label TempWarningLabel;
        protected System.Windows.Forms.Panel backPanel;
    }
}