namespace ZeusPalace.Modules.Orders
{
    partial class CustomerChatForm
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
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.panelEmployee = new System.Windows.Forms.Panel();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            this.panelEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMessages
            // 
            this.panelMessages.Location = new System.Drawing.Point(10, 60);
            this.panelMessages.Size = new System.Drawing.Size(300, 450);
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.Location = new System.Drawing.Point(66, 14);
            this.labelEmployeeName.Margin = new System.Windows.Forms.Padding(0);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(162, 22);
            this.labelEmployeeName.TabIndex = 9;
            this.labelEmployeeName.Text = "Όνομα υπαλλήλου";
            // 
            // panelEmployee
            // 
            this.panelEmployee.Controls.Add(this.pictureBoxEmployee);
            this.panelEmployee.Controls.Add(this.labelEmployeeName);
            this.panelEmployee.Location = new System.Drawing.Point(10, 10);
            this.panelEmployee.Name = "panelEmployee";
            this.panelEmployee.Size = new System.Drawing.Size(300, 50);
            this.panelEmployee.TabIndex = 10;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Image = global::ZeusPalace.Properties.Resources.employee_woman;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxEmployee.TabIndex = 8;
            this.pictureBoxEmployee.TabStop = false;
            // 
            // CustomerChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(320, 660);
            this.Controls.Add(this.panelEmployee);
            this.Name = "CustomerChatForm";
            this.Controls.SetChildIndex(this.panelMessages, 0);
            this.Controls.SetChildIndex(this.panelEmployee, 0);
            this.panelEmployee.ResumeLayout(false);
            this.panelEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.Panel panelEmployee;
        private System.Windows.Forms.Label labelEmployeeName;
    }
}
