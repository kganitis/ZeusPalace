namespace ZeusPalace.Modules.Orders.UserControls.ChatUserControls
{
    partial class EmployeeMessageControl
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
            this.panelMessage = new System.Windows.Forms.Panel();
            this.pictureBoxEmployee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMessage
            // 
            this.panelMessage.Location = new System.Drawing.Point(55, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(225, 25);
            this.panelMessage.TabIndex = 1;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Image = global::ZeusPalace.Properties.Resources.employee_woman;
            this.pictureBoxEmployee.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEmployee.Name = "pictureBoxEmployee";
            this.pictureBoxEmployee.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxEmployee.TabIndex = 0;
            this.pictureBoxEmployee.TabStop = false;
            // 
            // EmployeeMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.pictureBoxEmployee);
            this.MaximumSize = new System.Drawing.Size(280, 400);
            this.MinimumSize = new System.Drawing.Size(280, 55);
            this.Name = "EmployeeMessageControl";
            this.Size = new System.Drawing.Size(280, 55);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEmployee;
        private System.Windows.Forms.Panel panelMessage;
    }
}
