namespace ZeusPalace.Modules.Orders.UserControls
{
    partial class MenuCategoryControl
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
            this.labelCategory1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCategory1
            // 
            this.labelCategory1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCategory1.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.labelCategory1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelCategory1.Location = new System.Drawing.Point(0, 0);
            this.labelCategory1.Name = "labelCategory1";
            this.labelCategory1.Size = new System.Drawing.Size(400, 35);
            this.labelCategory1.TabIndex = 4;
            this.labelCategory1.Text = "Κατηγορία";
            this.labelCategory1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MenuCategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCategory1);
            this.Name = "MenuCategoryControl";
            this.Size = new System.Drawing.Size(400, 35);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCategory1;
    }
}
