using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PursuitGirl.PursuitGirl
{
    //追求者
    class Pursuit : GiveGift
    {
        private SchoolGirl mm;
        private string name;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }

        public Pursuit(string name, SchoolGirl mm)
        {
            this.name = name;
            this.mm = mm;
        }

        public void giveDolls() {
            Console.WriteLine(name + "送" + mm.Name + "洋娃娃");
        }
        public void giveFlowers()
        {
            Console.WriteLine(name + "送" + mm.Name + "花");
        }
        public void giveChocolate()
        {
            Console.WriteLine(name + "送" + mm.Name + "送巧克力");
        }
    }
}
