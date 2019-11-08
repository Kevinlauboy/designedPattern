using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//懒汉型
namespace SingletonPattern.singleonPattern
{
    class Singleprocs
    {
        private static Singleprocs instance;
        private static readonly object syncRoot = new object();
        private Singleprocs()
        {

        }
        public static Singleprocs GetInstance()
        {
            //双重锁定
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleprocs();
                    }
                }
            }
            return instance;
        }
    }
}
