using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashRegister.pattern
{
    class CashFactory
    {
         public static Cash createCash(string type){
             Cash cash = null;
             switch (type) { 
                 case "正常收费":
                     cash = new CashNormal();
                     break;
                 case "打8折":
                     cash = new CashDiscount("0.8");
                     break;
                 case "满300返100":
                     cash = new CashReduction("1000","100");
                     break;
                 default:
                     cash = new CashNormal();
                     break;

             }
             return cash;
         }
    }
}
