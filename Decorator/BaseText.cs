using Design_Patterns_Assignment.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class BaseText : IText
    {
        public string description{ get; set; }
       
        public BaseText()
        {
            description = "";
        }
        public string TextDecorate()
        {
            return description;
        }

        public void UserInput()
        {
            bool validInput = false;
            while (!validInput)
            {
                string userInput = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    validInput = true;
                    description = userInput;
                }
            }
        }
    }
}
