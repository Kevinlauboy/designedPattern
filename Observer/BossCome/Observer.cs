using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.BossCome
{
   
    abstract class Observer
    {
        protected string name;
        protected Subject sub;
        public Observer(string name,Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        abstract public void Update();
    }
}
