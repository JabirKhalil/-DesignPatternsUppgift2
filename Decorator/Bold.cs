﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class Bold : BaseDecorator
    {
        public Bold(IText text) : base(text)
        {

            description = "<b>";
            description1 = "</b>";
        }
    }
}
