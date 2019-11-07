using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.statebase
{
    class ConcreteStateB :State
    {
        void State.Handler(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
