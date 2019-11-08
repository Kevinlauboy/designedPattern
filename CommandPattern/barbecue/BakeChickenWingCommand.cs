using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.barbecue
{
    //烤羊肉串命令
    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver)
            : base(receiver)
        { }

        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
