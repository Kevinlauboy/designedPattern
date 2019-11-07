using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MemoPattern.gameBackup;
using MemoPattern.memoBase;
namespace MemoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole lixiaoyao = new GameRole();
            //大战前
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();
            
            //保存进度
            GameRole backup = new GameRole();
            backup.Vit = lixiaoyao.Vit;
            backup.Atk = lixiaoyao.Atk;
            backup.Def = lixiaoyao.Def;

            //大战Boss时
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            //恢复之前
            lixiaoyao.Vit = backup.Vit;
            lixiaoyao.Atk = backup.Atk;
            lixiaoyao.Def = backup.Def;
            lixiaoyao.StateDisplay();

            Originator o = new Originator();
            o.State = "on";
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();
            
            o.State ="Off";
            o.Show();

            o.SetMemento(c.Memento);
            o.Show();
            Console.Read();
        }
    }
}
