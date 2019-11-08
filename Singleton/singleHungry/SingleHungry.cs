using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern.singleHungry
{
    class SingleHungry
    {
        private static readonly SingleHungry instance = new SingleHungry();
        private SingleHungry()
        {

        }
        public static SingleHungry GetInstance()
        {
            return instance;
        }
    }
}
