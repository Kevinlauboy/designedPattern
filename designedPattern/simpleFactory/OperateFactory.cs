using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace designedPattern
{
    class OperateFactory
    {
        public static Operate createOperate(string strOperate) {
            //简单工厂模式核心，创建一个具体计算方法类
            Operate operate = null;
            switch (strOperate) { 
                case "+":
                    operate = new OperateAdd();
                    break;
                case "-":
                    operate = new OperateSub();
                    break;
                case "*":
                    operate = new OperateMul();
                    break;
                case "/":
                    operate = new OperateDiv();
                    break;
                default:
                    break;
            }
            return operate;
        }
    }
}
