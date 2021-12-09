using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   public class EmphasizedText : BaseDecorator
    {
        public EmphasizedText(IText text):base(text)
        {
            description = "<em>";
            description1 = "</em>";
        }
    }
}
