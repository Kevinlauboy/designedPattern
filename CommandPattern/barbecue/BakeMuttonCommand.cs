using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.barbecue
{
    //烤面包命令具体类
    class BakeMuttonCommand: Command
    {
        public BakeMuttonCommand(Barbecuer receiver)
            : base(receiver)
        {

        }
        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
