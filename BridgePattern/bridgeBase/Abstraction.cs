using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern.bridgeBase
{
    class Abstraction
    {
        protected Implementor implementor;
        public void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }
        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
