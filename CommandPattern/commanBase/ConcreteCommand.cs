using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.commanBase
{
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver):base(receiver)
        {
            receiver.Action();
        }
        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
