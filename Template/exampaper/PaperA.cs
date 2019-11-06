using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.exampaper
{
    class PaperA : Paper
    {
        protected override string Answer1()
        {
            return "A";
        }

        protected override string Answer2()
        {
            return "B";
        }

        protected override string Answer3()
        {
            return "C";
        }
    }
}
