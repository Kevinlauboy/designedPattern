using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.stateexample
{
    class RestState : State
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine("当前时间：{0}点 下班回家了", work.Hour);
        }
    }
}
