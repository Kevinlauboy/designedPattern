using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.calculator
{
    class OperateSubFactory : IoperateFactory
    {
        public Operate createOperate()
        {
            return new OperateSub();
        }
    }
}
