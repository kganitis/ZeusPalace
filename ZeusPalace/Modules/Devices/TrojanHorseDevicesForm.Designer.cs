namespace ZeusPalace.Modules.Devices
{
    partial class TrojanHorseDevicesForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrojanHorseDevicesForm));
            this.WheelPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusciBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidifierLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocksPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumWarningSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempWarningSign)).BeginInit();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WheelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lightSwitchBtn
            // 
            this.lightSwitchBtn.FlatAppearance.BorderSize = 0;
            this.lightSwitchBtn.Click += new System.EventHandler(this.lightSwitchBtn_Click);
            // 
            // TvpictureBox
            // 
            this.TvpictureBox.Location = new System.Drawing.Point(1700, 800);
            this.TvpictureBox.Size = new System.Drawing.Size(10, 10);
            this.TvpictureBox.Visible = false;
            // 
            // btn_ON_OFF
            // 
            this.btn_ON_OFF.FlatAppearance.BorderSize = 0;
            this.btn_ON_OFF.Location = new System.Drawing.Point(1700, 800);
            this.btn_ON_OFF.Size = new System.Drawing.Size(1, 1);
            this.btn_ON_OFF.Visible = false;
            // 
            // BtnPlayStop
            // 
            this.BtnPlayStop.FlatAppearance.BorderSize = 0;
            this.BtnPlayStop.Location = new System.Drawing.Point(1323, 319);
            this.BtnPlayStop.Click += new System.EventHandler(this.BtnPlayStop_Click);
            // 
            // trackBarHumidity
            // 
            this.trackBarHumidity.Location = new System.Drawing.Point(1700, 800);
            this.trackBarHumidity.Size = new System.Drawing.Size(56, 1);
            this.trackBarHumidity.Visible = false;
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.Location = new System.Drawing.Point(1700, 800);
            this.HumidityLabel.Visible = false;
            // 
            // HumWarningLabel
            // 
            this.HumWarningLabel.Location = new System.Drawing.Point(1700, 800);
            this.HumWarningLabel.Size = new System.Drawing.Size(1, 1);
            this.HumWarningLabel.Visible = false;
            // 
            // MusciBox
            // 
            this.MusciBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MusciBox.BackgroundImage")));
            this.MusciBox.Location = new System.Drawing.Point(1280, 361);
            this.MusciBox.Size = new System.Drawing.Size(427, 310);
            // 
            // humidifierLight
            // 
            this.humidifierLight.Location = new System.Drawing.Point(1700, 800);
            this.humidifierLight.Size = new System.Drawing.Size(1, 1);
            this.humidifierLight.Visible = false;
            // 
            // DoorPictureBox
            // 
            this.DoorPictureBox.Location = new System.Drawing.Point(1700, 800);
            this.DoorPictureBox.Size = new System.Drawing.Size(1, 1);
            this.DoorPictureBox.Visible = false;
            // 
            // LocksPictureBox
            // 
            this.LocksPictureBox.Location = new System.Drawing.Point(1700, 800);
            this.LocksPictureBox.Size = new System.Drawing.Size(1, 1);
            this.LocksPictureBox.Visible = false;
            // 
            // HumWarningSign
            // 
            this.HumWarningSign.Location = new System.Drawing.Point(1700, 800);
            this.HumWarningSign.Size = new System.Drawing.Size(1, 1);
            this.HumWarningSign.Visible = false;
            // 
            // ThermometerBox
            // 
            this.ThermometerBox.Location = new System.Drawing.Point(1447, 276);
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.Location = new System.Drawing.Point(1393, 193);
            // 
            // inc_temp_btn
            // 
            this.inc_temp_btn.FlatAppearance.BorderSize = 0;
            this.inc_temp_btn.Location = new System.Drawing.Point(1536, 276);
            // 
            // dec_temp_button
            // 
            this.dec_temp_button.FlatAppearance.BorderSize = 0;
            this.dec_temp_button.Location = new System.Drawing.Point(1536, 305);
            // 
            // backPanel
            // 
            this.backPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backPanel.BackgroundImage")));
            this.backPanel.Controls.Add(this.WheelPictureBox);
            this.backPanel.Controls.SetChildIndex(this.WheelPictureBox, 0);
            this.backPanel.Controls.SetChildIndex(this.lightSwitchBtn, 0);
            this.backPanel.Controls.SetChildIndex(this.TvpictureBox, 0);
            this.backPanel.Controls.SetChildIndex(this.btn_ON_OFF, 0);
            this.backPanel.Controls.SetChildIndex(this.MusciBox, 0);
            this.backPanel.Controls.SetChildIndex(this.BtnPlayStop, 0);
            this.backPanel.Controls.SetChildIndex(this.HumidityLabel, 0);
            this.backPanel.Controls.SetChildIndex(this.trackBarHumidity, 0);
            this.backPanel.Controls.SetChildIndex(this.HumWarningLabel, 0);
            this.backPanel.Controls.SetChildIndex(this.humidifierLight, 0);
            this.backPanel.Controls.SetChildIndex(this.TemperatureLabel, 0);
            this.backPanel.Controls.SetChildIndex(this.ThermometerBox, 0);
            this.backPanel.Controls.SetChildIndex(this.inc_temp_btn, 0);
            this.backPanel.Controls.SetChildIndex(this.dec_temp_button, 0);
            this.backPanel.Controls.SetChildIndex(this.TempWarningSign, 0);
            this.backPanel.Controls.SetChildIndex(this.TempWarningLabel, 0);
            this.backPanel.Controls.SetChildIndex(this.DoorPictureBox, 0);
            this.backPanel.Controls.SetChildIndex(this.LocksPictureBox, 0);
            this.backPanel.Controls.SetChildIndex(this.HumWarningSign, 0);
            this.backPanel.Controls.SetChildIndex(this.lightsLabel, 0);
            // 
            // WheelPictureBox
            // 
            this.WheelPictureBox.AccessibleDescription = "";
            this.WheelPictureBox.AccessibleName = "";
            this.WheelPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.WheelPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WheelPictureBox.BackgroundImage")));
            this.WheelPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WheelPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WheelPictureBox.Location = new System.Drawing.Point(720, 352);
            this.WheelPictureBox.Name = "WheelPictureBox";
            this.WheelPictureBox.Size = new System.Drawing.Size(163, 82);
            this.WheelPictureBox.TabIndex = 22;
            this.WheelPictureBox.TabStop = false;
            this.WheelPictureBox.Tag = "";
            this.WheelPictureBox.Click += new System.EventHandler(this.WheelPictureBox_Click);
            this.WheelPictureBox.MouseLeave += new System.EventHandler(this.WheelPictureBox_MouseLeave);
            this.WheelPictureBox.MouseHover += new System.EventHandler(this.WheelPictureBox_MouseHover);
            // 
            // TrojanHorseDevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1707, 812);
            this.Name = "TrojanHorseDevicesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TvpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusciBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.humidifierLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocksPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HumWarningSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThermometerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempWarningSign)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WheelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox WheelPictureBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
