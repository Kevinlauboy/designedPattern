using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.barbecue
{
    abstract class Command
    {
        protected Barbecuer receiver;

        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }
        //执行命令
        abstract public void ExcuteCommand();
    }
}
