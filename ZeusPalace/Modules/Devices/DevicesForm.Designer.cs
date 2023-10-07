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
            this.humidifierLight = new System.Windows.Forms.PictureBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.trackBarHumidity = new System.Windows.Forms.TrackBar();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.thermostatController = new ZeusPalace.Modules.Devices.UserControls.ThermostatControls1();
            this.BtnPlayStop = new System.Windows.Forms.Button();
            this.MusciBox = new System.Windows.Forms.PictureBox();
            this.btn_ON_OFF = new System.Windows.Forms.Button();
            this.TvpictureBox = new System.Windows.Forms.PictureBox();
            this.lightSwitchBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidifierLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusciBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackgroundImage = global::ZeusPalace.Properties.Resources.pre_ancient_suite;
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Controls.Add(this.humidifierLight);
            this.backPanel.Controls.Add(this.WarningLabel);
            this.backPanel.Controls.Add(this.trackBarHumidity);
            this.backPanel.Controls.Add(this.HumidityLabel);
            this.backPanel.Controls.Add(this.thermostatController);
            this.backPanel.Controls.Add(this.BtnPlayStop);
            this.backPanel.Controls.Add(this.MusciBox);
            this.backPanel.Controls.Add(this.btn_ON_OFF);
            this.backPanel.Controls.Add(this.TvpictureBox);
            this.backPanel.Controls.Add(this.lightSwitchBtn);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1707, 812);
            this.backPanel.TabIndex = 4;
            // 
            // humidifierLight
            // 
            this.humidifierLight.BackColor = System.Drawing.Color.Lime;
            this.humidifierLight.Location = new System.Drawing.Point(944, 459);
            this.humidifierLight.Name = "humidifierLight";
            this.humidifierLight.Size = new System.Drawing.Size(8, 8);
            this.humidifierLight.TabIndex = 11;
            this.humidifierLight.TabStop = false;
            // 
            // WarningLabel
            // 
            this.WarningLabel.BackColor = System.Drawing.Color.Transparent;
            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.WarningLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.WarningLabel.Location = new System.Drawing.Point(766, 342);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(332, 23);
            this.WarningLabel.TabIndex = 10;
            this.WarningLabel.Text = "Warning Label";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarHumidity
            // 
            this.trackBarHumidity.Location = new System.Drawing.Point(847, 378);
            this.trackBarHumidity.Maximum = 100;
            this.trackBarHumidity.Name = "trackBarHumidity";
            this.trackBarHumidity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarHumidity.Size = new System.Drawing.Size(56, 74);
            this.trackBarHumidity.TabIndex = 9;
            this.trackBarHumidity.Value = 50;
            this.trackBarHumidity.Scroll += new System.EventHandler(this.trackBarHumidity_Scroll);
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HumidityLabel.ForeColor = System.Drawing.Color.Snow;
            this.HumidityLabel.Location = new System.Drawing.Point(893, 395);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(113, 52);
            this.HumidityLabel.TabIndex = 8;
            this.HumidityLabel.Text = "Υγρασία: 50%";
            this.HumidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thermostatController
            // 
            this.thermostatController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thermostatController.BackColor = System.Drawing.Color.OliveDrab;
            this.thermostatController.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thermostatController.Location = new System.Drawing.Point(794, 81);
            this.thermostatController.Margin = new System.Windows.Forms.Padding(4);
            this.thermostatController.Name = "thermostatController";
            this.thermostatController.Size = new System.Drawing.Size(420, 54);
            this.thermostatController.TabIndex = 6;
            // 
            // BtnPlayStop
            // 
            this.BtnPlayStop.BackgroundImage = global::ZeusPalace.Properties.Resources.play;
            this.BtnPlayStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlayStop.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPlayStop.Location = new System.Drawing.Point(1406, 249);
            this.BtnPlayStop.Name = "BtnPlayStop";
            this.BtnPlayStop.Size = new System.Drawing.Size(43, 42);
            this.BtnPlayStop.TabIndex = 5;
            this.BtnPlayStop.UseVisualStyleBackColor = true;
            this.BtnPlayStop.Click += new System.EventHandler(this.BtnPlayStop_Click);
            // 
            // MusciBox
            // 
            this.MusciBox.BackColor = System.Drawing.Color.Transparent;
            this.MusciBox.BackgroundImage = global::ZeusPalace.Properties.Resources.harp_off_lightsON;
            this.MusciBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MusciBox.Location = new System.Drawing.Point(1339, 299);
            this.MusciBox.Name = "MusciBox";
            this.MusciBox.Size = new System.Drawing.Size(120, 199);
            this.MusciBox.TabIndex = 4;
            this.MusciBox.TabStop = false;
            // 
            // btn_ON_OFF
            // 
            this.btn_ON_OFF.BackgroundImage = global::ZeusPalace.Properties.Resources.tvremote_off;
            this.btn_ON_OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ON_OFF.Location = new System.Drawing.Point(1197, 228);
            this.btn_ON_OFF.Name = "btn_ON_OFF";
            this.btn_ON_OFF.Size = new System.Drawing.Size(47, 36);
            this.btn_ON_OFF.TabIndex = 3;
            this.btn_ON_OFF.UseVisualStyleBackColor = true;
            this.btn_ON_OFF.Click += new System.EventHandler(this.btn_ON_OFF_Click);
            // 
            // TvpictureBox
            // 
            this.TvpictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TvpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.TvpictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TvpictureBox.BackgroundImage")));
            this.TvpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TvpictureBox.Location = new System.Drawing.Point(1143, 286);
            this.TvpictureBox.Name = "TvpictureBox";
            this.TvpictureBox.Size = new System.Drawing.Size(179, 139);
            this.TvpictureBox.TabIndex = 2;
            this.TvpictureBox.TabStop = false;
            // 
            // lightSwitchBtn
            // 
            this.lightSwitchBtn.BackColor = System.Drawing.Color.Transparent;
            this.lightSwitchBtn.BackgroundImage = global::ZeusPalace.Properties.Resources.lights_on;
            this.lightSwitchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lightSwitchBtn.Location = new System.Drawing.Point(1578, 342);
            this.lightSwitchBtn.Name = "lightSwitchBtn";
            this.lightSwitchBtn.Size = new System.Drawing.Size(55, 62);
            this.lightSwitchBtn.TabIndex = 1;
            this.lightSwitchBtn.UseVisualStyleBackColor = false;
            this.lightSwitchBtn.Click += new System.EventHandler(this.lightSwitchBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // DevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 812);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DevicesForm";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidifierLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusciBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Button lightSwitchBtn;
        private System.Windows.Forms.PictureBox TvpictureBox;
        private System.Windows.Forms.Button btn_ON_OFF;
        private System.Windows.Forms.Button BtnPlayStop;
        private System.Windows.Forms.TrackBar trackBarHumidity;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.PictureBox MusciBox;
        private System.Windows.Forms.PictureBox humidifierLight;
        private UserControls.ThermostatControls1 thermostatController;
    }
}