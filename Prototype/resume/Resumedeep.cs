using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Prototype.resume
{
    class Resumedeep : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkExperience workExp;
        public Resumedeep(string name)
        {
            this.name = name;
            this.workExp = new WorkExperience();
        }

        public Resumedeep(WorkExperience workExp)
        {
            this.workExp = (WorkExperience)workExp.Clone();
        }

        //设置个人信息
        public void SetPersonal(string sex, string age)
        {
            this.age = age;
            this.sex = sex;
        }

        //显示
        public void display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历: {0} {1}", workExp.TimeArea, workExp.Company);
        }

        public Object Clone()
        {
            Resumedeep obj = new Resumedeep(workExp);
            obj.name = name;
            obj.sex = sex;
            obj.age = age;
            return obj;
        }

        internal void SetWorkExperience(string timeArea, string company)
        {
            this.workExp.TimeArea = timeArea;
            this.workExp.Company = company;
        }
    }
}
