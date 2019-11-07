using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.BossCome
{
    class StockObserver : Observer
    {
        public StockObserver(string name, Subject sub)
            : base(name, sub)
        {

        }
        public override void Update()
        {
            Console.WriteLine("{0}{1} 关闭股市行情，继续工作!", sub.SubjectState, name);
        }
    }
}
