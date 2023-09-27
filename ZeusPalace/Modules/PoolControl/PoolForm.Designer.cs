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
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWaterLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemperature)).BeginInit();
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
            this.labelTitle.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(591, 33);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(98, 35);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Πισίνα";
            // 
            // trackBarWaterLevel
            // 
            this.trackBarWaterLevel.LargeChange = 30;
            this.trackBarWaterLevel.Location = new System.Drawing.Point(546, 284);
            this.trackBarWaterLevel.Maximum = 210;
            this.trackBarWaterLevel.Minimum = 90;
            this.trackBarWaterLevel.Name = "trackBarWaterLevel";
            this.trackBarWaterLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarWaterLevel.Size = new System.Drawing.Size(45, 97);
            this.trackBarWaterLevel.SmallChange = 10;
            this.trackBarWaterLevel.TabIndex = 2;
            this.trackBarWaterLevel.Value = 90;
            this.trackBarWaterLevel.Scroll += new System.EventHandler(this.trackBarWaterLevel_Scroll);
            // 
            // labelWaterLevel
            // 
            this.labelWaterLevel.AutoSize = true;
            this.labelWaterLevel.Location = new System.Drawing.Point(626, 414);
            this.labelWaterLevel.Name = "labelWaterLevel";
            this.labelWaterLevel.Size = new System.Drawing.Size(36, 13);
            this.labelWaterLevel.TabIndex = 3;
            this.labelWaterLevel.Text = "90 cm";
            // 
            // verticalProgressBarTemperature
            // 
            this.verticalProgressBarTemperature.Location = new System.Drawing.Point(842, 291);
            this.verticalProgressBarTemperature.Maximum = 8;
            this.verticalProgressBarTemperature.Name = "verticalProgressBarTemperature";
            this.verticalProgressBarTemperature.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.verticalProgressBarTemperature.Size = new System.Drawing.Size(20, 120);
            this.verticalProgressBarTemperature.TabIndex = 4;
            this.verticalProgressBarTemperature.Value = 7;
            // 
            // verticalProgressBarWaterLevel
            // 
            this.verticalProgressBarWaterLevel.Location = new System.Drawing.Point(598, 291);
            this.verticalProgressBarWaterLevel.Maximum = 210;
            this.verticalProgressBarWaterLevel.Minimum = 90;
            this.verticalProgressBarWaterLevel.Name = "verticalProgressBarWaterLevel";
            this.verticalProgressBarWaterLevel.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.verticalProgressBarWaterLevel.Size = new System.Drawing.Size(91, 120);
            this.verticalProgressBarWaterLevel.TabIndex = 5;
            this.verticalProgressBarWaterLevel.Value = 90;
            // 
            // trackBarTemperature
            // 
            this.trackBarTemperature.LargeChange = 1;
            this.trackBarTemperature.Location = new System.Drawing.Point(793, 299);
            this.trackBarTemperature.Maximum = 7;
            this.trackBarTemperature.Minimum = 1;
            this.trackBarTemperature.Name = "trackBarTemperature";
            this.trackBarTemperature.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarTemperature.Size = new System.Drawing.Size(45, 116);
            this.trackBarTemperature.TabIndex = 6;
            this.trackBarTemperature.Value = 7;
            this.trackBarTemperature.Scroll += new System.EventHandler(this.trackBarTemperature_Scroll);
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(837, 414);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(35, 13);
            this.labelTemperature.TabIndex = 7;
            this.labelTemperature.Text = "31 oC";
            // 
            // PoolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 660);
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
    }
}