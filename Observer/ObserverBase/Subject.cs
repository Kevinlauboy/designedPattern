using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.ObserverBase
{
    //抽象通知者类
    abstract class Subject
    {
        //观察者链表
        private IList<Observer> observers = new List<Observer>();
        //增加观察者,注册观察者
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        //删除观察者,撤销观察者
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
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
            get;
            set;
        }
    }
}
