using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace designedPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("输入数字A:");
                string strNumberA = Console.ReadLine();
                Console.Write("运算符号:");
                string strOperate = Console.ReadLine();
                Console.Write("输入数字B:");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                Operate operate = new Operate(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate);
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
