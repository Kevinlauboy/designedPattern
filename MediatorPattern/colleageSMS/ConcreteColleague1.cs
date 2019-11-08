using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern.colleageSMS
{
    class ConcreteColleague1: Colleague
    {
        public ConcreteColleague1(Mediator mediator)
            : base(mediator)
        {

        }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("同事1得到信息:" + message);
        }
    }
}
