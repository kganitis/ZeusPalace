namespace ZeusPalace
{
    partial class TabbedForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDevices = new System.Windows.Forms.TabPage();
            this.tabPool = new System.Windows.Forms.TabPage();
            this.tabOrdering = new System.Windows.Forms.TabPage();
            this.tabDriving = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDevices);
            this.tabControl.Controls.Add(this.tabPool);
            this.tabControl.Controls.Add(this.tabDriving);
            this.tabControl.Controls.Add(this.tabOrdering);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.ItemSize = new System.Drawing.Size(318, 80);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(12, 3);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1280, 720);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // tabDevices
            // 
            this.tabDevices.Location = new System.Drawing.Point(4, 84);
            this.tabDevices.Name = "tabDevices";
            this.tabDevices.Padding = new System.Windows.Forms.Padding(3);
            this.tabDevices.Size = new System.Drawing.Size(1272, 632);
            this.tabDevices.TabIndex = 0;
            this.tabDevices.Text = "Συσκευές";
            this.tabDevices.UseVisualStyleBackColor = true;
            // 
            // tabPool
            // 
            this.tabPool.Location = new System.Drawing.Point(4, 84);
            this.tabPool.Name = "tabPool";
            this.tabPool.Padding = new System.Windows.Forms.Padding(3);
            this.tabPool.Size = new System.Drawing.Size(1272, 632);
            this.tabPool.TabIndex = 1;
            this.tabPool.Text = "Πισίνα";
            this.tabPool.UseVisualStyleBackColor = true;
            // 
            // tabOrdering
            // 
            this.tabOrdering.Location = new System.Drawing.Point(4, 84);
            this.tabOrdering.Name = "tabOrdering";
            this.tabOrdering.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrdering.Size = new System.Drawing.Size(1272, 632);
            this.tabOrdering.TabIndex = 3;
            this.tabOrdering.Text = "Παραγγείλτε";
            this.tabOrdering.UseVisualStyleBackColor = true;
            // 
            // tabDriving
            // 
            this.tabDriving.Location = new System.Drawing.Point(4, 84);
            this.tabDriving.Name = "tabDriving";
            this.tabDriving.Padding = new System.Windows.Forms.Padding(3);
            this.tabDriving.Size = new System.Drawing.Size(1272, 632);
            this.tabDriving.TabIndex = 2;
            this.tabDriving.Text = "Οδήγηση";
            this.tabDriving.UseVisualStyleBackColor = true;
            // 
            // TabbedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabbedForm";
            this.Text = "TabbedForm";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDevices;
        private System.Windows.Forms.TabPage tabPool;
        private System.Windows.Forms.TabPage tabOrdering;
        private System.Windows.Forms.TabPage tabDriving;
    }
}