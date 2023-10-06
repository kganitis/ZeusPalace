namespace ZeusPalace.Modules.Driving
{
    partial class CampingAreaPanel
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
            this.pictureBoxTrojanHorse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrojanHorse)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTrojanHorse
            // 
            this.pictureBoxTrojanHorse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxTrojanHorse.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTrojanHorse.Image = global::ZeusPalace.Properties.Resources.horse_right_glow;
            this.pictureBoxTrojanHorse.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTrojanHorse.Name = "pictureBoxTrojanHorse";
            this.pictureBoxTrojanHorse.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxTrojanHorse.TabIndex = 9;
            this.pictureBoxTrojanHorse.TabStop = false;
            // 
            // CampingAreaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxTrojanHorse);
            this.Name = "CampingAreaPanel";
            this.Size = new System.Drawing.Size(1280, 540);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrojanHorse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox pictureBoxTrojanHorse;
    }
}
