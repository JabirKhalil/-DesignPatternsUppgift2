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
        public string description;
        public string TextDecorate()
        {
            return description;
        }
    }
}
