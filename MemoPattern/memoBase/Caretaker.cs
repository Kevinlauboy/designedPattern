﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoPattern.memoBase
{
    class Caretaker
    {
        private Memento memento;

        public  Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }

    }
}
