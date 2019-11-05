using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashRegister.strategy
{
    //满减结算类
    class CashReduction : Cash
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        //ctor 代码段，快速增加构造函数
        public CashReduction(string strMoneyCondition,string strMoneyReturn)
        {
            this.moneyCondition = double.Parse(strMoneyCondition);
            this.moneyReturn = double.Parse(strMoneyReturn);
        }
        public  double receipt(double money)
        {
            double result = money;
            if (result > moneyCondition) {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}
