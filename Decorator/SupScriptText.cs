using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    class SupScriptText: BaseDecorator
    {
        public SupScriptText(IText text):base(text)
        {
            description = "<sup>";
            description1 = "</sup>";
        }
    }
}
