using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class InsertedText : BaseDecorator
    {
        public InsertedText(IText text) : base(text)
        {
            description = "<ins>";
            description1 = "</ins>";
        }
    }
}
