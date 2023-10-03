using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders.UserControls.ChatUserControls
{
    partial class CustomerMessageControl
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
            this.SuspendLayout();
            // 
            // panelMessage
            // 
            this.panelMessage.Location = new System.Drawing.Point(0, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(280, 25);
            this.panelMessage.TabIndex = 0;
            // 
            // CustomerMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.Controls.Add(this.panelMessage);
            this.MaximumSize = new System.Drawing.Size(280, 300);
            this.MinimumSize = new System.Drawing.Size(280, 30);
            this.Name = "CustomerMessageControl";
            this.Size = new System.Drawing.Size(280, 30);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMessage;
    }
}
