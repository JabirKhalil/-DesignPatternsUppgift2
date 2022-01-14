using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class TextFactory
    {
        public static IText CreateText()
        {
            return new BaseText();
        }
    }
}
