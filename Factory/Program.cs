using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory.calculator;
using Factory.factory;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*工厂模式列子----计算器
            Operate operate = null;
            string strOper = "+";
            switch (strOper)
            {
                case "+":
                    operate = new OperateAddFactory().createOperate();
                    break;
                case "-":
                    operate = new OperateSubFactory().createOperate();
                    break;
                case "*":
                    operate = new OperateMulFactory().createOperate();
                    break;
                case "/":
                    operate = new OperateDivFactory().createOperate();
                    break;
            }
            operate.NumberA = 10.3d;
            operate.NumberB = 12.3d;
            double res = operate.getResult();
            Console.WriteLine(res.ToString());
            */

            /*工厂模式*/
            Creator creator = new CreatorProductA();
            Product product = creator.createProduct();
            product.appliation();
        }
    }
}
