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
            this.thermostatControls11 = new ZeusPalace.Modules.Devices.UserControls.ThermostatControls1();
            this.BtnPlayStop = new System.Windows.Forms.Button();
            this.MusciBox = new System.Windows.Forms.PictureBox();
            this.btn_ON_OFF = new System.Windows.Forms.Button();
            this.TvpictureBox = new System.Windows.Forms.PictureBox();
            this.lightSwitchBtn = new System.Windows.Forms.Button();
            this.lightBulbBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Deviceslabel = new System.Windows.Forms.Label();
            this.ProgressBarHumidity = new VerticalProgressBar();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.trackBarHumidity = new System.Windows.Forms.TrackBar();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusciBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBulbBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).BeginInit();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backPanel.BackgroundImage = global::ZeusPalace.Properties.Resources.ancient_suite;
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Controls.Add(this.trackBarHumidity);
            this.backPanel.Controls.Add(this.HumidityLabel);
            this.backPanel.Controls.Add(this.ProgressBarHumidity);
            this.backPanel.Controls.Add(this.thermostatControls11);
            this.backPanel.Controls.Add(this.BtnPlayStop);
            this.backPanel.Controls.Add(this.MusciBox);
            this.backPanel.Controls.Add(this.btn_ON_OFF);
            this.backPanel.Controls.Add(this.TvpictureBox);
            this.backPanel.Controls.Add(this.lightSwitchBtn);
            this.backPanel.Controls.Add(this.lightBulbBox);
            this.backPanel.Location = new System.Drawing.Point(-1, 140);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1706, 670);
            this.backPanel.TabIndex = 4;
            // 
            // thermostatControls11
            // 
            this.thermostatControls11.BackColor = System.Drawing.Color.Transparent;
            this.thermostatControls11.Location = new System.Drawing.Point(4, 0);
            this.thermostatControls11.Margin = new System.Windows.Forms.Padding(4);
            this.thermostatControls11.Name = "thermostatControls11";
            this.thermostatControls11.Size = new System.Drawing.Size(533, 43);
            this.thermostatControls11.TabIndex = 6;
            // 
            // BtnPlayStop
            // 
            this.BtnPlayStop.BackgroundImage = global::ZeusPalace.Properties.Resources.play;
            this.BtnPlayStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlayStop.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPlayStop.Location = new System.Drawing.Point(542, 362);
            this.BtnPlayStop.Name = "BtnPlayStop";
            this.BtnPlayStop.Size = new System.Drawing.Size(43, 42);
            this.BtnPlayStop.TabIndex = 5;
            this.BtnPlayStop.UseVisualStyleBackColor = true;
            this.BtnPlayStop.Click += new System.EventHandler(this.BtnPlayStop_Click);
            // 
            // MusciBox
            // 
            this.MusciBox.BackgroundImage = global::ZeusPalace.Properties.Resources.harp;
            this.MusciBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MusciBox.Location = new System.Drawing.Point(521, 419);
            this.MusciBox.Name = "MusciBox";
            this.MusciBox.Size = new System.Drawing.Size(83, 80);
            this.MusciBox.TabIndex = 4;
            this.MusciBox.TabStop = false;
            // 
            // btn_ON_OFF
            // 
            this.btn_ON_OFF.BackgroundImage = global::ZeusPalace.Properties.Resources.tvremote_off;
            this.btn_ON_OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ON_OFF.Location = new System.Drawing.Point(1100, 309);
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
            this.TvpictureBox.Location = new System.Drawing.Point(1167, 274);
            this.TvpictureBox.Name = "TvpictureBox";
            this.TvpictureBox.Size = new System.Drawing.Size(212, 100);
            this.TvpictureBox.TabIndex = 2;
            this.TvpictureBox.TabStop = false;
            // 
            // lightSwitchBtn
            // 
            this.lightSwitchBtn.BackColor = System.Drawing.Color.Transparent;
            this.lightSwitchBtn.BackgroundImage = global::ZeusPalace.Properties.Resources.lights_on;
            this.lightSwitchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lightSwitchBtn.Location = new System.Drawing.Point(144, 351);
            this.lightSwitchBtn.Name = "lightSwitchBtn";
            this.lightSwitchBtn.Size = new System.Drawing.Size(62, 74);
            this.lightSwitchBtn.TabIndex = 1;
            this.lightSwitchBtn.UseVisualStyleBackColor = false;
            this.lightSwitchBtn.Click += new System.EventHandler(this.lightSwitchBtn_Click);
            // 
            // lightBulbBox
            // 
            this.lightBulbBox.BackColor = System.Drawing.Color.Transparent;
            this.lightBulbBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lightBulbBox.BackgroundImage")));
            this.lightBulbBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lightBulbBox.Location = new System.Drawing.Point(690, 3);
            this.lightBulbBox.Name = "lightBulbBox";
            this.lightBulbBox.Size = new System.Drawing.Size(100, 50);
            this.lightBulbBox.TabIndex = 0;
            this.lightBulbBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ZeusPalace.Properties.Resources.symbol_zeus;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1558, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 92);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 92);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Deviceslabel
            // 
            this.Deviceslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Deviceslabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Deviceslabel.Location = new System.Drawing.Point(764, 12);
            this.Deviceslabel.Name = "Deviceslabel";
            this.Deviceslabel.Size = new System.Drawing.Size(230, 92);
            this.Deviceslabel.TabIndex = 5;
            this.Deviceslabel.Text = "Διαχείριση Συσκευών";
            this.Deviceslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBarHumidity
            // 
            this.ProgressBarHumidity.Location = new System.Drawing.Point(966, 386);
            this.ProgressBarHumidity.Name = "ProgressBarHumidity";
            this.ProgressBarHumidity.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ProgressBarHumidity.Size = new System.Drawing.Size(19, 104);
            this.ProgressBarHumidity.TabIndex = 7;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.HumidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HumidityLabel.Location = new System.Drawing.Point(892, 352);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(100, 23);
            this.HumidityLabel.TabIndex = 8;
            this.HumidityLabel.Text = "Υγρασία";
            this.HumidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarHumidity
            // 
            this.trackBarHumidity.Location = new System.Drawing.Point(893, 386);
            this.trackBarHumidity.Name = "trackBarHumidity";
            this.trackBarHumidity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarHumidity.Size = new System.Drawing.Size(56, 104);
            this.trackBarHumidity.TabIndex = 9;
            // 
            // DevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 812);
            this.Controls.Add(this.Deviceslabel);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DevicesForm";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MusciBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBulbBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.PictureBox lightBulbBox;
        private System.Windows.Forms.Button lightSwitchBtn;
        private System.Windows.Forms.PictureBox TvpictureBox;
        private System.Windows.Forms.Label Deviceslabel;
        private System.Windows.Forms.Button btn_ON_OFF;
        private System.Windows.Forms.PictureBox MusciBox;
        private System.Windows.Forms.Button BtnPlayStop;
        private UserControls.ThermostatControls1 thermostatControls11;
        private VerticalProgressBar ProgressBarHumidity;
        private System.Windows.Forms.TrackBar trackBarHumidity;
        private System.Windows.Forms.Label HumidityLabel;
    }
}