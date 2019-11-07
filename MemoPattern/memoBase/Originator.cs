using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoPattern.memoBase
{
    class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set { state = value; }
        }
        //备份
        public Memento CreateMemento()
        {
            return (new Memento(state));
        }

        //恢复
        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }

        public void Show()
        {
            Console.WriteLine("State=" + state);
        }
    }
}
