namespace ZeusPalace.Modules.Orders.UserControls
{
    partial class OrderPanelPaymentControl
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
            this.labelChoosePaymentMethod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCreditCard = new System.Windows.Forms.RadioButton();
            this.radioButtonAddToAccount = new System.Windows.Forms.RadioButton();
            this.radioButtonTakeAway = new System.Windows.Forms.RadioButton();
            this.radioButtonAppartment = new System.Windows.Forms.RadioButton();
            this.radioButtonPool = new System.Windows.Forms.RadioButton();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.panelPaymentMethod = new System.Windows.Forms.Panel();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panelDeliveryMethod = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelPaymentMethod.SuspendLayout();
            this.panelDeliveryMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelDeliveryMethod);
            this.panelMain.Controls.Add(this.panelPaymentMethod);
            // 
            // panelTitle
            // 
            this.panelTitle.Size = new System.Drawing.Size(960, 136);
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(431, 50);
            this.labelTitle.Size = new System.Drawing.Size(458, 35);
            this.labelTitle.Text = "Η παραγγελία σας επιβεβαιώθηκε!";
            // 
            // labelChoosePaymentMethod
            // 
            this.labelChoosePaymentMethod.AutoSize = true;
            this.labelChoosePaymentMethod.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoosePaymentMethod.Location = new System.Drawing.Point(144, 43);
            this.labelChoosePaymentMethod.Name = "labelChoosePaymentMethod";
            this.labelChoosePaymentMethod.Size = new System.Drawing.Size(345, 35);
            this.labelChoosePaymentMethod.TabIndex = 3;
            this.labelChoosePaymentMethod.Text = "Επιλέξτε τρόπο πληρωμής";
            // 
            // labelUsername
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 45);
            this.label1.Name = "labelUsername";
            this.label1.Size = new System.Drawing.Size(363, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Επιλέξτε τρόπο παραλαβής";
            // 
            // radioButtonCreditCard
            // 
            this.radioButtonCreditCard.AutoSize = true;
            this.radioButtonCreditCard.Checked = true;
            this.radioButtonCreditCard.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCreditCard.Location = new System.Drawing.Point(556, 55);
            this.radioButtonCreditCard.Name = "radioButtonCreditCard";
            this.radioButtonCreditCard.Size = new System.Drawing.Size(257, 22);
            this.radioButtonCreditCard.TabIndex = 5;
            this.radioButtonCreditCard.TabStop = true;
            this.radioButtonCreditCard.Text = "Πληρωμή με κάρτα στο επόμενο βήμα";
            this.radioButtonCreditCard.UseVisualStyleBackColor = true;
            this.radioButtonCreditCard.CheckedChanged += new System.EventHandler(this.radioButtonCreditCard_CheckedChanged);
            // 
            // radioButtonAddToAccount
            // 
            this.radioButtonAddToAccount.AutoSize = true;
            this.radioButtonAddToAccount.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAddToAccount.Location = new System.Drawing.Point(556, 119);
            this.radioButtonAddToAccount.Name = "radioButtonAddToAccount";
            this.radioButtonAddToAccount.Size = new System.Drawing.Size(245, 22);
            this.radioButtonAddToAccount.TabIndex = 6;
            this.radioButtonAddToAccount.TabStop = true;
            this.radioButtonAddToAccount.Text = "Προσθήκη στον γενικό λογαριασμό";
            this.radioButtonAddToAccount.UseVisualStyleBackColor = true;
            this.radioButtonAddToAccount.CheckedChanged += new System.EventHandler(this.radioButtonAddToAccount_CheckedChanged);
            // 
            // radioButtonTakeAway
            // 
            this.radioButtonTakeAway.AutoSize = true;
            this.radioButtonTakeAway.Checked = true;
            this.radioButtonTakeAway.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTakeAway.Location = new System.Drawing.Point(556, 57);
            this.radioButtonTakeAway.Name = "radioButtonTakeAway";
            this.radioButtonTakeAway.Size = new System.Drawing.Size(266, 22);
            this.radioButtonTakeAway.TabIndex = 7;
            this.radioButtonTakeAway.TabStop = true;
            this.radioButtonTakeAway.Text = "Παραλαβή από εστιατόριο (take-away)";
            this.radioButtonTakeAway.UseVisualStyleBackColor = true;
            // 
            // radioButtonAppartment
            // 
            this.radioButtonAppartment.AutoSize = true;
            this.radioButtonAppartment.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAppartment.Location = new System.Drawing.Point(556, 89);
            this.radioButtonAppartment.Name = "radioButtonAppartment";
            this.radioButtonAppartment.Size = new System.Drawing.Size(190, 22);
            this.radioButtonAppartment.TabIndex = 8;
            this.radioButtonAppartment.TabStop = true;
            this.radioButtonAppartment.Text = "Παράδοση στο διαμέρισμα";
            this.radioButtonAppartment.UseVisualStyleBackColor = true;
            // 
            // radioButtonPool
            // 
            this.radioButtonPool.AutoSize = true;
            this.radioButtonPool.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPool.Location = new System.Drawing.Point(556, 121);
            this.radioButtonPool.Name = "radioButtonPool";
            this.radioButtonPool.Size = new System.Drawing.Size(227, 22);
            this.radioButtonPool.TabIndex = 9;
            this.radioButtonPool.TabStop = true;
            this.radioButtonPool.Text = "Παράδοση στην κεντρική πισίνα";
            this.radioButtonPool.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCash.Location = new System.Drawing.Point(556, 87);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(211, 22);
            this.radioButtonCash.TabIndex = 10;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Πληρωμή κατά την παράδοση";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // panelPaymentMethod
            // 
            this.panelPaymentMethod.Controls.Add(this.labelBalance);
            this.panelPaymentMethod.Controls.Add(this.radioButtonCash);
            this.panelPaymentMethod.Controls.Add(this.labelChoosePaymentMethod);
            this.panelPaymentMethod.Controls.Add(this.radioButtonCreditCard);
            this.panelPaymentMethod.Controls.Add(this.radioButtonAddToAccount);
            this.panelPaymentMethod.Location = new System.Drawing.Point(0, 42);
            this.panelPaymentMethod.Name = "panelPaymentMethod";
            this.panelPaymentMethod.Size = new System.Drawing.Size(960, 180);
            this.panelPaymentMethod.TabIndex = 11;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(572, 144);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(140, 18);
            this.labelBalance.TabIndex = 11;
            this.labelBalance.Text = "Νέο υπόλοιπο: 0.00 €";
            this.labelBalance.Visible = false;
            // 
            // panelDeliveryMethod
            // 
            this.panelDeliveryMethod.Controls.Add(this.radioButtonTakeAway);
            this.panelDeliveryMethod.Controls.Add(this.label1);
            this.panelDeliveryMethod.Controls.Add(this.radioButtonPool);
            this.panelDeliveryMethod.Controls.Add(this.radioButtonAppartment);
            this.panelDeliveryMethod.Location = new System.Drawing.Point(0, 237);
            this.panelDeliveryMethod.Name = "panelDeliveryMethod";
            this.panelDeliveryMethod.Size = new System.Drawing.Size(960, 180);
            this.panelDeliveryMethod.TabIndex = 12;
            // 
            // OrderPanelPaymentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "OrderPanelPaymentControl";
            this.Title = "Η παραγγελία σας επιβεβαιώθηκε!";
            this.panelMain.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelPaymentMethod.ResumeLayout(false);
            this.panelPaymentMethod.PerformLayout();
            this.panelDeliveryMethod.ResumeLayout(false);
            this.panelDeliveryMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAddToAccount;
        private System.Windows.Forms.RadioButton radioButtonCreditCard;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label labelChoosePaymentMethod;
        private System.Windows.Forms.RadioButton radioButtonPool;
        private System.Windows.Forms.RadioButton radioButtonAppartment;
        private System.Windows.Forms.RadioButton radioButtonTakeAway;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.Panel panelPaymentMethod;
        private System.Windows.Forms.Panel panelDeliveryMethod;
        private System.Windows.Forms.Label labelBalance;
    }
}
