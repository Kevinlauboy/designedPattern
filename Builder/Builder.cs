using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product getProduct();
    }
}
