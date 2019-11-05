using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorate.dress
{
    class Clothing : Person
    {
        protected Person person=null;

        public void decorate(Person person) {
            this.person = person;
        }
        public override void Show()
        {
            if (person != null) {
                person.Show();
            }
        }
    }
}
