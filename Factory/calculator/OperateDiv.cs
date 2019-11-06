using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory.calculator
{
    class OperateDiv : Operate
    {
        public OperateDiv()
        {

        }
        public OperateDiv(double numberA, double numberB)
            : base(numberA, numberB)
        {

        }
        public override double getResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除数不能为0。");
            return numberA / numberB;
        }
    }
}
