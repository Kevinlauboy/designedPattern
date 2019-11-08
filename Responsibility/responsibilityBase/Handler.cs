using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResponsibilityPattern.responsibilityBase
{
    abstract class Handler
    {
        //链路中的传递元素
         protected Handler successor;

        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }
        public abstract void HandleRequest(int request);

    }
}
