using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern.IteratorBase
{
    
    class ConcreteIterator : Iterator
    {
        private int current = 0;
        private ConcreteAggregate aggregate;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            object ret = null;
            current++;

            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }

            return ret;
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }
}
