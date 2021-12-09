using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   public class DeletedText : BaseDecorator
    {
        public DeletedText(IText text):base(text)
        {
            description = "<del>";
            description1 = "</del>";
        }
    }
}
