using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   public class MarkedText : BaseDecorator
    {
        public MarkedText(IText text):base(text)
        {
            description = "<mark>";
            description1 = "</mark>";
        }
    }
}
