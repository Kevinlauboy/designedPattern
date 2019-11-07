using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using AbstractFactory.database;
using AbstractFactory.database1;
namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*抽象工厂模式----更换数据库
            User user = new User();
            Department dept = new Department();
            IFactory factory = new AccessFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);
            IDepartment ip = factory.CreateDepartment();
            ip.Insert(dept);
            ip.GetDepartment(1);*/

            /*抽象工厂模式----使用简单工厂反射机制实现,更换数据库*/
            User user = new User();
            IUser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            Department dept = new Department();
            IDepartment ip = DataAccess.CreateDepartment();
            ip.Insert(dept);
            ip.GetDepartment(1);

            Console.Read();
        }
    }
}
