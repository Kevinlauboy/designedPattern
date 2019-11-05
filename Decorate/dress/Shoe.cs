using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate.dress
{
    class Shoe : Clothing
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Shoe");
        }
    }
}
