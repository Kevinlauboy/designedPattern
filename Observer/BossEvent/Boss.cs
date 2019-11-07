using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.BossEvent
{
    class Boss : Subject
    {
        //同事列表
        private IList<Observer> observers = new List<Observer>();
        private string action;

        public event EventHandle Update;

        public void Notify()
        {
            Update();
        }

        public string SubjectState
        {
            get{return action;}
            set{action = value;}
        }
    }
}
