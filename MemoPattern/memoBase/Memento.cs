using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoPattern.memoBase
{
    //备忘录类
    class Memento
    {
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public Memento(string state)
        {
            this.state = state;
        }
    }
}
