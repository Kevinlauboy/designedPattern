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
                switch (strOperate)
                {
                    case "+":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) +     Convert.ToDouble(strNumberB));
                        break;
                    case "-":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                        break;
                    case "*":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                        break;
                    case "/":
                        if (strNumberB != "0")
                            strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                        else
                            Console.WriteLine("除数不能为0");
                        break;
                    default:
                        Console.WriteLine("输入的参数不正确");
                        break;
                }
                Console.WriteLine(strResult);
                Console.ReadLine();
            }
            catch (Exception ex){
                Console.WriteLine("您的输入有错:" + ex.Message);
            }
        }
    }
}
