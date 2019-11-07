using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.statebase
{
    class ConcreteStateA : State
    {
        void State.Handler(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}
