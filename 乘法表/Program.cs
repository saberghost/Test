using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            Console.Write("请输入一个数字：");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <=num; i++)
            {
                Console.WriteLine("{0}+{1}={2}", i, num - i, num);
            }
            Console.ReadKey();
        }
    }
}
