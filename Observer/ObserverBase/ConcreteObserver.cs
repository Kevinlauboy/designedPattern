using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.ObserverBase
{
    class ConcreteObserver :Observer
    {
        private string name;
        private Subject sub;

        public  Subject Sub
        {
            get { return sub; }
            set { sub = value; }
        }
        public ConcreteObserver(Subject sub,string name)
        {
            this.sub = sub;
            this.name = name;
        }
        public override void Update()
        {
            Console.WriteLine("观察者{0}状态是:\n     {1}\n", name, sub.SubjectState);
        }
    }
}
