using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PursuitGirl.PursuitGirl
{
    //追求者的代理人
    class Proxy : GiveGift
    {
        private GiveGift pursuitProxy;
        public Proxy(string name,SchoolGirl mm)
        {
            this.pursuitProxy = new Pursuit(name,mm);
        }
        public void giveDolls()
        {
            pursuitProxy.giveDolls();
        }
        public void giveFlowers()
        {
            pursuitProxy.giveFlowers();
        }
        public void giveChocolate()
        {
            pursuitProxy.giveChocolate();
        }
    }
}
