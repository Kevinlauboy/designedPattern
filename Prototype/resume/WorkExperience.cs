using System;
namespace Prototype.resume
{
    class WorkExperience
    {
        private string timeArea;
        public string TimeArea
        {
            get { return timeArea; }
            set { timeArea = value; }
        }
        private string company;
        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
