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
            this.panelMenu.Controls.Add(this.buttonOrders);
            this.panelMenu.Controls.Add(this.buttonDriving);
            this.panelMenu.Controls.Add(this.buttonPool);
            this.panelMenu.Controls.Add(this.buttonDevices);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1685, 98);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonOrders.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrders.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.Location = new System.Drawing.Point(1263, 0);
            this.buttonOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonOrders.Size = new System.Drawing.Size(421, 98);
            this.buttonOrders.TabIndex = 5;
            this.buttonOrders.Text = "Παραγγελίες";
            this.buttonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonDriving
            // 
            this.buttonDriving.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDriving.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDriving.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.buttonDriving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDriving.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDriving.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDriving.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDriving.Location = new System.Drawing.Point(842, 0);
            this.buttonDriving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDriving.Name = "buttonDriving";
            this.buttonDriving.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonDriving.Size = new System.Drawing.Size(421, 98);
            this.buttonDriving.TabIndex = 4;
            this.buttonDriving.Text = "Οδήγηση";
            this.buttonDriving.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDriving.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDriving.UseVisualStyleBackColor = false;
            this.buttonDriving.Click += new System.EventHandler(this.buttonTrojanHorse_Click);
            // 
            // buttonPool
            // 
            this.buttonPool.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonPool.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPool.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.buttonPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPool.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPool.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonPool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPool.Location = new System.Drawing.Point(421, 0);
            this.buttonPool.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPool.Name = "buttonPool";
            this.buttonPool.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonPool.Size = new System.Drawing.Size(421, 98);
            this.buttonPool.TabIndex = 3;
            this.buttonPool.Text = "Πισίνα";
            this.buttonPool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPool.UseVisualStyleBackColor = false;
            this.buttonPool.Click += new System.EventHandler(this.buttonPool_Click);
            // 
            // buttonDevices
            // 
            this.buttonDevices.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDevices.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDevices.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.buttonDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevices.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDevices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDevices.Location = new System.Drawing.Point(0, 0);
            this.buttonDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDevices.Name = "buttonDevices";
            this.buttonDevices.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.buttonDevices.Size = new System.Drawing.Size(421, 98);
            this.buttonDevices.TabIndex = 2;
            this.buttonDevices.Text = "Συσκευές";
            this.buttonDevices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDevices.UseVisualStyleBackColor = false;
            this.buttonDevices.Click += new System.EventHandler(this.buttonApartment_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(0, 98);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1685, 740);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Το Παλάτι του Δία";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonDriving;
        private System.Windows.Forms.Button buttonPool;
        private System.Windows.Forms.Button buttonDevices;
    }
}