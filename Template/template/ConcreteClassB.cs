﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.template
{
    class ConcreteClassB : AbstractClass
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("具体类B实现的方法1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("具体类B实现的方法2");
        }
    }
}
