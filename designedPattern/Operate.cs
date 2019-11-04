using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace designedPattern
{
    class Operate
    {
        private double numberA;
        private double numberB;
        private string strOperate;
        private double result = 0d;
        public Operate(double numberA, double numberB, string operate)
        {
            this.numberA = numberA;
            this.numberB = numberB;
            strOperate = operate;
        }
        public double getResult()
        {
            switch (strOperate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    if (numberB != 0)
                        result = numberA / numberB;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
