using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace designedPattern
{
    class OperateSub : Operate
    {
        public OperateSub() {
          
        }
        public OperateSub(double numberA, double numberB)
            : base(numberA, numberB)
        {

        }
        public override double getResult()
        {
            return numberA - numberB;
        }
    }
}
