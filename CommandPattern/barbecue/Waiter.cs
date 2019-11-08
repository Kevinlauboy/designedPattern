using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.barbecue
{
    class Waiter
    {
        //命令订单
        private IList<Command> orders = new List<Command>();


        //设置订单
        public void SetOrder(Command command)
        {
            Console.WriteLine(command.ToString());
            if (command.ToString() == "CommandPattern.barbecue.BakeChickenWingCommand")
            {
                Console.WriteLine("鸡翅没有了，请点别的烧烤");
            }
            else 
            {
                orders.Add(command);
                Console.WriteLine("增加订单:" + command.ToString() +
                    "时间:" + DateTime.Now.ToString());
            }
        }

        //取消订单
        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单：" + command.ToString() + "  时间：" + DateTime.Now.ToString());
        }
        //通知执行
        public void Notify()
        {
            foreach (Command cmd in orders)
            {
                cmd.ExcuteCommand();
            }
        }
    }
}
