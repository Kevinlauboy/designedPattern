using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.BossCome
{
    //通知者接口
    interface Subject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string SubjectState
        {
            get;
            set;
        }
    }
}
