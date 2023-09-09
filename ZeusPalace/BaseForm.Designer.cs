namespace ZeusPalace
{
    partial class BaseForm
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.buttonApartment = new System.Windows.Forms.Button();
            this.buttonPool = new System.Windows.Forms.Button();
            this.buttonTrojanHorse = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonOrders);
            this.panelMenu.Controls.Add(this.buttonTrojanHorse);
            this.panelMenu.Controls.Add(this.buttonPool);
            this.panelMenu.Controls.Add(this.buttonApartment);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1044, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1044, 601);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(469, 39);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogo
            // 
            this.labelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogo.AutoSize = true;
            this.labelLogo.Location = new System.Drawing.Point(55, 39);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(98, 13);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "Το Παλάτι του Δία";
            this.labelLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonApartment
            // 
            this.buttonApartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonApartment.FlatAppearance.BorderSize = 0;
            this.buttonApartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApartment.Location = new System.Drawing.Point(0, 80);
            this.buttonApartment.Name = "buttonApartment";
            this.buttonApartment.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonApartment.Size = new System.Drawing.Size(220, 60);
            this.buttonApartment.TabIndex = 1;
            this.buttonApartment.Text = "Διαμέρισμα";
            this.buttonApartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonApartment.UseVisualStyleBackColor = true;
            // 
            // buttonPool
            // 
            this.buttonPool.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPool.FlatAppearance.BorderSize = 0;
            this.buttonPool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPool.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPool.Location = new System.Drawing.Point(0, 140);
            this.buttonPool.Name = "buttonPool";
            this.buttonPool.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonPool.Size = new System.Drawing.Size(220, 60);
            this.buttonPool.TabIndex = 2;
            this.buttonPool.Text = "Πισίνα";
            this.buttonPool.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPool.UseVisualStyleBackColor = true;
            // 
            // buttonTrojanHorse
            // 
            this.buttonTrojanHorse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTrojanHorse.FlatAppearance.BorderSize = 0;
            this.buttonTrojanHorse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrojanHorse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTrojanHorse.Location = new System.Drawing.Point(0, 200);
            this.buttonTrojanHorse.Name = "buttonTrojanHorse";
            this.buttonTrojanHorse.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonTrojanHorse.Size = new System.Drawing.Size(220, 60);
            this.buttonTrojanHorse.TabIndex = 3;
            this.buttonTrojanHorse.Text = "Δούρειος Ίππος";
            this.buttonTrojanHorse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTrojanHorse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTrojanHorse.UseVisualStyleBackColor = true;
            // 
            // buttonOrders
            // 
            this.buttonOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.Location = new System.Drawing.Point(0, 260);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonOrders.Size = new System.Drawing.Size(220, 60);
            this.buttonOrders.TabIndex = 4;
            this.buttonOrders.Text = "Παραγγελίες";
            this.buttonOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "BaseForm";
            this.Text = "Το Παλάτι του Δία";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Button buttonApartment;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonTrojanHorse;
        private System.Windows.Forms.Button buttonPool;
    }
}