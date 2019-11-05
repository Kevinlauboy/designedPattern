using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CashRegister.pattern
{
    //结算抽象类
    abstract class Cash
    {
        public  abstract double receipt(double money);
    }
}
