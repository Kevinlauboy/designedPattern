using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPattern.colleageSMS
{
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
