using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MemoPattern.gameBackup
{
    class RoleStateMemento
    {
        public RoleStateMemento(int vit, int atk, int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }
        //生命力
        private int vit;

        public int Vit
        {
            get { return vit; }
            set { vit = value; }
        }

        //攻击力
        private int atk;

        public int Atk
        {
            get { return atk; }
            set { atk = value; }
        }

        //防御力
        private int def;

        public int Def
        {
            get { return def; }
            set { def = value; }
        }
    }
}
