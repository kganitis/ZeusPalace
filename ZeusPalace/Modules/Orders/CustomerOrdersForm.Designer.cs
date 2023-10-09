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
            this.components = new System.ComponentModel.Container();
            this.panelNewOrder = new System.Windows.Forms.Panel();
            this.panelChat = new System.Windows.Forms.Panel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonOrderReview = new System.Windows.Forms.Button();
            this.buttonOrderEdit = new System.Windows.Forms.Button();
            this.panelOrderControls = new System.Windows.Forms.Panel();
            this.tableLayoutPanelOrderControls = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOrderCancel = new System.Windows.Forms.Button();
            this.buttonNextStep = new ZeusPalace.Modules.Orders.UserControls.DoubleButton();
            this.panelTime = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelMenu = new ZeusPalace.Modules.Orders.UserControls.OrderPanelTableControl();
            this.timerOrderPreparing = new System.Windows.Forms.Timer(this.components);
            this.timerOrderDelivering = new System.Windows.Forms.Timer(this.components);
            this.timerPaymentSuccessful = new System.Windows.Forms.Timer(this.components);
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
            this.panelNewOrder.TabIndex = 0;
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
            this.panelOrder.Controls.Add(this.buttonNewOrder);
            this.panelOrder.Controls.Add(this.buttonOrderReview);
            this.panelOrder.Controls.Add(this.buttonOrderEdit);
            this.panelOrder.Controls.Add(this.panelOrderControls);
            this.panelOrder.Controls.Add(this.panelMenu);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(960, 660);
            this.panelOrder.TabIndex = 0;
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(112)))));
            this.buttonNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewOrder.FlatAppearance.BorderSize = 0;
            this.buttonNewOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewOrder.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.buttonNewOrder.Location = new System.Drawing.Point(337, 504);
            this.buttonNewOrder.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(286, 50);
            this.buttonNewOrder.TabIndex = 7;
            this.buttonNewOrder.Text = "Νέα παραγγελία";
            this.buttonNewOrder.UseVisualStyleBackColor = false;
            this.buttonNewOrder.Visible = false;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // buttonOrderReview
            // 
            this.buttonOrderReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOrderReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(198)))), ((int)(((byte)(191)))));
            this.buttonOrderReview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderReview.FlatAppearance.BorderSize = 0;
            this.buttonOrderReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderReview.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonOrderReview.Location = new System.Drawing.Point(576, 567);
            this.buttonOrderReview.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonOrderReview.Name = "buttonOrderReview";
            this.buttonOrderReview.Size = new System.Drawing.Size(286, 25);
            this.buttonOrderReview.TabIndex = 6;
            this.buttonOrderReview.Text = "Προβολή παραγγελίας";
            this.buttonOrderReview.UseVisualStyleBackColor = false;
            this.buttonOrderReview.Visible = false;
            // 
            // buttonOrderEdit
            // 
            this.buttonOrderEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOrderEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(198)))), ((int)(((byte)(191)))));
            this.buttonOrderEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderEdit.FlatAppearance.BorderSize = 0;
            this.buttonOrderEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderEdit.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonOrderEdit.Location = new System.Drawing.Point(195, 567);
            this.buttonOrderEdit.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonOrderEdit.Name = "buttonOrderEdit";
            this.buttonOrderEdit.Size = new System.Drawing.Size(286, 25);
            this.buttonOrderEdit.TabIndex = 4;
            this.buttonOrderEdit.Text = "Επεξεργασία παραγγελίας";
            this.buttonOrderEdit.UseVisualStyleBackColor = false;
            this.buttonOrderEdit.Visible = false;
            this.buttonOrderEdit.Click += new System.EventHandler(this.buttonOrderEdit_Click);
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
            this.tableLayoutPanelOrderControls.Controls.Add(this.buttonOrderCancel, 1, 0);
            this.tableLayoutPanelOrderControls.Controls.Add(this.buttonNextStep, 3, 0);
            this.tableLayoutPanelOrderControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOrderControls.Location = new System.Drawing.Point(100, 0);
            this.tableLayoutPanelOrderControls.Name = "tableLayoutPanelOrderControls";
            this.tableLayoutPanelOrderControls.RowCount = 1;
            this.tableLayoutPanelOrderControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOrderControls.Size = new System.Drawing.Size(860, 60);
            this.tableLayoutPanelOrderControls.TabIndex = 4;
            // 
            // buttonOrderCancel
            // 
            this.buttonOrderCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonOrderCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrderCancel.FlatAppearance.BorderSize = 0;
            this.buttonOrderCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.buttonOrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderCancel.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.buttonOrderCancel.Location = new System.Drawing.Point(95, 5);
            this.buttonOrderCancel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonOrderCancel.Name = "buttonOrderCancel";
            this.buttonOrderCancel.Size = new System.Drawing.Size(286, 50);
            this.buttonOrderCancel.TabIndex = 2;
            this.buttonOrderCancel.Text = "Ακύρωση παραγγελίας";
            this.buttonOrderCancel.UseVisualStyleBackColor = false;
            this.buttonOrderCancel.Visible = false;
            this.buttonOrderCancel.Click += new System.EventHandler(this.buttonOrderCancel_Click);
            // 
            // buttonNextStep
            // 
            this.buttonNextStep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNextStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextStep.DefaultColor = System.Drawing.Color.Empty;
            this.buttonNextStep.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNextStep.Location = new System.Drawing.Point(476, 5);
            this.buttonNextStep.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNextStep.Name = "buttonNextStep";
            this.buttonNextStep.Size = new System.Drawing.Size(286, 50);
            this.buttonNextStep.TabIndex = 3;
            this.buttonNextStep.TextLeft = "";
            this.buttonNextStep.TextRight = "";
            this.buttonNextStep.Visible = false;
            this.buttonNextStep.Click += new System.EventHandler(this.buttonNextStep_Click);
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
            this.labelTime.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelTime.Location = new System.Drawing.Point(20, 17);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(57, 27);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "16:00";
            // 
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(960, 600);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.Title = "Μενού ημέρας";
            // 
            // timerOrderPreparing
            // 
            this.timerOrderPreparing.Interval = 10000;
            this.timerOrderPreparing.Tick += new System.EventHandler(this.timerOrderPreparing_Tick);
            // 
            // timerOrderDelivering
            // 
            this.timerOrderDelivering.Interval = 10000;
            this.timerOrderDelivering.Tick += new System.EventHandler(this.timerOrderDelivering_Tick);
            // 
            // timerPaymentSuccessful
            // 
            this.timerPaymentSuccessful.Interval = 3000;
            this.timerPaymentSuccessful.Tick += new System.EventHandler(this.timerPaymentSuccessful_Tick);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNewOrder;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelOrderControls;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonOrderCancel;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOrderControls;
        private System.Windows.Forms.Button buttonOrderEdit;
        private UserControls.OrderPanelTableControl panelMenu;
        private System.Windows.Forms.Timer timerOrderPreparing;
        private System.Windows.Forms.Timer timerOrderDelivering;
        private System.Windows.Forms.Button buttonOrderReview;
        private System.Windows.Forms.Timer timerPaymentSuccessful;
        private System.Windows.Forms.Button buttonNewOrder;
        private UserControls.DoubleButton buttonNextStep;
    }
}