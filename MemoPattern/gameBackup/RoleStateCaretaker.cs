using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoPattern.gameBackup
{
    class RoleStateCaretaker
    {
        private RoleStateMemento memento;

        public  RoleStateMemento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
