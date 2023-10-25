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
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDevices = new System.Windows.Forms.Button();
            this.buttonPool = new System.Windows.Forms.Button();
            this.buttonTrojanHorse = new System.Windows.Forms.Button();
            this.buttonOnlineHelp = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.panelDesktopPane.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.panelDesktopPane.Controls.Add(this.buttonOrders);
            this.panelDesktopPane.Location = new System.Drawing.Point(0, 60);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1280, 660);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMenu.BackgroundImage = global::ZeusPalace.Properties.Resources.background_menu;
            this.flowLayoutPanelMenu.Controls.Add(this.buttonDevices);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonPool);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonTrojanHorse);
            this.flowLayoutPanelMenu.Controls.Add(this.buttonOnlineHelp);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(1280, 60);
            this.flowLayoutPanelMenu.TabIndex = 6;
            // 
            // buttonDevices
            // 
            this.buttonDevices.BackColor = System.Drawing.Color.Transparent;
            this.buttonDevices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDevices.FlatAppearance.BorderSize = 0;
            this.buttonDevices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevices.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonDevices.Image = global::ZeusPalace.Properties.Resources.devices_icon;
            this.buttonDevices.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDevices.Location = new System.Drawing.Point(0, 0);
            this.buttonDevices.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDevices.Name = "buttonDevices";
            this.buttonDevices.Size = new System.Drawing.Size(320, 60);
            this.buttonDevices.TabIndex = 2;
            this.buttonDevices.Text = "Συσκευές";
            this.buttonDevices.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDevices.UseVisualStyleBackColor = false;
            this.buttonDevices.Visible = false;
            this.buttonDevices.Click += new System.EventHandler(this.buttonDevices_Click);
            this.buttonDevices.MouseEnter += new System.EventHandler(this.buttonMenu_MouseEnter);
            this.buttonDevices.MouseLeave += new System.EventHandler(this.buttonMenu_MouseLeave);
            // 
            // buttonPool
            // 
            this.buttonPool.BackColor = System.Drawing.Color.Transparent;
            this.buttonPool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPool.FlatAppearance.BorderSize = 0;
            this.buttonPool.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPool.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonPool.Image = global::ZeusPalace.Properties.Resources.pool_icon;
            this.buttonPool.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonPool.Location = new System.Drawing.Point(320, 0);
            this.buttonPool.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPool.Name = "buttonPool";
            this.buttonPool.Size = new System.Drawing.Size(320, 60);
            this.buttonPool.TabIndex = 3;
            this.buttonPool.Text = "Πισίνα";
            this.buttonPool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPool.UseVisualStyleBackColor = false;
            this.buttonPool.Visible = false;
            this.buttonPool.Click += new System.EventHandler(this.buttonPool_Click);
            this.buttonPool.MouseEnter += new System.EventHandler(this.buttonMenu_MouseEnter);
            this.buttonPool.MouseLeave += new System.EventHandler(this.buttonMenu_MouseLeave);
            // 
            // buttonTrojanHorse
            // 
            this.buttonTrojanHorse.BackColor = System.Drawing.Color.Transparent;
            this.buttonTrojanHorse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTrojanHorse.FlatAppearance.BorderSize = 0;
            this.buttonTrojanHorse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonTrojanHorse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrojanHorse.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrojanHorse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonTrojanHorse.Image = global::ZeusPalace.Properties.Resources.trojanhorse_icon;
            this.buttonTrojanHorse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonTrojanHorse.Location = new System.Drawing.Point(640, 0);
            this.buttonTrojanHorse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTrojanHorse.Name = "buttonTrojanHorse";
            this.buttonTrojanHorse.Size = new System.Drawing.Size(320, 60);
            this.buttonTrojanHorse.TabIndex = 4;
            this.buttonTrojanHorse.Text = "Δούρειος Ίππος";
            this.buttonTrojanHorse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTrojanHorse.UseVisualStyleBackColor = false;
            this.buttonTrojanHorse.Visible = false;
            this.buttonTrojanHorse.Click += new System.EventHandler(this.buttonTrojanHorse_Click);
            this.buttonTrojanHorse.MouseEnter += new System.EventHandler(this.buttonMenu_MouseEnter);
            this.buttonTrojanHorse.MouseLeave += new System.EventHandler(this.buttonMenu_MouseLeave);
            // 
            // buttonOnlineHelp
            // 
            this.buttonOnlineHelp.BackColor = System.Drawing.Color.Transparent;
            this.buttonOnlineHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOnlineHelp.FlatAppearance.BorderSize = 0;
            this.buttonOnlineHelp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOnlineHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOnlineHelp.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOnlineHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonOnlineHelp.Image = global::ZeusPalace.Properties.Resources.help;
            this.buttonOnlineHelp.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOnlineHelp.Location = new System.Drawing.Point(960, 0);
            this.buttonOnlineHelp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOnlineHelp.Name = "buttonOnlineHelp";
            this.buttonOnlineHelp.Size = new System.Drawing.Size(320, 60);
            this.buttonOnlineHelp.TabIndex = 6;
            this.buttonOnlineHelp.Text = "  Βοήθεια";
            this.buttonOnlineHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOnlineHelp.UseVisualStyleBackColor = false;
            this.buttonOnlineHelp.Visible = false;
            this.buttonOnlineHelp.Click += new System.EventHandler(this.buttonOnlineHelp_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.Transparent;
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonOrders.Image = global::ZeusPalace.Properties.Resources.orders_icon;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOrders.Location = new System.Drawing.Point(0, 60);
            this.buttonOrders.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(320, 60);
            this.buttonOrders.TabIndex = 5;
            this.buttonOrders.Text = "Εστιατόριο";
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Visible = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            this.buttonOrders.MouseEnter += new System.EventHandler(this.buttonMenu_MouseEnter);
            this.buttonOrders.MouseLeave += new System.EventHandler(this.buttonMenu_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.panelDesktopPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Το Παλάτι του Δία";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panelDesktopPane.ResumeLayout(false);
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button buttonTrojanHorse;
        private System.Windows.Forms.Button buttonPool;
        private System.Windows.Forms.Button buttonDevices;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Button buttonOnlineHelp;
    }
}