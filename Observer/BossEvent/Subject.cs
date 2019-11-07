using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.BossEvent
{
    //通知者接口
    interface Subject
    {
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
        event EventHandle Update;
      
    }
}
