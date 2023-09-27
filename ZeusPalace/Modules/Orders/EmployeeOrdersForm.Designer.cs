namespace ZeusPalace.Modules.Orders
{
    partial class EmployeeOrdersForm
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
            this.panelNewOrder = new System.Windows.Forms.Panel();
            this.panelChat = new System.Windows.Forms.Panel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.panelOrderControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanelOrderControls = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelNewOrder.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.panelOrderControls.SuspendLayout();
            this.tableLayoutPanelOrderControls.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNewOrder
            // 
            this.panelNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelNewOrder.Controls.Add(this.panelChat);
            this.panelNewOrder.Controls.Add(this.panelOrder);
            this.panelNewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewOrder.Location = new System.Drawing.Point(0, 0);
            this.panelNewOrder.Name = "panelNewOrder";
            this.panelNewOrder.Size = new System.Drawing.Size(1280, 660);
            this.panelNewOrder.TabIndex = 1;
            // 
            // panelChat
            // 
            this.panelChat.BackColor = System.Drawing.Color.Transparent;
            this.panelChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChat.Location = new System.Drawing.Point(960, 0);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(320, 660);
            this.panelChat.TabIndex = 1;
            // 
            // panelOrder
            // 
            this.panelOrder.BackColor = System.Drawing.Color.Transparent;
            this.panelOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelOrder.Controls.Add(this.panelOrderControls);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(960, 660);
            this.panelOrder.TabIndex = 0;
            // 
            // panelOrderControls
            // 
            this.panelOrderControls.BackColor = System.Drawing.Color.Transparent;
            this.panelOrderControls.Controls.Add(this.tableLayoutPanelOrderControls);
            this.panelOrderControls.Controls.Add(this.panelTime);
            this.panelOrderControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOrderControls.Location = new System.Drawing.Point(0, 600);
            this.panelOrderControls.Name = "panelOrderControls";
            this.panelOrderControls.Size = new System.Drawing.Size(960, 60);
            this.panelOrderControls.TabIndex = 1;
            // 
            // tableLayoutPanelOrderControls
            // 
            this.tableLayoutPanelOrderControls.ColumnCount = 5;
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33444F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11148F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOrderControls.Controls.Add(this.buttonReject, 1, 0);
            this.tableLayoutPanelOrderControls.Controls.Add(this.buttonConfirm, 3, 0);
            this.tableLayoutPanelOrderControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOrderControls.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanelOrderControls.Name = "tableLayoutPanelOrderControls";
            this.tableLayoutPanelOrderControls.RowCount = 1;
            this.tableLayoutPanelOrderControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOrderControls.Size = new System.Drawing.Size(860, 60);
            this.tableLayoutPanelOrderControls.TabIndex = 4;
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReject.Enabled = false;
            this.buttonReject.FlatAppearance.BorderSize = 0;
            this.buttonReject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReject.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonReject.Location = new System.Drawing.Point(95, 5);
            this.buttonReject.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(286, 50);
            this.buttonReject.TabIndex = 2;
            this.buttonReject.Text = "Απόρριψη παραγγελίας";
            this.buttonReject.UseVisualStyleBackColor = false;
            this.buttonReject.Visible = false;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
            this.buttonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirm.Enabled = false;
            this.buttonConfirm.FlatAppearance.BorderSize = 0;
            this.buttonConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(153)))));
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonConfirm.Location = new System.Drawing.Point(476, 5);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(286, 50);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "Επιβεβαίωση παραγγελίας";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Visible = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.Color.Transparent;
            this.panelTime.Controls.Add(this.labelTime);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTime.Location = new System.Drawing.Point(0, 0);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(100, 60);
            this.panelTime.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelTime.Location = new System.Drawing.Point(12, 17);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(62, 27);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "16:00";
            // 
            // EmployeeOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.panelNewOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.panelNewOrder.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            this.panelOrderControls.ResumeLayout(false);
            this.tableLayoutPanelOrderControls.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelOrderControls;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOrderControls;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonConfirm;
    }
}
