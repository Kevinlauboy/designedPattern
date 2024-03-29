﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace designedPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*简单工厂----计算器例子*/
            try
            {
                Console.Write("输入数字A:");
                string strNumberA = Console.ReadLine();
                Console.Write("运算符号:");
                string strOperate = Console.ReadLine();
                Console.Write("输入数字B:");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                Operate operate = OperateFactory.createOperate(strOperate);
                operate.NumberA = Convert.ToDouble(strNumberA);
                operate.NumberB = Convert.ToDouble(strNumberB);
                strResult=operate.getResult().ToString(); 
                Console.WriteLine(strResult);
                Console.ReadLine();
            }
            catch (Exception ex){
                Console.WriteLine("您的输入有错:" + ex.Message);
            }
        }
    }
}
