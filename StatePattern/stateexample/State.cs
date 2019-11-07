using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.stateexample
{
    abstract class State
    {
        abstract public void WriteProgram(Work work);
    }
}
