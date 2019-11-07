using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using StatePattern.statebase;
using StatePattern.stateexample;
namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Context context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();
            context.Request();*/

            //紧急项目
            Work emergencyProjects = new Work();
            emergencyProjects.Hour = 9;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 10;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 12;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 13;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 14;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 17;

            //emergencyProjects.WorkFinished = true;
            emergencyProjects.TaskFinished = false;

            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 19;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 22;
            emergencyProjects.WriteProgram();

            Console.Read();

        }
    }
}
