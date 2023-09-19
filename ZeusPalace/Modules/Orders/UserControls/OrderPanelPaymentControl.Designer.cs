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
            this.panelMain.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.radioButtonCash);
            this.panelMain.Controls.Add(this.radioButtonPool);
            this.panelMain.Controls.Add(this.radioButtonAppartment);
            this.panelMain.Controls.Add(this.radioButtonTakeAway);
            this.panelMain.Controls.Add(this.radioButtonAddToAccount);
            this.panelMain.Controls.Add(this.radioButtonCreditCard);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.labelChoosePaymentMethod);
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(253, 36);
            this.labelTitle.Size = new System.Drawing.Size(458, 35);
            this.labelTitle.Text = "Η παραγγελία σας επιβεβαιώθηκε!";
            // 
            // labelChoosePaymentMethod
            // 
            this.labelChoosePaymentMethod.AutoSize = true;
            this.labelChoosePaymentMethod.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoosePaymentMethod.Location = new System.Drawing.Point(100, 96);
            this.labelChoosePaymentMethod.Name = "labelChoosePaymentMethod";
            this.labelChoosePaymentMethod.Size = new System.Drawing.Size(345, 35);
            this.labelChoosePaymentMethod.TabIndex = 3;
            this.labelChoosePaymentMethod.Text = "Επιλέξτε τρόπο πληρωμής";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Επιλέξτε τρόπο παραλαβής";
            // 
            // radioButtonCreditCard
            // 
            this.radioButtonCreditCard.AutoSize = true;
            this.radioButtonCreditCard.Location = new System.Drawing.Point(512, 113);
            this.radioButtonCreditCard.Name = "radioButtonCreditCard";
            this.radioButtonCreditCard.Size = new System.Drawing.Size(118, 17);
            this.radioButtonCreditCard.TabIndex = 5;
            this.radioButtonCreditCard.TabStop = true;
            this.radioButtonCreditCard.Text = "Πληρωμή με κάρτα";
            this.radioButtonCreditCard.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddToAccount
            // 
            this.radioButtonAddToAccount.AutoSize = true;
            this.radioButtonAddToAccount.Location = new System.Drawing.Point(512, 177);
            this.radioButtonAddToAccount.Name = "radioButtonAddToAccount";
            this.radioButtonAddToAccount.Size = new System.Drawing.Size(199, 17);
            this.radioButtonAddToAccount.TabIndex = 6;
            this.radioButtonAddToAccount.TabStop = true;
            this.radioButtonAddToAccount.Text = "Προσθήκη στον γενικό λογαριασμό";
            this.radioButtonAddToAccount.UseVisualStyleBackColor = true;
            // 
            // radioButtonTakeAway
            // 
            this.radioButtonTakeAway.AutoSize = true;
            this.radioButtonTakeAway.Location = new System.Drawing.Point(510, 256);
            this.radioButtonTakeAway.Name = "radioButtonTakeAway";
            this.radioButtonTakeAway.Size = new System.Drawing.Size(157, 17);
            this.radioButtonTakeAway.TabIndex = 7;
            this.radioButtonTakeAway.TabStop = true;
            this.radioButtonTakeAway.Text = "Παραλαβή από εστιατόριο";
            this.radioButtonTakeAway.UseVisualStyleBackColor = true;
            // 
            // radioButtonAppartment
            // 
            this.radioButtonAppartment.AutoSize = true;
            this.radioButtonAppartment.Location = new System.Drawing.Point(510, 288);
            this.radioButtonAppartment.Name = "radioButtonAppartment";
            this.radioButtonAppartment.Size = new System.Drawing.Size(159, 17);
            this.radioButtonAppartment.TabIndex = 8;
            this.radioButtonAppartment.TabStop = true;
            this.radioButtonAppartment.Text = "Παράδοση στο διαμέρισμα";
            this.radioButtonAppartment.UseVisualStyleBackColor = true;
            // 
            // radioButtonPool
            // 
            this.radioButtonPool.AutoSize = true;
            this.radioButtonPool.Location = new System.Drawing.Point(510, 320);
            this.radioButtonPool.Name = "radioButtonPool";
            this.radioButtonPool.Size = new System.Drawing.Size(186, 17);
            this.radioButtonPool.TabIndex = 9;
            this.radioButtonPool.TabStop = true;
            this.radioButtonPool.Text = "Παράδοση στην κεντρική πισίνα";
            this.radioButtonPool.UseVisualStyleBackColor = true;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(512, 145);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(172, 17);
            this.radioButtonCash.TabIndex = 10;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Πληρωμή κατά την παράδοση";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // OrderPanelPaymentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "OrderPanelPaymentControl";
            this.Title = "Η παραγγελία σας επιβεβαιώθηκε!";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
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
    }
}
