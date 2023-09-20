namespace ZeusPalace.Modules.Orders.UserControls
{
    partial class OrderPanelCreditCardControl
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
            this.components = new System.ComponentModel.Container();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelExpDate = new System.Windows.Forms.Label();
            this.labelCVV = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.textBoxExpDate = new System.Windows.Forms.TextBox();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTipCVV = new System.Windows.Forms.ToolTip(this.components);
            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.textBoxCardNumber);
            this.panelMain.Controls.Add(this.textBoxExpDate);
            this.panelMain.Controls.Add(this.textBoxCVV);
            this.panelMain.Controls.Add(this.textBoxName);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.labelName);
            this.panelMain.Controls.Add(this.labelCVV);
            this.panelMain.Controls.Add(this.labelExpDate);
            this.panelMain.Controls.Add(this.labelCardNumber);
            // 
            // labelTitle
            // 
            this.labelTitle.Visible = false;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCardNumber.Location = new System.Drawing.Point(236, 102);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(124, 22);
            this.labelCardNumber.TabIndex = 0;
            this.labelCardNumber.Text = "Αριθμός κάρτας";
            // 
            // labelExpDate
            // 
            this.labelExpDate.AutoSize = true;
            this.labelExpDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpDate.Location = new System.Drawing.Point(236, 152);
            this.labelExpDate.Name = "labelExpDate";
            this.labelExpDate.Size = new System.Drawing.Size(156, 22);
            this.labelExpDate.TabIndex = 1;
            this.labelExpDate.Text = "Μήνας / Έτος λήξης";
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCVV.Location = new System.Drawing.Point(236, 202);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(43, 22);
            this.labelCVV.TabIndex = 2;
            this.labelCVV.Text = "CVV";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(236, 252);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(195, 22);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Ονοματεπώνυμο κατόχου";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(519, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Όλα τα πεδία είναι υποχρεωτικά";
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(437, 252);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(253, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCVV.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCVV.Location = new System.Drawing.Point(437, 202);
            this.textBoxCVV.MaxLength = 3;
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(253, 22);
            this.textBoxCVV.TabIndex = 6;
            // 
            // textBoxExpDate
            // 
            this.textBoxExpDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExpDate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExpDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxExpDate.Location = new System.Drawing.Point(437, 152);
            this.textBoxExpDate.MaxLength = 5;
            this.textBoxExpDate.Name = "textBoxExpDate";
            this.textBoxExpDate.Size = new System.Drawing.Size(253, 22);
            this.textBoxExpDate.TabIndex = 7;
            this.textBoxExpDate.Tag = "MM/EE";
            this.textBoxExpDate.Text = "MM/EE";
            this.textBoxExpDate.TextChanged += new System.EventHandler(this.textBoxExpDate_TextChanged);
            this.textBoxExpDate.Enter += new System.EventHandler(this.textBoxExpDate_Enter);
            this.textBoxExpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxExpDate_KeyDown);
            this.textBoxExpDate.Leave += new System.EventHandler(this.textBoxExpDate_Leave);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCardNumber.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCardNumber.Location = new System.Drawing.Point(437, 102);
            this.textBoxCardNumber.MaxLength = 19;
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(253, 22);
            this.textBoxCardNumber.TabIndex = 8;
            this.textBoxCardNumber.TextChanged += new System.EventHandler(this.textBoxCardNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "(τι είναι;)";
            this.toolTipCVV.SetToolTip(this.label2, "O 3-ψηφιος αριθμός στο πίσω μέρος της κάρτας σας");
            // 
            // OrderPanelCreditCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "OrderPanelCreditCardControl";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.Label labelExpDate;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.TextBox textBoxExpDate;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipCVV;
    }
}
