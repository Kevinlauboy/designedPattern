using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.calculator
{
    class OperateMulFactory : IoperateFactory
    {
        public Operate createOperate()
        {
            return new OperateMul();
        }
    }
}
