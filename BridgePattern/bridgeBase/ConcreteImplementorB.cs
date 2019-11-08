using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.bridgeBase
{
    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现B的方法执行");
        }
    }
}
