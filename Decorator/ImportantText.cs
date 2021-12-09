using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   public class ImportantText:BaseDecorator
    {
        public ImportantText(IText text):base(text)
        {
            description = "<strong>";
            description1 = "</strong>";
        }
    }
}
