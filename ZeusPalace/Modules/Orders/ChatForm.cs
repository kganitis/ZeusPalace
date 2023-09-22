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

        protected int nextMessageLocationY;

        private string DefaultMessage => richTextBoxTypeMessage.Tag.ToString();

        private string Message
        {
            get => richTextBoxTypeMessage.Text;
            set => richTextBoxTypeMessage.Text = value;
        }

        private bool MessageIsTyped()
        {
            return Message.Length != 0
                && !Message.Equals(DefaultMessage);
        }

        private void richTextBoxTypeMessage_Enter(object sender, EventArgs e)
        {
            RichTextBox textBox = (RichTextBox)sender;
            textBox.Clear();
            textBox.ForeColor = Color.Black;
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
            if (MessageIsTyped())
            {
                CustomerMessageControl newMessage = new CustomerMessageControl(Message);
                panelMessages.Controls.Add(newMessage);
                richTextBoxTypeMessage.Clear();
                Focus();
                richTextBoxTypeMessage_Leave(this, EventArgs.Empty);
            }
        }
    }
}
