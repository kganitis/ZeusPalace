namespace ZeusPalace.Modules.Driving
{
    partial class DrivingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrivingForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panelLabel = new System.Windows.Forms.Panel();
            this.labelRetractedLadder = new System.Windows.Forms.Label();
            this.labelExtendLadder = new System.Windows.Forms.Label();
            this.labelCloseDoor = new System.Windows.Forms.Label();
            this.labelOpenHalfDoor = new System.Windows.Forms.Label();
            this.labelOpenDoor = new System.Windows.Forms.Label();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drivingHorsePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivingHorsePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1486, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 262);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(1486, 477);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(67, 264);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // panelLabel
            // 
            this.panelLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelLabel.Controls.Add(this.labelRetractedLadder);
            this.panelLabel.Controls.Add(this.labelExtendLadder);
            this.panelLabel.Controls.Add(this.labelCloseDoor);
            this.panelLabel.Controls.Add(this.labelOpenHalfDoor);
            this.panelLabel.Controls.Add(this.labelOpenDoor);
            this.panelLabel.Controls.Add(this.pictureBoxLeft);
            this.panelLabel.Controls.Add(this.pictureBoxDown);
            this.panelLabel.Controls.Add(this.pictureBoxRight);
            this.panelLabel.Controls.Add(this.pictureBoxUp);
            this.panelLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLabel.Location = new System.Drawing.Point(0, 539);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(1292, 121);
            this.panelLabel.TabIndex = 28;
            // 
            // labelRetractedLadder
            // 
            this.labelRetractedLadder.AutoSize = true;
            this.labelRetractedLadder.BackColor = System.Drawing.Color.Black;
            this.labelRetractedLadder.Enabled = false;
            this.labelRetractedLadder.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelRetractedLadder.ForeColor = System.Drawing.Color.White;
            this.labelRetractedLadder.Location = new System.Drawing.Point(657, 79);
            this.labelRetractedLadder.Name = "labelRetractedLadder";
            this.labelRetractedLadder.Size = new System.Drawing.Size(163, 26);
            this.labelRetractedLadder.TabIndex = 36;
            this.labelRetractedLadder.Text = " Κλείσε Σκάλα";
            this.labelRetractedLadder.Click += new System.EventHandler(this.labelRetractedLadder_Click);
            // 
            // labelExtendLadder
            // 
            this.labelExtendLadder.AutoSize = true;
            this.labelExtendLadder.BackColor = System.Drawing.Color.Black;
            this.labelExtendLadder.Enabled = false;
            this.labelExtendLadder.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelExtendLadder.ForeColor = System.Drawing.Color.White;
            this.labelExtendLadder.Location = new System.Drawing.Point(657, 30);
            this.labelExtendLadder.Name = "labelExtendLadder";
            this.labelExtendLadder.Size = new System.Drawing.Size(155, 26);
            this.labelExtendLadder.TabIndex = 35;
            this.labelExtendLadder.Text = "Άνοιξε Σκάλα";
            this.labelExtendLadder.Click += new System.EventHandler(this.labelExtendLadder_Click);
            // 
            // labelCloseDoor
            // 
            this.labelCloseDoor.AutoSize = true;
            this.labelCloseDoor.BackColor = System.Drawing.Color.Black;
            this.labelCloseDoor.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelCloseDoor.ForeColor = System.Drawing.Color.White;
            this.labelCloseDoor.Location = new System.Drawing.Point(334, 92);
            this.labelCloseDoor.Name = "labelCloseDoor";
            this.labelCloseDoor.Size = new System.Drawing.Size(158, 26);
            this.labelCloseDoor.TabIndex = 34;
            this.labelCloseDoor.Text = "Κλείσε Πόρτα";
            this.labelCloseDoor.Click += new System.EventHandler(this.labelCloseDoor_Click);
            // 
            // labelOpenHalfDoor
            // 
            this.labelOpenHalfDoor.AutoSize = true;
            this.labelOpenHalfDoor.BackColor = System.Drawing.Color.Black;
            this.labelOpenHalfDoor.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelOpenHalfDoor.ForeColor = System.Drawing.Color.White;
            this.labelOpenHalfDoor.Location = new System.Drawing.Point(334, 50);
            this.labelOpenHalfDoor.Name = "labelOpenHalfDoor";
            this.labelOpenHalfDoor.Size = new System.Drawing.Size(208, 26);
            this.labelOpenHalfDoor.TabIndex = 33;
            this.labelOpenHalfDoor.Text = "Μισοάνοιξε Πόρτα";
            this.labelOpenHalfDoor.Click += new System.EventHandler(this.labelOpenHalfDoor_Click);
            // 
            // labelOpenDoor
            // 
            this.labelOpenDoor.AutoSize = true;
            this.labelOpenDoor.BackColor = System.Drawing.Color.Black;
            this.labelOpenDoor.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelOpenDoor.ForeColor = System.Drawing.Color.White;
            this.labelOpenDoor.Location = new System.Drawing.Point(334, 13);
            this.labelOpenDoor.Name = "labelOpenDoor";
            this.labelOpenDoor.Size = new System.Drawing.Size(156, 26);
            this.labelOpenDoor.TabIndex = 32;
            this.labelOpenDoor.Text = "Άνοιξε Πόρτα";
            this.labelOpenDoor.Click += new System.EventHandler(this.labelOpenDoor_Click);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeft.BackgroundImage")));
            this.pictureBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeft.Location = new System.Drawing.Point(22, 79);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(49, 39);
            this.pictureBoxLeft.TabIndex = 31;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.Click += new System.EventHandler(this.pictureBoxLeft_Click_1);
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxDown.BackgroundImage")));
            this.pictureBoxDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDown.ErrorImage = null;
            this.pictureBoxDown.Location = new System.Drawing.Point(89, 79);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(49, 39);
            this.pictureBoxDown.TabIndex = 30;
            this.pictureBoxDown.TabStop = false;
            this.pictureBoxDown.Click += new System.EventHandler(this.pictureBoxDown_Click);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxRight.BackgroundImage")));
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRight.Location = new System.Drawing.Point(155, 79);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(49, 39);
            this.pictureBoxRight.TabIndex = 29;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.Click += new System.EventHandler(this.pictureBoxRight_Click);
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxUp.BackgroundImage")));
            this.pictureBoxUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUp.Location = new System.Drawing.Point(89, 30);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(49, 39);
            this.pictureBoxUp.TabIndex = 28;
            this.pictureBoxUp.TabStop = false;
            this.pictureBoxUp.Click += new System.EventHandler(this.pictureBoxUp_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.drivingHorsePictureBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 549);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // drivingHorsePictureBox
            // 
            this.drivingHorsePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.drivingHorsePictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("drivingHorsePictureBox.BackgroundImage")));
            this.drivingHorsePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drivingHorsePictureBox.ErrorImage = null;
            this.drivingHorsePictureBox.Location = new System.Drawing.Point(352, 231);
            this.drivingHorsePictureBox.Name = "drivingHorsePictureBox";
            this.drivingHorsePictureBox.Size = new System.Drawing.Size(64, 64);
            this.drivingHorsePictureBox.TabIndex = 0;
            this.drivingHorsePictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 133);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "56,213";
            // 
            // DrivingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1292, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLabel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DrivingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ΠΡΟΑΥΛΙΟ ΤΟΥ ΝΑΟΥ ΔΙΑ";
            this.Load += new System.EventHandler(this.DrivingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DrivingForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelLabel.ResumeLayout(false);
            this.panelLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drivingHorsePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panelLabel;
        private System.Windows.Forms.PictureBox pictureBoxUp;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRetractedLadder;
        private System.Windows.Forms.Label labelExtendLadder;
        private System.Windows.Forms.Label labelCloseDoor;
        private System.Windows.Forms.Label labelOpenHalfDoor;
        private System.Windows.Forms.Label labelOpenDoor;
        private System.Windows.Forms.PictureBox drivingHorsePictureBox;
    }
}