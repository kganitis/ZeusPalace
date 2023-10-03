namespace ZeusPalace.Modules.Devices.UserControls
{
    partial class LocksControls
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
            this.LocksPictureBox = new System.Windows.Forms.PictureBox();
            this.btn_lock_unlock = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocksPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.68831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.31169F));
            this.tableLayoutPanel1.Controls.Add(this.btn_lock_unlock, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LocksPictureBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 97);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LocksPictureBox
            // 
            this.LocksPictureBox.BackgroundImage = global::ZeusPalace.Properties.Resources.door_unlocked;
            this.LocksPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LocksPictureBox.Location = new System.Drawing.Point(3, 3);
            this.LocksPictureBox.Name = "LocksPictureBox";
            this.LocksPictureBox.Size = new System.Drawing.Size(148, 91);
            this.LocksPictureBox.TabIndex = 0;
            this.LocksPictureBox.TabStop = false;
            // 
            // btn_lock_unlock
            // 
            this.btn_lock_unlock.BackgroundImage = global::ZeusPalace.Properties.Resources.btn_locked;
            this.btn_lock_unlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lock_unlock.Location = new System.Drawing.Point(157, 3);
            this.btn_lock_unlock.Name = "btn_lock_unlock";
            this.btn_lock_unlock.Size = new System.Drawing.Size(139, 91);
            this.btn_lock_unlock.TabIndex = 1;
            this.btn_lock_unlock.UseVisualStyleBackColor = true;
            this.btn_lock_unlock.Click += new System.EventHandler(this.btn_lock_unlock_Click);
            // 
            // LocksControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LocksControls";
            this.Size = new System.Drawing.Size(316, 138);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LocksPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox LocksPictureBox;
        private System.Windows.Forms.Button btn_lock_unlock;
    }
}
