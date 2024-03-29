﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.commanBase
{
    class Invoker
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
