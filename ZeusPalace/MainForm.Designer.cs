namespace ZeusPalace
{
    partial class MainForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonDriving = new System.Windows.Forms.Button();
            this.buttonPool = new System.Windows.Forms.Button();
            this.buttonDevices = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.panelMenu.Controls.Add(this.buttonOrders);
            this.panelMenu.Controls.Add(this.buttonDriving);
            this.panelMenu.Controls.Add(this.buttonPool);
            this.panelMenu.Controls.Add(this.buttonDevices);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1280, 60);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(112)))));
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(140)))));
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.Location = new System.Drawing.Point(960, 0);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonOrders.Size = new System.Drawing.Size(320, 60);
            this.buttonOrders.TabIndex = 5;
            this.buttonOrders.Text = "Παραγγελίες";
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonDriving
            // 
            this.buttonDriving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(112)))));
            this.buttonDriving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDriving.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDriving.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(140)))));
            this.buttonDriving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDriving.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDriving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.buttonDriving.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDriving.Location = new System.Drawing.Point(640, 0);
            this.buttonDriving.Name = "buttonDriving";
            this.buttonDriving.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonDriving.Size = new System.Drawing.Size(320, 60);
            this.buttonDriving.TabIndex = 4;
            this.buttonDriving.Text = "Οδήγηση";
            this.buttonDriving.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDriving.UseVisualStyleBackColor = false;
            this.buttonDriving.Click += new System.EventHandler(this.buttonTrojanHorse_Click);
            // 
            // buttonPool
            // 
            this.buttonPool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(112)))));
            this.buttonPool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPool.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPool.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(140)))));
            this.buttonPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPool.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.buttonPool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPool.Location = new System.Drawing.Point(320, 0);
            this.buttonPool.Name = "buttonPool";
            this.buttonPool.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonPool.Size = new System.Drawing.Size(320, 60);
            this.buttonPool.TabIndex = 3;
            this.buttonPool.Text = "Πισίνα";
            this.buttonPool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPool.UseVisualStyleBackColor = false;
            this.buttonPool.Click += new System.EventHandler(this.buttonPool_Click);
            // 
            // buttonDevices
            // 
            this.buttonDevices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(112)))));
            this.buttonDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDevices.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDevices.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(99)))), ((int)(((byte)(140)))));
            this.buttonDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevices.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.buttonDevices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDevices.Location = new System.Drawing.Point(0, 0);
            this.buttonDevices.Name = "buttonDevices";
            this.buttonDevices.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonDevices.Size = new System.Drawing.Size(320, 60);
            this.buttonDevices.TabIndex = 2;
            this.buttonDevices.Text = "Συσκευές";
            this.buttonDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDevices.UseVisualStyleBackColor = false;
            this.buttonDevices.Click += new System.EventHandler(this.buttonApartment_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(0, 60);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1280, 660);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Το Παλάτι του Δία";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button buttonDriving;
        private System.Windows.Forms.Button buttonPool;
        private System.Windows.Forms.Button buttonDevices;
        private System.Windows.Forms.Button buttonOrders;
    }
}