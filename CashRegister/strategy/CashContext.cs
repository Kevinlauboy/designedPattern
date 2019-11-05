using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashRegister.strategy
{
    //结算策略
    class CashContext
    {
        private Cash cashImp;
        public Cash CashImp
        {
            set { cashImp = value; }
        }

        public double getReceipt(double money)
        {
            return cashImp.receipt(money);
        }

    }
}
