using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.statebase
{
    interface State
    {
        void Handler(Context context);
    }
}
