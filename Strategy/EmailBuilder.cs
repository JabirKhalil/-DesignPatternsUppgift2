using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class EmailBuilder : ISendText
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Sending " + message + " Email");
        }
    }
}
