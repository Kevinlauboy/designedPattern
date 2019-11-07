using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoPattern.gameBackup
{
    class GameRole
    {
        public int vit;
        public int atk;
        public int def;
        //创建备忘录
        public RoleStateMemento saveState()
        {
            return new RoleStateMemento(vit, atk, def);
        }

        //恢复角色状态
        public void RecoveryState(RoleStateMemento memento)
        {
            this.vit = memento.Vit;
            this.atk = memento.Atk;
            this.def = memento.Def;
        }
        
        //状态显示
        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态");
            Console.WriteLine("体力:{0}",this.vit);
            Console.WriteLine("攻击力:{0}",this.atk);
            Console.WriteLine("防御力:{0}",this.def);
            Console.WriteLine("");
        }
        //初始化状态
        public void GetInitState()
        {
            this.vit = 100;
            this.atk = 100;
            this.def = 100;
        }

        //战斗
        public void Fight()
        {
            this.vit = 0;
            this.atk = 0;
            this.def = 0;
        }
        
    }
}
