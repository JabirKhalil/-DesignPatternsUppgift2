using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class SendText
    {
        public ISendText textBuilder { get; set; }

        public void MessageSend(string message)
        {
            textBuilder.SendMessage(message);
        }
    }
}
