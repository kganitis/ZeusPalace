namespace ZeusPalace.Modules.Orders
{
    partial class CustomerOrdersForm
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
            this.buttonTotalPrice = new System.Windows.Forms.Button();
            this.buttonOrderNextStep = new System.Windows.Forms.Button();
            this.buttonOrderCancel = new System.Windows.Forms.Button();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelOrderTitle = new System.Windows.Forms.Panel();
            this.labelOrderTitle = new System.Windows.Forms.Label();
            this.panelNewOrder.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.panelOrderControls.SuspendLayout();
            this.tableLayoutPanelOrderControls.SuspendLayout();
            this.panelTime.SuspendLayout();
            this.panelOrderTitle.SuspendLayout();
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
            this.panelNewOrder.TabIndex = 0;
            // 
            // panelChat
            // 
            this.panelChat.BackColor = System.Drawing.Color.Transparent;
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
            this.panelOrder.Controls.Add(this.panelMenu);
            this.panelOrder.Controls.Add(this.panelOrderTitle);
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
            this.tableLayoutPanelOrderControls.ColumnCount = 6;
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.002F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33133F));
            this.tableLayoutPanelOrderControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOrderControls.Controls.Add(this.buttonTotalPrice, 4, 0);
            this.tableLayoutPanelOrderControls.Controls.Add(this.buttonOrderNextStep, 3, 0);
            this.tableLayoutPanelOrderControls.Controls.Add(this.buttonOrderCancel, 1, 0);
            this.tableLayoutPanelOrderControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOrderControls.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanelOrderControls.Name = "tableLayoutPanelOrderControls";
            this.tableLayoutPanelOrderControls.RowCount = 1;
            this.tableLayoutPanelOrderControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOrderControls.Size = new System.Drawing.Size(860, 60);
            this.tableLayoutPanelOrderControls.TabIndex = 4;
            // 
            // buttonTotalPrice
            // 
            this.buttonTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
            this.buttonTotalPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTotalPrice.FlatAppearance.BorderSize = 0;
            this.buttonTotalPrice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(145)))));
            this.buttonTotalPrice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(145)))));
            this.buttonTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTotalPrice.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonTotalPrice.Location = new System.Drawing.Point(648, 5);
            this.buttonTotalPrice.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonTotalPrice.Name = "buttonTotalPrice";
            this.buttonTotalPrice.Size = new System.Drawing.Size(114, 50);
            this.buttonTotalPrice.TabIndex = 2;
            this.buttonTotalPrice.TabStop = false;
            this.buttonTotalPrice.Text = "0.00 €";
            this.buttonTotalPrice.UseVisualStyleBackColor = false;
            this.buttonTotalPrice.Click += new System.EventHandler(this.buttonTotalPrice_Click);
            this.buttonTotalPrice.MouseEnter += new System.EventHandler(this.buttonNextStep_MouseEnter);
            this.buttonTotalPrice.MouseLeave += new System.EventHandler(this.buttonNextStep_MouseLeave);
            // 
            // buttonOrderNextStep
            // 
            this.buttonOrderNextStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(139)))));
            this.buttonOrderNextStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderNextStep.FlatAppearance.BorderSize = 0;
            this.buttonOrderNextStep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(145)))));
            this.buttonOrderNextStep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(180)))), ((int)(((byte)(145)))));
            this.buttonOrderNextStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderNextStep.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderNextStep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonOrderNextStep.Location = new System.Drawing.Point(476, 5);
            this.buttonOrderNextStep.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonOrderNextStep.Name = "buttonOrderNextStep";
            this.buttonOrderNextStep.Size = new System.Drawing.Size(172, 50);
            this.buttonOrderNextStep.TabIndex = 1;
            this.buttonOrderNextStep.TabStop = false;
            this.buttonOrderNextStep.Text = "Συνέχεια";
            this.buttonOrderNextStep.UseVisualStyleBackColor = false;
            this.buttonOrderNextStep.Click += new System.EventHandler(this.buttonOrderNextStep_Click);
            this.buttonOrderNextStep.MouseEnter += new System.EventHandler(this.buttonNextStep_MouseEnter);
            this.buttonOrderNextStep.MouseLeave += new System.EventHandler(this.buttonNextStep_MouseLeave);
            // 
            // buttonOrderCancel
            // 
            this.buttonOrderCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonOrderCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderCancel.FlatAppearance.BorderSize = 0;
            this.buttonOrderCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.buttonOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderCancel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonOrderCancel.Location = new System.Drawing.Point(95, 5);
            this.buttonOrderCancel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonOrderCancel.Name = "buttonOrderCancel";
            this.buttonOrderCancel.Size = new System.Drawing.Size(286, 50);
            this.buttonOrderCancel.TabIndex = 2;
            this.buttonOrderCancel.Text = "Ακύρωση παραγγελίας";
            this.buttonOrderCancel.UseVisualStyleBackColor = false;
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
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(960, 540);
            this.panelMenu.TabIndex = 0;
            // 
            // panelOrderTitle
            // 
            this.panelOrderTitle.Controls.Add(this.labelOrderTitle);
            this.panelOrderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOrderTitle.Location = new System.Drawing.Point(0, 0);
            this.panelOrderTitle.Name = "panelOrderTitle";
            this.panelOrderTitle.Size = new System.Drawing.Size(960, 60);
            this.panelOrderTitle.TabIndex = 0;
            // 
            // labelOrderTitle
            // 
            this.labelOrderTitle.AutoSize = true;
            this.labelOrderTitle.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderTitle.Location = new System.Drawing.Point(376, 12);
            this.labelOrderTitle.Name = "labelOrderTitle";
            this.labelOrderTitle.Size = new System.Drawing.Size(196, 35);
            this.labelOrderTitle.TabIndex = 0;
            this.labelOrderTitle.Text = "Μενού ημέρας";
            // 
            // CustomerOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 660);
            this.Controls.Add(this.panelNewOrder);
            this.Name = "CustomerOrdersForm";
            this.panelNewOrder.ResumeLayout(false);
            this.panelOrder.ResumeLayout(false);
            this.panelOrderControls.ResumeLayout(false);
            this.tableLayoutPanelOrderControls.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            this.panelOrderTitle.ResumeLayout(false);
            this.panelOrderTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelOrderControls;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonOrderCancel;
        private System.Windows.Forms.Button buttonOrderNextStep;
        private System.Windows.Forms.Button buttonTotalPrice;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOrderControls;
        private System.Windows.Forms.Panel panelOrderTitle;
        private System.Windows.Forms.Label labelOrderTitle;
    }
}