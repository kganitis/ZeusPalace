namespace ZeusPalace.Modules.Driving
{
    partial class TrojanHorseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrojanHorseForm));
            this.labelRetractLadder = new System.Windows.Forms.Label();
            this.labelExtendLadder = new System.Windows.Forms.Label();
            this.labelClosedDoor = new System.Windows.Forms.Label();
            this.labelHalfOpenDoor = new System.Windows.Forms.Label();
            this.labelOpenDoor = new System.Windows.Forms.Label();
            this.timerMovement = new System.Windows.Forms.Timer(this.components);
            this.labelHalfClosedDoor = new System.Windows.Forms.Label();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.zeusTempleCourtyardPanel = new ZeusPalace.Modules.Driving.ZeusTempleCourtyardPanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRetractLadder
            // 
            this.labelRetractLadder.AutoSize = true;
            this.labelRetractLadder.BackColor = System.Drawing.Color.Transparent;
            this.labelRetractLadder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRetractLadder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRetractLadder.Enabled = false;
            this.labelRetractLadder.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelRetractLadder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelRetractLadder.Location = new System.Drawing.Point(793, 603);
            this.labelRetractLadder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRetractLadder.Name = "labelRetractLadder";
            this.labelRetractLadder.Size = new System.Drawing.Size(163, 28);
            this.labelRetractLadder.TabIndex = 45;
            this.labelRetractLadder.Text = "Ανέβασε Σκάλα";
            this.labelRetractLadder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRetractLadder.Click += new System.EventHandler(this.labelLadder_Click);
            // 
            // labelExtendLadder
            // 
            this.labelExtendLadder.AutoSize = true;
            this.labelExtendLadder.BackColor = System.Drawing.Color.Transparent;
            this.labelExtendLadder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExtendLadder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExtendLadder.Enabled = false;
            this.labelExtendLadder.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelExtendLadder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelExtendLadder.Location = new System.Drawing.Point(793, 565);
            this.labelExtendLadder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExtendLadder.Name = "labelExtendLadder";
            this.labelExtendLadder.Size = new System.Drawing.Size(175, 28);
            this.labelExtendLadder.TabIndex = 44;
            this.labelExtendLadder.Text = "Κατέβασε Σκάλα";
            this.labelExtendLadder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExtendLadder.Click += new System.EventHandler(this.labelLadder_Click);
            // 
            // labelClosedDoor
            // 
            this.labelClosedDoor.AutoSize = true;
            this.labelClosedDoor.BackColor = System.Drawing.Color.Transparent;
            this.labelClosedDoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelClosedDoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClosedDoor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelClosedDoor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelClosedDoor.Location = new System.Drawing.Point(295, 623);
            this.labelClosedDoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClosedDoor.Name = "labelClosedDoor";
            this.labelClosedDoor.Size = new System.Drawing.Size(144, 28);
            this.labelClosedDoor.TabIndex = 43;
            this.labelClosedDoor.Text = "Κλείσε Πόρτα";
            this.labelClosedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClosedDoor.Click += new System.EventHandler(this.labelDoor_Click);
            // 
            // labelHalfOpenDoor
            // 
            this.labelHalfOpenDoor.AutoSize = true;
            this.labelHalfOpenDoor.BackColor = System.Drawing.Color.Transparent;
            this.labelHalfOpenDoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHalfOpenDoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHalfOpenDoor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelHalfOpenDoor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelHalfOpenDoor.Location = new System.Drawing.Point(296, 587);
            this.labelHalfOpenDoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHalfOpenDoor.Name = "labelHalfOpenDoor";
            this.labelHalfOpenDoor.Size = new System.Drawing.Size(189, 28);
            this.labelHalfOpenDoor.TabIndex = 42;
            this.labelHalfOpenDoor.Text = "Μισοάνοιξε Πόρτα";
            this.labelHalfOpenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHalfOpenDoor.Click += new System.EventHandler(this.labelDoor_Click);
            // 
            // labelOpenDoor
            // 
            this.labelOpenDoor.AutoSize = true;
            this.labelOpenDoor.BackColor = System.Drawing.Color.Transparent;
            this.labelOpenDoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOpenDoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelOpenDoor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelOpenDoor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelOpenDoor.Location = new System.Drawing.Point(295, 551);
            this.labelOpenDoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpenDoor.Name = "labelOpenDoor";
            this.labelOpenDoor.Size = new System.Drawing.Size(142, 28);
            this.labelOpenDoor.TabIndex = 41;
            this.labelOpenDoor.Text = "Άνοιξε Πόρτα";
            this.labelOpenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelOpenDoor.Click += new System.EventHandler(this.labelDoor_Click);
            // 
            // timerMovement
            // 
            this.timerMovement.Interval = 30;
            this.timerMovement.Tick += new System.EventHandler(this.timerMovement_Tick);
            // 
            // labelHalfClosedDoor
            // 
            this.labelHalfClosedDoor.AutoSize = true;
            this.labelHalfClosedDoor.BackColor = System.Drawing.Color.Transparent;
            this.labelHalfClosedDoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHalfClosedDoor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHalfClosedDoor.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelHalfClosedDoor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelHalfClosedDoor.Location = new System.Drawing.Point(295, 587);
            this.labelHalfClosedDoor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHalfClosedDoor.Name = "labelHalfClosedDoor";
            this.labelHalfClosedDoor.Size = new System.Drawing.Size(190, 28);
            this.labelHalfClosedDoor.TabIndex = 46;
            this.labelHalfClosedDoor.Text = "Μισόκλεισε Πόρτα";
            this.labelHalfClosedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHalfClosedDoor.Visible = false;
            this.labelHalfClosedDoor.Click += new System.EventHandler(this.labelDoor_Click);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLeft.Image = global::ZeusPalace.Properties.Resources.move_left;
            this.pictureBoxLeft.Location = new System.Drawing.Point(564, 591);
            this.pictureBoxLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxLeft.TabIndex = 40;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDirection_MouseDown);
            this.pictureBoxLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDirection_MouseUp);
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDown.ErrorImage = null;
            this.pictureBoxDown.Image = global::ZeusPalace.Properties.Resources.move_down;
            this.pictureBoxDown.Location = new System.Drawing.Point(608, 591);
            this.pictureBoxDown.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxDown.TabIndex = 39;
            this.pictureBoxDown.TabStop = false;
            this.pictureBoxDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDirection_MouseDown);
            this.pictureBoxDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDirection_MouseUp);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRight.Image = global::ZeusPalace.Properties.Resources.move_right;
            this.pictureBoxRight.Location = new System.Drawing.Point(652, 591);
            this.pictureBoxRight.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxRight.TabIndex = 38;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDirection_MouseDown);
            this.pictureBoxRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDirection_MouseUp);
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUp.Image = global::ZeusPalace.Properties.Resources.move_up;
            this.pictureBoxUp.Location = new System.Drawing.Point(609, 547);
            this.pictureBoxUp.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxUp.TabIndex = 37;
            this.pictureBoxUp.TabStop = false;
            this.pictureBoxUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDirection_MouseDown);
            this.pictureBoxUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDirection_MouseUp);
            // 
            // zeusTempleCourtyardPanel
            // 
            this.zeusTempleCourtyardPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zeusTempleCourtyardPanel.BackgroundImage")));
            this.zeusTempleCourtyardPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.zeusTempleCourtyardPanel.Location = new System.Drawing.Point(0, 0);
            this.zeusTempleCourtyardPanel.Name = "zeusTempleCourtyardPanel";
            this.zeusTempleCourtyardPanel.Size = new System.Drawing.Size(1280, 540);
            this.zeusTempleCourtyardPanel.TabIndex = 47;
            this.zeusTempleCourtyardPanel.TrojanHorseLocation = new System.Drawing.Point(50, 240);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(555, 633);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "Πλήκτρα οδήγησης";
            // 
            // TrojanHorseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zeusTempleCourtyardPanel);
            this.Controls.Add(this.labelHalfClosedDoor);
            this.Controls.Add(this.labelRetractLadder);
            this.Controls.Add(this.labelExtendLadder);
            this.Controls.Add(this.labelClosedDoor);
            this.Controls.Add(this.labelHalfOpenDoor);
            this.Controls.Add(this.labelOpenDoor);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.pictureBoxDown);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.pictureBoxUp);
            this.Name = "TrojanHorseForm";
            this.Load += new System.EventHandler(this.TrojanHorseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Timer timerMovement;
        protected System.Windows.Forms.Label labelRetractLadder;
        protected System.Windows.Forms.Label labelExtendLadder;
        protected System.Windows.Forms.Label labelClosedDoor;
        protected System.Windows.Forms.Label labelHalfOpenDoor;
        protected System.Windows.Forms.Label labelOpenDoor;
        protected System.Windows.Forms.Label labelHalfClosedDoor;
        protected System.Windows.Forms.PictureBox pictureBoxUp;
        protected System.Windows.Forms.PictureBox pictureBoxRight;
        protected System.Windows.Forms.PictureBox pictureBoxDown;
        protected System.Windows.Forms.PictureBox pictureBoxLeft;
        private ZeusTempleCourtyardPanel zeusTempleCourtyardPanel;
        private System.Windows.Forms.Label label1;
    }
}
