using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeusPalace.Entities.Order
{
    internal class Message
    {
        public User Sender { get; set; }
        public string MessageString { get; set; }

        public Message(User sender, string message)
        {
            Sender = sender;
            MessageString = message;
        }
    }
}
