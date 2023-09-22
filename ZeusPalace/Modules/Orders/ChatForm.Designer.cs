namespace ZeusPalace.Modules.Orders
{
    partial class ChatForm
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
            this.panelMessages = new System.Windows.Forms.Panel();
            this.richTextBoxTypeMessage = new System.Windows.Forms.RichTextBox();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMessages
            // 
            this.panelMessages.AutoScroll = true;
            this.panelMessages.Location = new System.Drawing.Point(10, 10);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(300, 500);
            this.panelMessages.TabIndex = 6;
            // 
            // richTextBoxTypeMessage
            // 
            this.richTextBoxTypeMessage.BackColor = System.Drawing.Color.Linen;
            this.richTextBoxTypeMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTypeMessage.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTypeMessage.ForeColor = System.Drawing.Color.DimGray;
            this.richTextBoxTypeMessage.Location = new System.Drawing.Point(10, 515);
            this.richTextBoxTypeMessage.Name = "richTextBoxTypeMessage";
            this.richTextBoxTypeMessage.Size = new System.Drawing.Size(300, 85);
            this.richTextBoxTypeMessage.TabIndex = 4;
            this.richTextBoxTypeMessage.Tag = "Γράψτε το μήνυμά σας...";
            this.richTextBoxTypeMessage.Text = "Γράψτε το μήνυμά σας...";
            this.richTextBoxTypeMessage.Enter += new System.EventHandler(this.richTextBoxTypeMessage_Enter);
            this.richTextBoxTypeMessage.Leave += new System.EventHandler(this.richTextBoxTypeMessage_Leave);
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSendMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(112)))));
            this.buttonSendMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSendMessage.FlatAppearance.BorderSize = 0;
            this.buttonSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendMessage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.buttonSendMessage.Location = new System.Drawing.Point(10, 605);
            this.buttonSendMessage.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(300, 50);
            this.buttonSendMessage.TabIndex = 8;
            this.buttonSendMessage.Text = "Αποστολή μηνύματος";
            this.buttonSendMessage.UseVisualStyleBackColor = false;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(320, 660);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.panelMessages);
            this.Controls.Add(this.richTextBoxTypeMessage);
            this.Name = "ChatForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxTypeMessage;
        protected System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Button buttonSendMessage;
    }
}
