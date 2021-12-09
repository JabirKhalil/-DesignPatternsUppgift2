using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public abstract class BaseDecorator : IText
    {
        public IText TextDeco { get; set; }
        public string description;
        public string description1;

        public BaseDecorator(IText text)
        {
            TextDeco = text;
        }
        public string TextDecorate()
        {            
            return description + TextDeco.TextDecorate() + description1;
        }
       
    }
}
