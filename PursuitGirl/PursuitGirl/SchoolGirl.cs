using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PursuitGirl.PursuitGirl
{
    //被追求者类
    class SchoolGirl
    {
        public SchoolGirl(string name)
        {
            this.name = name;
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
