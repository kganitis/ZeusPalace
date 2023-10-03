using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ZeusPalace.Modules.Orders.UserControls;
using ZeusPalace.Modules.Orders.UserControls.ChatUserControls;

namespace ZeusPalace.Modules.Orders
{
    public partial class ChatForm : ZeusPalace.Modules.EmbeddedForm
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        public event EventHandler MessageSent;

        public string LastMessageSent;

        private string DefaultMessage => richTextBoxTypeMessage.Tag.ToString();

        private string Message
        {
            get => richTextBoxTypeMessage.Text;
            set => richTextBoxTypeMessage.Text = value;
        }

        private bool MessageIsTyped => Message.Length != 0 && !Message.Equals(DefaultMessage);

        private void richTextBoxTypeMessage_Click(object sender, EventArgs e)
        {
            richTextBoxTypeMessage.Clear();
            richTextBoxTypeMessage.ForeColor = Color.Black;
        }

        private void richTextBoxTypeMessage_Leave(object sender, EventArgs e)
        {
            if (Message == string.Empty)
            {
                richTextBoxTypeMessage.ForeColor = Color.DimGray;
                Message = DefaultMessage;
            }
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            if (MessageIsTyped)
            {
                LastMessageSent = Message;
                if (GetType() == typeof(CustomerChatForm))
                {
                    panelMessages.Controls.Add(new CustomerMessageControl(Message));
                }
                else
                {
                    panelMessages.Controls.Add(new EmployeeMessageControl(Message));
                }
                panelMessages.VerticalScroll.Value = panelMessages.VerticalScroll.Maximum;
                richTextBoxTypeMessage_Click(this, EventArgs.Empty);
                richTextBoxTypeMessage.Focus();
                MessageSent?.Invoke(this, EventArgs.Empty);
            }
        }

        public void ReceiveMessage(string message)
        {
            if (GetType() == typeof(CustomerChatForm))
            {
                panelMessages.Controls.Add(new EmployeeMessageControl(message));
            }
            else
            {
                panelMessages.Controls.Add(new CustomerMessageControl(message));
            }
            panelMessages.VerticalScroll.Value = panelMessages.VerticalScroll.Maximum;
        }

        private void richTextBoxTypeMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Control.ModifierKeys == Keys.Shift)
                {
                    // Shift+Enter: Insert a new line in the RichTextBox
                    richTextBoxTypeMessage.AppendText(string.Empty);
                }
                else
                {
                    // Enter: Send the message (trigger button click)
                    e.Handled = true; // Prevent the Enter key from being inserted into the text
                    buttonSendMessage.PerformClick();
                }
            }
        }

        private void richTextBoxTypeMessage_TextChanged(object sender, EventArgs e)
        {
            if (richTextBoxTypeMessage.Text.Length > richTextBoxTypeMessage.MaxLength - 50)
            {
                labelCharacterCount.Visible = true;
                labelCharacterCount.Text = $"{richTextBoxTypeMessage.Text.Length}/{richTextBoxTypeMessage.MaxLength}";
            }
            else
            {
                labelCharacterCount.Visible = false;
            }
        }
    }
}
