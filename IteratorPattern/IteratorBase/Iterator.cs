using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern.IteratorBase
{
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
