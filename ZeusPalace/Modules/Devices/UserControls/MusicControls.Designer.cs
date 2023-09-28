namespace ZeusPalace.Modules.Devices.UserControls
{
    partial class MusicControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.musicLabel = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.25926F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74074F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Controls.Add(this.musicLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnPlay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnStop, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 81);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // musicLabel
            // 
            this.musicLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.musicLabel.Location = new System.Drawing.Point(3, 0);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(176, 81);
            this.musicLabel.TabIndex = 0;
            this.musicLabel.Text = "Αναπαραγωγή Μουσικής";
            this.musicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackgroundImage = global::ZeusPalace.Properties.Resources.play;
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlay.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPlay.Location = new System.Drawing.Point(185, 3);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(119, 75);
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Transparent;
            this.BtnStop.BackgroundImage = global::ZeusPalace.Properties.Resources.stopmusic;
            this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStop.ForeColor = System.Drawing.Color.Transparent;
            this.BtnStop.Location = new System.Drawing.Point(310, 3);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(114, 75);
            this.BtnStop.TabIndex = 1;
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // MusicControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MusicControls";
            this.Size = new System.Drawing.Size(432, 83);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label musicLabel;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPlay;
    }
}
