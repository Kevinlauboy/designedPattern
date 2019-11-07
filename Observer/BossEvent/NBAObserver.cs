using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.BossEvent
{
    class NBAObserver: Observer
    {

        public NBAObserver(string name, Subject sub)
            : base(name, sub)
        {
        }
        public override void Update()
        {
            Console.WriteLine("{0}{1} 关闭NBA直播，继续工作!", sub.SubjectState, name);
        }
    }
}
