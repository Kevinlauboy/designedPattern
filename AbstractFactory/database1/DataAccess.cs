using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
namespace AbstractFactory.database1
{
    class DataAccess
    {
        private static readonly string AssemblyName = "AbstractFactory";
        private static readonly string spaceName = "AbstractFactory.database1";
        private static readonly string db = "SqlServer";
        //private static readonly string db = "Access";

        public static IUser CreateUser()
        {
            string className = spaceName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            string className = spaceName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}
