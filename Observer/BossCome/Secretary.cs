using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.BossCome
{
    //通风报信的秘书类
    class Secretary : Subject
    {
        //同事列表
        private IList<Observer> observers = new List<Observer>();
        private string action;

        //增加被通知的同事
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        //删除被通知的同事
        public void Detach(Observer observer)
        {
            observers.Remove(observer); ;
        }
        //通知
        public void Notify()
        {
            foreach (Observer obs in observers)
            {
                obs.Update();
            }
        }
        public string SubjectState
        {
            get { return action; }
            set { action = value; }
        }

    }
}
