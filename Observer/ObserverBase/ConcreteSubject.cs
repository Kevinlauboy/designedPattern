using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern.ObserverBase
{
    class ConcreteSubject : Subject
    {
        private string subjectState;

        public  string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }

    }
}
