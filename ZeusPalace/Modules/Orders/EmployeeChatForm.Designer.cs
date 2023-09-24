namespace ZeusPalace.Modules.Orders
{
    partial class EmployeeChatForm
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxTypeMessage
            // 
            this.richTextBoxTypeMessage.BackColor = System.Drawing.Color.Honeydew;
            // 
            // pictureBoxEmployee
            // 
            this.pictureBoxEmployee.Visible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(9, 14);
            this.labelUsername.Size = new System.Drawing.Size(127, 22);
            this.labelUsername.Text = "Όνομα πελάτη";
            // 
            // EmployeeChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(320, 660);
            this.Name = "EmployeeChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
