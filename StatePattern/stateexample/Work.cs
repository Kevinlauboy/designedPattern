using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern.stateexample
{
    class Work
    {
        private State current;
        public Work()
        {
            current = new ForenoonState();
        }
        public State Current
        {
            set { current = value; }
        }

        private double hour;
        private bool taskFinished;

        public bool TaskFinished
        {
            get { return taskFinished; }
            set { taskFinished = value; }
        }
        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}
