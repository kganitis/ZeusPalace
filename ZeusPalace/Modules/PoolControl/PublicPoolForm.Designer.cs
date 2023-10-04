namespace ZeusPalace.Modules.PoolControl
{
    partial class PublicPoolForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PublicPoolForm));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatureLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).BeginInit();
            this.panelAlarm.SuspendLayout();
            this.panelAlarmMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmEnabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).BeginInit();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWaterLevel
            // 
            this.labelWaterLevel.Location = new System.Drawing.Point(162, 624);
            this.labelWaterLevel.Text = "150 cm";
            // 
            // pictureBoxSensorToggle
            // 
            this.pictureBoxSensorToggle.Location = new System.Drawing.Point(980, 471);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(175, 499);
            // 
            // verticalProgressBarTemperature
            // 
            this.verticalProgressBarTemperature.Location = new System.Drawing.Point(267, 175);
            // 
            // labelSensor
            // 
            this.labelSensor.Location = new System.Drawing.Point(875, 431);
            // 
            // trackBarTemperatureLevel
            // 
            this.trackBarTemperatureLevel.Location = new System.Drawing.Point(216, 182);
            // 
            // pictureBoxSensor
            // 
            this.pictureBoxSensor.Location = new System.Drawing.Point(930, 468);
            // 
            // trackBarWaterLevel
            // 
            this.trackBarWaterLevel.Location = new System.Drawing.Point(184, 545);
            this.trackBarWaterLevel.Value = 150;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(180, 121);
            // 
            // labelTemperature
            // 
            this.labelTemperature.Location = new System.Drawing.Point(293, 225);
            // 
            // verticalProgressBarWaterLevel
            // 
            this.verticalProgressBarWaterLevel.Location = new System.Drawing.Point(234, 528);
            this.verticalProgressBarWaterLevel.Value = 150;
            // 
            // panelAlarm
            // 
            this.panelAlarm.Location = new System.Drawing.Point(940, 208);
            this.panelAlarm.Size = new System.Drawing.Size(130, 77);
            // 
            // panelAlarmMode
            // 
            this.panelAlarmMode.Location = new System.Drawing.Point(924, 283);
            // 
            // pictureBoxSensorDisabled
            // 
            this.pictureBoxSensorDisabled.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSensorDisabled.Image")));
            this.pictureBoxSensorDisabled.Location = new System.Drawing.Point(943, 542);
            this.pictureBoxSensorDisabled.Size = new System.Drawing.Size(22, 24);
            this.pictureBoxSensorDisabled.Visible = false;
            // 
            // pictureBoxAlarmEnabled
            // 
            this.pictureBoxAlarmEnabled.Image = global::ZeusPalace.Properties.Resources.public_alarm_enabled;
            this.pictureBoxAlarmEnabled.Location = new System.Drawing.Point(889, 130);
            this.pictureBoxAlarmEnabled.Size = new System.Drawing.Size(32, 64);
            // 
            // pictureBoxPool
            // 
            this.pictureBoxPool.Image = global::ZeusPalace.Properties.Resources.public_pool_2;
            this.pictureBoxPool.Location = new System.Drawing.Point(0, 364);
            this.pictureBoxPool.Size = new System.Drawing.Size(1253, 296);
            // 
            // pictureBoxAlarm
            // 
            this.pictureBoxAlarm.Location = new System.Drawing.Point(44, 3);
            // 
            // labelAlarm
            // 
            this.labelAlarm.Location = new System.Drawing.Point(3, 46);
            // 
            // pictureBoxAlarmToggle
            // 
            this.pictureBoxAlarmToggle.Location = new System.Drawing.Point(8, 10);
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImage = global::ZeusPalace.Properties.Resources.public_pool;
            // 
            // PublicPoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Name = "PublicPoolForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperatureLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).EndInit();
            this.panelAlarm.ResumeLayout(false);
            this.panelAlarm.PerformLayout();
            this.panelAlarmMode.ResumeLayout(false);
            this.panelAlarmMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSensorDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmEnabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlarmToggle)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
