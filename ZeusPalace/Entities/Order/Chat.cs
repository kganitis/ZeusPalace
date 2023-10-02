using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Order
{
    internal class Chat
    {
        public List<Message> Messages { get; private set; }

        public Chat()
        {
            Messages = new List<Message>();
        }

        public void SendMessage(User sender, string message)
        {
            Messages.Add(new Message(sender, message));
        }

        public void DisplayChat()
        {
            foreach (var message in Messages)
            {
                Console.WriteLine(message.Sender + ": " + message.MessageString);
            }
        }
    }
}
