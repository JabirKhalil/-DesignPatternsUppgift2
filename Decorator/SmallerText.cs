using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class SmallerText : BaseDecorator
    {
        public SmallerText(IText text):base(text)
        {
            description = "<small>";
            description1 = "</small>";
        }
    }
}
