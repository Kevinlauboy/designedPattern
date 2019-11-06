using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//抽象计算方法类，衍生加法，减法...的类
namespace Factory.calculator
{
    class Operate
    {
        protected double numberA = 0;
        protected double numberB = 0;

        public double NumberA
        {
            get { return numberA; }
            set { numberA = value; }
        }
        public double NumberB
        {
            get { return numberB; }
            set { numberB = value; }
        }

        public Operate()
        {

        }

        public Operate(double numberA, double numberB)
        {
            this.numberA = numberA;
            this.numberB = numberB;
        }
        
        public virtual double getResult()
        {
            double result = 0d;
            return result;
        }
    }
}
