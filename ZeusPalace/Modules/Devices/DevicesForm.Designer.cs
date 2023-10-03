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
            this.label1 = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.lightSwitchBtn = new System.Windows.Forms.Button();
            this.lightBulbBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightBulbBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(706, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Διαχείριση Συσκευών";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backPanel
            // 
            this.backPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backPanel.BackgroundImage = global::ZeusPalace.Properties.Resources.ancient_suite;
            this.backPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPanel.Controls.Add(this.lightSwitchBtn);
            this.backPanel.Controls.Add(this.lightBulbBox);
            this.backPanel.Location = new System.Drawing.Point(-1, 155);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1706, 655);
            this.backPanel.TabIndex = 4;
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
            this.pictureBox2.Location = new System.Drawing.Point(1555, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 92);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(34, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 92);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DevicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1707, 812);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DevicesForm";
            this.backPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lightBulbBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.PictureBox lightBulbBox;
        private System.Windows.Forms.Button lightSwitchBtn;
    }
}