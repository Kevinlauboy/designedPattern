using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashRegister.strategy
{
    //正价结算类
    class CashNormal :Cash
    {
        public double receipt(double money)
        {
            return money;
        }
    }
}
