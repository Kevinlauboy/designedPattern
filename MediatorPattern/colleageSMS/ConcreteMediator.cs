﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern.colleageSMS
{
    class ConcreteMediator:Mediator
    {
        private ConcreteColleague1 colleague1;
        public  ConcreteColleague1 Colleague1
        {
            set { colleague1 = value; }
        }
        private ConcreteColleague2 colleague2;

        public ConcreteColleague2 Colleague2
        {
            set { colleague2 = value; }
        }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague1 == colleague)
            {
                colleague2.Notify(message);
            }
            else
            {
                colleague1.Notify(message);
            }
        }
    }
}
