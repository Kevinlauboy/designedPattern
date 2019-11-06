using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.calculator
{
    class OperateAdd : Operate
    {
        public OperateAdd() {
          
        }
        public OperateAdd(double numberA, double numberB)
            : base(numberA, numberB)
        {

        }
        public override double getResult()
        {
            return numberA + numberB;
        }
    }
}
