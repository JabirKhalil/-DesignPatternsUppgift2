using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
   public class ItalicText :BaseDecorator
    {
        public ItalicText(IText text) : base(text)
        {

            description = "<i>";
            description1 = "</i>";
        }

    }
}
