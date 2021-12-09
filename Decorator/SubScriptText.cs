using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class SubScriptText : BaseDecorator
    {
        public SubScriptText(IText text):base(text)
        {
            description = "<sub>";
            description1 = "</sub>";

        }
    }
}
