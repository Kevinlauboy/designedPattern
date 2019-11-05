using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashRegister.strategy
{
    interface Cash
    {
        double receipt(double money);
    }
}
