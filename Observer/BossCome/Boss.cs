using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.BossCome
{
    class Boss : Subject
    {
        //同事列表
        private IList<Observer> observers = new List<Observer>();
        private string action;

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer); ;
        }

        public void Notify()
        {
            foreach (Observer obs in observers)
            {
                obs.Update();
            }
        }

        public string SubjectState
        {
            get{return action;}
            set{action = value;}
        }
    }
}
