using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.calculator
{
    interface IoperateFactory
    {
        Operate createOperate();
    }
}
