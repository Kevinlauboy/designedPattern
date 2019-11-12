using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fyweightPattern.fyweightBase
{
    class UnsharedConcreteFlyweight :Flyweight
    {

        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("不共享具体Flvweight:" + extrinsicstate);
        }
    }
}
