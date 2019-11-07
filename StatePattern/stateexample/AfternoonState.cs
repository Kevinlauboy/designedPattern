using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.stateexample
{
    //下午工作状态
    class AfternoonState : State
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 17)
            {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力", work.Hour);
            }
            else
            {
                work.Current = new EveningState();
                work.WriteProgram();
            }
        }
    }
}
