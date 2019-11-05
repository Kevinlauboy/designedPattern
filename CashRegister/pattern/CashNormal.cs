using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashRegister.pattern
{
    //正价结算类
    class CashNormal :Cash
    {
        public override double receipt(double money)
        {
            return money;
        }
    }
}
