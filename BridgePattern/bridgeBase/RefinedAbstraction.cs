using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.bridgeBase
{
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
