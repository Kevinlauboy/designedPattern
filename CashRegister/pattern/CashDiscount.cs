using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashRegister.pattern
{
    //打折结算类
    class CashDiscount : Cash
    {
        private double rebate = 1d;
        public CashDiscount(string strRebate)
        {
            this.rebate = double.Parse(strRebate);
        }
        public override double receipt(double money)
        {
            return money * rebate;
        }
    }
}
