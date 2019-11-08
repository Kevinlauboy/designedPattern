using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern.IteratorBase
{
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
