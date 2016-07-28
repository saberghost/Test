using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函数_练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            string strA = Console.ReadLine();
            int number = GetNumber(strA);
            Console.WriteLine(number);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断输入的字符是否为数字
        /// </summary>
        /// <param name="strA">获取输入的字符</param>
        /// <returns>返回数字的值</returns>
        public static int GetNumber(string strA)
        {
            while(true)
            {
                try
                {
                    int number = Convert.ToInt32(strA);
                    return number;
                }
                catch
                {
                    Console.WriteLine("你输入的数字有误！");
                    strA = Console.ReadLine();
                }
            }
        }
    }
}
