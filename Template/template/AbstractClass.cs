﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.template
{
    abstract class AbstractClass
    {   
                             
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod() {
            PrimitiveOperation1();
            PrimitiveOperation2();
        }
    }
}
